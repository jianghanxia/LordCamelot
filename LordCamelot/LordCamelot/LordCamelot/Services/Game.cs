using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LordCamelot.Helper;
using LordCamelot.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Prism.Mvvm;
using Xamarin.Forms;

namespace LordCamelot.Services
{
	public class Game : BindableBase
	{
		#region Login

		public string PlayerFace { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public bool IsiOS { get; set; }

		public bool IsStart { get; set; }
		public bool IsNotStart => !IsStart;

		#endregion

		#region Communication

		public string MainAddress { get; set; }
		public string Token { get; set; }
		public string RSAKey { get; set; }
		public string usk { get; set; }
		public string uid { get; set; }
		public string uname { get; set; }
		public string access_key { get; set; }
		public string rguid { get; set; }
		public string rgusk { get; set; }
		public string sguid { get; set; }
		public string nickname { get; set; }

		#endregion

		#region Data

		public ObservableCollection<UserDeck> Deck { get; set; } = new ObservableCollection<UserDeck>();
		public ObservableCollection<UserItem> Item { get; set; } = new ObservableCollection<UserItem>();
		public ObservableCollection<UserServant> Svt { get; set; } = new ObservableCollection<UserServant>();

		public List<UserServant> Servant => Svt?.Where(i => i.Type == 1).ToList();
		public List<UserServant> RitualDress => Svt?.Where(i => i.Type == 6).ToList();

		public ObservableCollection<UserQuest> Quest { get; set; } = new ObservableCollection<UserQuest>();
		public UserGame UserGame { get; set; }
		public ObservableCollection<UserGacha> Gacha { get; set; } = new ObservableCollection<UserGacha>();
		public ObservableCollection<UserPresentBox> PresentBox { get; set; } = new ObservableCollection<UserPresentBox>();
		public ObservableCollection<FollowerInfo> Follower { get; set; } = new ObservableCollection<FollowerInfo>();

		#endregion

		public BattleInfo BattleInfo { get; set; }

		public Game()
		{
		}

		public async Task Login()
		{
			await fgo_server();

			//await bili_api();
			await bili_rsa();
			await bili_login();
			await bili_userinfo();

			await fgo_logintomembercenter();
			await fgo_login();
			await fgo_toplogin();
			await fgo_home();

			MessagingCenter.Send(new LogMessage(this, "登录成功."), "Log");
		}

		#region BiliLogin

		public async Task bili_api()
		{
			Hashtable hs = new Hashtable()
			{
				{"username", CryptData.Encode(UserName)},
				{"password", CryptData.Encode(Password)},
				{"sign", CryptData.Encode(String.Concat(UserName, Password, Constant.AppKey))}
			};
			var response = await Network.HttpPostAsync("https://api.fate-flag.cn/login/login.php?outinggua=1", hs);
			if (response == "false")
			{
				throw new Exception("server_error");
			}

			var json = JObject.Parse(CryptData.Decode(response));

			if (json["code"].ToString() != "0")
			{
				throw new Exception(json["message"].ToString());
			}

			uid = json["uid"].ToString();
			uname = json["uname"].ToString();
			access_key = json["access_key"].ToString();
			PlayerFace = json["face"].ToString();
		}

		public async Task bili_rsa()
		{
			var rsa = new Hashtable
			{
				{"sdk_type", 1},
				{"isRoot", 0},
				{"sign", ""},
				{"merchant_id", Constant.MerchantId},
				{"dp", "1920*1080"},
				{"uid", ""},
				{"support_abis", "x86,armeabi-v7a"},
				{"platform_type", 3},
				{"operators", 2},
				{"model", "MIX 2"},
				{"udid", "agltXWQCYANmAjIBfQF9"},
				{"net", 4},
				{"app_id", Constant.AppId},
				{"game_id", Constant.AppId},
				{"timestamp", FgoHelper.get_timestamp_fgo()},
				{"ver", Constant.GameVersion},
				{"c", 0},
				{"server_id", Constant.ServerId},
				{"version", 1},
				{"domain_switch_count", 0},
				{"pf_ver", "8.0.0"},
				{"domain", "p.biligame.com"},
				{"original_domain", ""},
				{"sdk_log_type", 1},
				{"sdk_ver", "1.6.7.1"},
				{"channel_id", 1}
			};
			GetSign(rsa);

			var jo = JObject.Parse(await Network.GetWebAsync($"http://p.biligame.com/api/client/rsa?{ConvertToParameters(rsa)}"));

			Token = jo["hash"].ToString();
			RSAKey = jo["rsa_key"].ToString();
		}

		public async Task bili_login()
		{
			var login = new Hashtable
			{
				{"sdk_type", 1},
				{"isRoot", 0},
				{"sign", ""},
				{"merchant_id", Constant.MerchantId},
				{"dp", "1920*1080"},
				{"uid", 0},
				{"support_abis", "x86,armeabi-v7a"},
				{"platform_type", 3},
				{"operators", 2},
				{"model", "MIX 2"},
				{"udid", "agltXWQCYANmAjIBfQF9"},
				{"net", 4},
				{"app_id", Constant.AppId},
				{"game_id", Constant.AppId},
				{"timestamp", FgoHelper.get_timestamp_fgo()},
				{"ver", Constant.GameVersion},
				{"c", 0},
				{"server_id", Constant.ServerId},
				{"version", 1},
				{"domain_switch_count", 0},
				{"pf_ver", "8.0.0"},
				{"user_id", UserName},
				{"domain", "p.biligame.com"},
				{"original_domain", ""},
				{"sdk_log_type", 1},
				{"sdk_ver", "1.6.7.1"},
				{"pwd", RsaHelper.RSAEncrypt(Token + Password, RSAKey)},
				{"channel_id", 1}
			};
			GetSign(login);

			var jo = JObject.Parse(await Network.HttpPostAsync("http://p.biligame.com/api/client/login", login));
			if (!jo["code"].ToString().Equals("0"))
			{
				throw new Exception("pwd_error");
			}

			uid = jo["uid"].ToString();
			access_key = jo["access_key"].ToString();
		}

		public async Task bili_userinfo()
		{
			var user = new Hashtable
			{
				{"sdk_type", 1},
				{"isRoot", 0},
				{"sign", ""},
				{"merchant_id", Constant.MerchantId},
				{"dp", "1920*1080"},
				{"uid", uid},
				{"support_abis", "x86,armeabi-v7a"},
				{"platform_type", 3},
				{"operators", 2},
				{"model", "MIX 2"},
				{"udid", "agltXWQCYANmAjIBfQF9"},
				{"net", 4},
				{"app_id", Constant.AppId},
				{"game_id", Constant.AppId},
				{"timestamp", FgoHelper.get_timestamp_fgo()},
				{"ver", Constant.GameVersion},
				{"c", 0},
				{"server_id", Constant.ServerId},
				{"version", 1},
				{"domain_switch_count", 0},
				{"pf_ver", "8.0.0"},
				{"domain", "line3-sdkcenter-login.bilibiligame.net"},
				{"access_key", access_key},
				{"original_domain", ""},
				{"sdk_log_type", 1},
				{"sdk_ver", "1.6.7.1"},
				{"channel_id", 1}
			};
			GetSign(user);

			var jo = JObject.Parse(await Network.GetWebAsync($"http://line3-sdkcenter-login.bilibiligame.net/api/client/user.info?{ConvertToParameters(user)}"));

			uname = jo["uname"].ToString();
			PlayerFace = jo["face"].ToString();
		}

		#endregion

		#region FGO Remote

		public async Task fgo_logintomembercenter()
		{
			var table = new Hashtable
			{
				{"deviceid", Constant.DeviceId},
				{"t", 22360},
				{"v", "1.0.1"},
				{"s", 1},
				{"mac", "00000000000000E0"},
				{"os", Constant.OS},
				{"ptype", Constant.Ptype},
				{"imei", "aaaaa"},
				{"username", uname},
				{"type", "token"},
				{"bundleid", "com.bilibili.fatego"},
				{"rkuid", uid},
				{"access_token", access_key},
				{"rksdkid", 1},
				{"rkchannel", Constant.RKChannel},
				{"appVer", Constant.GameVersion},
				{"dateVer", Constant.DataVer},
				{"lastAccessTime", FgoHelper.get_timestamp_fgo()},
				{"try", ""},
				{"developmentAuthCode", Constant.DevelopmentAuthCode},
				{"version", Constant.DataVer},
				{"dataVer", Constant.DataVer}
			};
			var response = await FGoResponse($"{MainAddress}/rongame_beta/rgfate/60_member/logintomembercenter.php", table);

			Constant.DateVer = response["response"][0]["success"]["dateVer"].ToString();
			rguid = response["response"][0]["success"]["rguid"].ToString();
			rgusk = response["response"][0]["success"]["rgusk"].ToString();
		}

		public async Task fgo_login()
		{
			var table = new Hashtable
			{
				{"deviceid", Constant.DeviceId},
				{"os", Constant.OS},
				{"ptype", Constant.Ptype},
				{"rgsid", 1001},
				{"rguid", rguid},
				{"rgusk", rgusk},
				{"idfa", ""},
				{"v", "1.0.1"},
				{"mac", 0},
				{"imei", ""},
				{"type", "login"},
				{"nickname", "XXXXXX"},
				{"rkchannel", Constant.RKChannel},
				{"assetbundleFolder", ""},
				{"appVer", Constant.GameVersion},
				{"dateVer", Constant.DateVer},
				{"lastAccessTime", FgoHelper.get_timestamp_fgo()},
				{"try", ""},
				{"developmentAuthCode", Constant.DevelopmentAuthCode},
				{"userAgent", 1},
				{"t", 20399},
				{"s", 1},
				{"rksdkid", 1},
				{"dataVer", Constant.DataVer}
			};

			var response = await FGoResponse(GetAddress("login"), table);

			sguid = response["response"][0]["success"]["sguid"].ToString();
			nickname = response["response"][0]["success"]["nickname"].ToString();
		}

		public async Task fgo_toplogin()
		{
			var table = new Hashtable
			{
				{"ac", "action"},
				{"key", "toplogin"},
				{"deviceid", Constant.DeviceId},
				{"os", Constant.OS},
				{"ptype", Constant.Ptype},
				{"usk", usk},
				{"umk", ""},
				{"rgsid", 1001},
				{"rkchannel", Constant.RKChannel},
				{"nickname", nickname},
				{"sgtype", 2},
				{"sgtag", 20161108},
				{"userId", sguid},
				{"appVer", Constant.GameVersion},
				{"dateVer", Constant.DateVer},
				{"lastAccessTime", FgoHelper.get_timestamp_fgo()},
				{"try", ""},
				{"developmentAuthCode", Constant.DevelopmentAuthCode},
				{"userAgent", 1},
				{"dataVer", Constant.DataVer}
			};

			var response = await FGoResponse(GetAddress("ac"), table);

			if (response["response"][0]["success"]["loginbonus"] != null)
			{
				var s = JsonConvert.DeserializeObject<Loginbonus>(response["response"][0]["success"]["loginbonus"].ToString());
				MessagingCenter.Send(new LogMessage(this, $"连续登陆{s.seqLogin}天,总共登陆{s.totalLogin}天"), "Log");
			}

			Helper.Extensions.ReplacedData(this, response["cache"]["replaced"].ToString());
			Helper.Extensions.UpdateData(this, response["cache"]["updated"].ToString());
		}

		public async Task fgo_home()
		{
			var table = new Hashtable
			{
				//{"ac", "home"},
				{"ac", "action"},
				{"key", "home"},
				{"deviceid", Constant.DeviceId},
				{"os", Constant.OS},
				{"ptype", Constant.Ptype},
				{"usk", usk},
				{"umk", ""},
				{"rgsid", 1001},
				{"rkchannel", Constant.RKChannel},
				{"userId", sguid},
				{"appVer", Constant.GameVersion},
				{"dateVer", Constant.DateVer},
				{"lastAccessTime", FgoHelper.get_timestamp_fgo()},
				{"try", ""},
				{"developmentAuthCode", Constant.DevelopmentAuthCode},
				{"userAgent", "1"},
				{"dataVer", Constant.DataVer}
			};

			var response = await FGoResponse(GetAddress("ac"), table);

			Helper.Extensions.ReplacedData(this, response["cache"]["replaced"].ToString());
			Helper.Extensions.UpdateData(this, response["cache"]["updated"].ToString());
		}

		public async Task fgo_followerlist()
		{
			var table = new Hashtable
			{
				{"ac", "action"},
				{"key", "followerlist"},
				{"deviceid", Constant.DeviceId},
				{"os", Constant.OS},
				{"ptype", Constant.Ptype},
				{"usk",usk},
				{"umk", ""},
				{"rgsid", 1001},
				{"rkchannel", Constant.RKChannel},
				{"userId", sguid},
				{"appVer", Constant.GameVersion},
				{"dateVer", Constant.DateVer},
				{"lastAccessTime", FgoHelper.get_timestamp_fgo()},
				{"try", ""},
				{"developmentAuthCode", Constant.DevelopmentAuthCode},
				{"refresh", 1},
				{"userAgent", 1},
				{"dataVer", Constant.DataVer}
			};

			var response = await FGoResponse(GetAddress("ac"), table);

			//var follower = new Dictionary<string, FollowerServant[]>();
			//foreach (var jToken in (JArray)response["cache"]["updated"]["userFollower"][0]["followerInfo"])
		}

		public async Task fgo_gachadraw(int gachaId, int num, int ticketItemId = 0, int shopId = 1)
		{
			var table = new Hashtable
			{
				{"ac", "action"},
				{"key", "gachadraw"},
				{"deviceid", Constant.DeviceId},
				{"os", Constant.OS},
				{"ptype", Constant.Ptype},
				{"usk", usk},
				{"umk", ""},
				{"rgsid", 1001},
				{"rkchannel", Constant.RKChannel},
				{"userId", sguid},
				{"appVer", Constant.GameVersion},
				{"dateVer", Constant.DateVer},
				{"lastAccessTime", FgoHelper.get_timestamp_fgo()},
				{"try", ""},
				{"developmentAuthCode", Constant.DevelopmentAuthCode},
				{"userAgent", 1},
				{"gachaId", gachaId},
				{"num", num},
				{"ticketItemId", ticketItemId},
				{"shopIdIndex", shopId},
				{"gachaSubId", 0},
				{"dataVer", Constant.DataVer}
			};

			var response = await FGoResponse(GetAddress("ac"), table);

			Helper.Extensions.ReplacedData(this, response["cache"]["replaced"].ToString());
			Helper.Extensions.UpdateData(this, response["cache"]["updated"].ToString());
		}

		public async Task<BattleInfo> fgo_battlesetup(string questId, string questPhase, string deckId, string followerId, int followerClass)
		{
			var table = new Hashtable
			{
				{"activeDeckId", deckId},
				{"followerId", followerId},
				{"userEquipId", "0"},
				{"ac", "action"},
				{"key", "battlesetup"},
				{"deviceid", Constant.DeviceId},
				{"os", Constant.OS},
				{"ptype", Constant.Ptype},
				{"usk", usk},
				{"umk", ""},
				{"rgsid", 1001},
				{"rkchannel", Constant.RKChannel},
				{"userId", sguid},
				{"appVer", Constant.GameVersion},
				{"dateVer", Constant.DateVer},
				{"lastAccessTime", FgoHelper.get_timestamp_fgo()},
				{"try", ""},
				{"developmentAuthCode", Constant.DevelopmentAuthCode},
				{"questId", questId},
				{"questPhase", questPhase},
				{"followerClassId", followerClass},
				{"battleMode", 1},
				{"itemId", 0},
				{"enemySelect", 1},
				{"userAgent", 1},
				{"dataVer", Constant.DataVer}
			};
			var response = await FGoResponse(GetAddress("ac"), table);

			var bi = new BattleInfo();
			bi.battleResCode = "00";
			bi.battleExtra = "{}";

			JToken cache;
			try
			{
				cache = JToken.Parse(CryptData.ResponseCacheDecrypt(response["cache"].ToString()));
			}
			catch (Exception e)
			{
				cache = response["cache"];
			}

			bi.battleId = cache["replaced"]["battle"][0]["id"].ToString();
			bi.rewardExp = Int32.Parse(cache["replaced"]["battle"][0]["resultInfo"]["rewardExp"].ToString());
			bi.rewardQp = Int32.Parse(cache["replaced"]["battle"][0]["resultInfo"]["rewardQp"].ToString());
			var drop = new Dictionary<string, int>();
			var enemyDeck = (JArray)cache["replaced"]["battle"][0]["battleInfo"]["enemyDeck"];
			foreach (var jToken in enemyDeck)
			{
				var ed = (JObject)jToken;
				var svts = (JArray)ed["svts"];
				foreach (var jToken1 in svts)
				{
					var ed2 = (JObject)jToken1;
					var dropInfos = (JArray)ed2["dropInfos"];
					foreach (var jToken2 in dropInfos)
					{
						var dropJO = (JObject)jToken2;
						var id = dropJO["objectId"].ToString();
						if (drop.ContainsKey(id))
						{
							drop[id] = Int32.Parse(drop[id].ToString()) + Int32.Parse(dropJO["num"].ToString());
						}
						else
						{
							drop.Add(id, Int32.Parse(dropJO["num"].ToString()));
						}
					}
				}
			}

			bi.dropInfo = drop;
			return bi;
		}

		public async Task fgo_battlescenario(string questId, string questPhase)
		{
			var table = new Hashtable
			{
				{"ac", "action"},
				{"key", "battlescenario"},
				{"deviceid", Constant.DeviceId},
				{"os", Constant.OS},
				{"ptype", Constant.Ptype},
				{"usk", usk},
				{"umk", ""},
				{"rgsid", 1001},
				{"rkchannel", Constant.RKChannel},
				{"userId", sguid},
				{"appVer", Constant.GameVersion},
				{"dateVer", Constant.DateVer},
				{"lastAccessTime", FgoHelper.get_timestamp_fgo()},
				{"try", ""},
				{"developmentAuthCode", Constant.DevelopmentAuthCode},
				{"userAgent", 1},
				{"questId", questId},
				{"questPhase", questPhase},
				{"dataVer", Constant.DataVer}
			};

			var response = await FGoResponse(GetAddress("ac"), table);

			Helper.Extensions.ReplacedData(this, response["cache"]["replaced"].ToString());
			Helper.Extensions.UpdateData(this, response["cache"]["updated"].ToString());
		}

		public async Task fgo_battleresult(BattleInfo bi)
		{
			var table = new Hashtable
			{
				{"ac", "action"},
				{"key", "battleresult"},
				{"deviceid", Constant.DeviceId},
				{"os", Constant.OS},
				{"ptype", Constant.Ptype},
				{"usk", usk},
				{"umk", ""},
				{"rgsid", 1001},
				{"rkchannel", Constant.RKChannel},
				{"raidResult", "[]"},
				{"superBossResult", "[]"},
				{
					"result",
					"{\"battleId\":" + bi.battleId + ",\"battleResult\":1,\"scores\":\"\",\"action\":\"\",\"elapsedTurn\":" + new Random().Next(4, 12) +
					",\"aliveUniqueIds\":[],\"battleStatus\":" + calc_battleStatus(bi.battleId) + ",\"voicePlayedList\":\"[]\"}"
				},
				{"userId", sguid},
				{"appVer", Constant.GameVersion},
				{"dateVer", Constant.DateVer},
				{"lastAccessTime", FgoHelper.get_timestamp_fgo()},
				{"try", ""},
				{"developmentAuthCode", Constant.DevelopmentAuthCode},
				{"userAgent", 1},
				{"isBattleError", 0},
				{"dataVer", Constant.DataVer}
			};

			var response = await FGoResponse(GetAddress("ac"), table);

			Helper.Extensions.ReplacedData(this, response["cache"]["replaced"].ToString());
			Helper.Extensions.UpdateData(this, response["cache"]["updated"].ToString());
		}

		public string calc_battleStatus(string battleId)
		{
			var uid = UserGame.userId;
			return CryptData.Compute(BitConverter.GetBytes((long)(Int64.Parse(uid) + 1)).Concat<byte>(BitConverter.GetBytes((long)(0L - 0x408fd5L)))
				.Concat<byte>(BitConverter.GetBytes((long)(0L / 2L))).Concat<byte>(BitConverter.GetBytes((long)(Int64.Parse(battleId) - 0x7fffffffL)))
				.Concat<byte>(BitConverter.GetBytes((long)(0L - 0x25acf6L))).ToArray<byte>()).ToString();
		}

		public async Task fgo_recover(int item)
		{
			var table = new Hashtable
			{
				{"ac", "action"},
				{"key", item == 0 ? "shoppurchasebystone" : "itemrecover"},
				{"deviceid", Constant.DeviceId},
				{"os", Constant.OS},
				{"ptype", Constant.Ptype},
				{"usk", usk},
				{"umk", ""},
				{"rgsid", 1001},
				{"rkchannel", Constant.RKChannel},
				{"userId", sguid},
				{"appVer", Constant.GameVersion},
				{"dateVer", Constant.DateVer},
				{"lastAccessTime", FgoHelper.get_timestamp_fgo()},
				{"try", ""},
				{"developmentAuthCode", Constant.DevelopmentAuthCode},
				{"userAgent", 1}
			};
			if (item == 0)
			{
				table.Add("id", 2);
				table.Add("num", 1);
			}
			else
			{
				table.Add("recoverId", item + 1);
				table.Add("num", 1);
				table.Add("questId", 0);
			}

			table.Add("dataVer", Constant.DataVer);

			var response = await FGoResponse(GetAddress("ac"), table);

			Helper.Extensions.ReplacedData(this, response["cache"]["replaced"].ToString());
			Helper.Extensions.UpdateData(this, response["cache"]["updated"].ToString());
		}

		public async Task fgo_shopsellsvt(string str)
		{
			var table = new Hashtable
			{
				{"ac", "action"},
				{"key", "shopsellsvt"},
				{"deviceid", Constant.DeviceId},
				{"os", Constant.OS},
				{"ptype", Constant.Ptype},
				{"usk", usk},
				{"umk", ""},
				{"rgsid", 1001},
				{"rkchannel", Constant.RKChannel},
				{"userId", sguid},
				{"appVer", Constant.GameVersion},
				{"dateVer", Constant.DateVer},
				{"lastAccessTime", FgoHelper.get_timestamp_fgo()},
				{"try", ""},
				{"developmentAuthCode", Constant.DevelopmentAuthCode},
				{"userAgent", 1},
				{"dataVer", Constant.DataVer},
				{"sellData", $"[{str}]"}
			};

			var response = await FGoResponse(GetAddress("ac"), table);

			Helper.Extensions.ReplacedData(this, response["cache"]["replaced"].ToString());
			Helper.Extensions.UpdateData(this, response["cache"]["updated"].ToString());
		}

		private async Task<JObject> FGoResponse(string url, Hashtable table)
		{
			var response = JObject.Parse(FgoHelper.convert_response(await Network.HttpPostAsync(url, table)));
			var resCode = FgoHelper.parse_rescode(response);

			if (resCode != "00")
			{
				throw new Exception(response["response"][0]["fail"]["detail"].ToString());
			}

			if (response["response"][0]["usk"] != null)
			{
				usk = await EncryptMD5Usk(response["response"][0]["usk"].ToString());
			}

			return response;
		}

		#endregion

		public async Task RecoverAP(int apFunc)
		{
			//var index = SelectAPFunc == "石头" ? 0 : SelectAPFunc == "金苹果" ? 1 : SelectAPFunc == "银苹果" ? 2 : 3;
			await fgo_recover(apFunc);

			MessagingCenter.Send(new LogMessage(this, "体力已回复"), "Log");
			await fgo_home();
		}

		public async Task Sell()
		{
			var sd = Svt.Where(i => i.Rarity < 3 && !i.isLock && i.lv == 1).Take(50);

			var str = string.Join(",", sd.Select(i => "{\"id\":" + i.id + ",\"num\":1}"));
			await fgo_shopsellsvt(str);

			MessagingCenter.Send(new LogMessage($"{sd.Count()}狗粮已出售"), "Log");
			await fgo_home();
		}

		public async Task fgo_server()
		{
			var jo = JObject.Parse(await Network.GetWebAsync(
				$"https://line3-s1-{(IsiOS ? "ios" : "bili")}-fate.bilibiligame.net/rongame_beta/rgfate/60_member/network/network_config_{(IsiOS ? "ios" : "android")}_{Constant.GameVersion}.json"));
			var ja = (JArray)jo["list"][0]["ser"];
			MainAddress = ja[0].ToString();
		}

		public void GetSign(Hashtable table)
		{
			if (table.ContainsKey("sign"))
			{
				var keys = new ArrayList(table.Keys);
				keys.Sort();
				var str = "";
				foreach (var key in keys)
				{
					str += table[key];
				}

				table["sign"] = CryptData.CalcSign(str);
			}
		}

		private static string ConvertToParameters(Hashtable rsa)
		{
			var par = new List<string>();
			foreach (DictionaryEntry item in rsa)
			{
				par.Add($"{item.Key}={item.Value}");
			}

			return string.Join("&", par);
		}

		public string GetAddress(string file)
		{
			return $"{MainAddress}/rongame_beta/rgfate/60_1001/{file}.php";
		}

		public async Task<string> EncryptMD5Usk(string usk)
		{
            var str = await Network.GetWebAsync("https://xnxezy9qaazkicgjwwex2qonmgdptl1r.fate-flag.cn/shsfoiafanvlauibxzuvbmaiuanocmz.php", "Post", $"ios={(IsiOS ? 1 : 0)}&usk={usk}");
			return CryptData.Decode(str);
		}
	}
}
