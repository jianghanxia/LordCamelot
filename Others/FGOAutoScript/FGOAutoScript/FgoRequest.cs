using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;

namespace FGOAutoScript
{
	public class FgoRequest
	{
		public static string[] fgo_server()
		{
			var jo = JObject.Parse(NetworkAPI.CreateGetHttpResponse("https://line1-s1-bili-fate.bilibiligame.net/rongame_beta/rgfate/60_member/network/network_config_android_" + FgoMain.get_game_version() + ".json", 500, null));
			var ja = (JArray)jo["list"][0]["ser"];
			var a = new string[ja.Count];
			FgoConstant.fgo_const[5] = ja[0] + FgoConstant.fgo_const[5];
			FgoConstant.fgo_const[6] = ja[0] + FgoConstant.fgo_const[6];
			return new string[1] { "00" };
		}

		public static string[] fgo_member()
		{
			var table = new Hashtable
			{
				{"deviceid", FgoMain.get_device_id()},
				{"t", 22360},
				{"v", "1.0.1"},
				{"s", 1},
				{"mac", "00000000000000E0"},
				{"os", FgoMain.get_os()},
				{"ptype", FgoMain.get_ptype()},
				{"imei", "aaaaa"},
				{"username", "lv9999"},
				{"type", "login"},
				{"password", "111111"},
				{"rksdkid", 1},
				{"rkchannel", FgoMain.get_rkchannel()},
				{"appVer", FgoMain.get_game_version()},
				{"dateVer", FgoMain.get_data_ver()},
				{"lastAccessTime", FgoMain.get_timestamp_fgo()},
				{"try", ""},
				{"developmentAuthCode", FgoMain.get_developmentAuthCode()},
				{"version", FgoMain.get_data_ver()},
				{"dataVer", FgoMain.get_data_ver()}
			};
			var response = JObject.Parse(FgoMain.convert_response(NetworkAPI.CreatePostHttpResponse(FgoMain.get_pre_address("member"), table)));
			var resCode = FgoMain.parse_rescode(response);
			if (resCode != "00")
			{
				return new string[3] { resCode, response["response"][0]["fail"]["title"].ToString(), response["response"][0]["fail"]["detail"].ToString() };
			}
			FgoConstant.fgo_const[7] = response["response"][0]["success"]["version"].ToString();
			return new string[1] { "00" };
		}

		public static string[] fgo_logintomembercenter(string username, string rkuid, string access_token)
		{
			var table = new Hashtable
			{
				{"deviceid", FgoMain.get_device_id()},
				{"t", 22360},
				{"v", "1.0.1"},
				{"s", 1},
				{"mac", "00000000000000E0"},
				{"os", FgoMain.get_os()},
				{"ptype", FgoMain.get_ptype()},
				{"imei", "aaaaa"},
				{"username", username},
				{"type", "token"},
				{"bundleid", "com.bilibili.fatego"},
				{"rkuid", rkuid},
				{"access_token", access_token},
				{"rksdkid", 1},
				{"rkchannel", FgoMain.get_rkchannel()},
				{"appVer", FgoMain.get_game_version()},
				{"dateVer", FgoMain.get_data_ver()},
				{"lastAccessTime", FgoMain.get_timestamp_fgo()},
				{"try", ""},
				{"developmentAuthCode", FgoMain.get_developmentAuthCode()},
				{"version", FgoMain.get_data_ver()},
				{"dataVer", FgoMain.get_data_ver()}
			};
			var response = JObject.Parse(FgoMain.convert_response(NetworkAPI.CreatePostHttpResponse(FgoMain.get_pre_address("logintomembercenter"), table)));
			var resCode = FgoMain.parse_rescode(response);
			if (resCode != "00")
			{
				return new string[3] { resCode, response["response"][0]["fail"]["title"].ToString(), response["response"][0]["fail"]["detail"].ToString() };
			}
			FgoConstant.fgo_const[9] = response["response"][0]["success"]["dateVer"].ToString();
			return new string[3] { "00", response["response"][0]["success"]["rguid"].ToString(), response["response"][0]["success"]["rgusk"].ToString() };
		}
		public static string[] fgo_login(string rguid, string rgusk)
		{
			var table = new Hashtable
			{
				{"deviceid", FgoMain.get_device_id()},
				{"os", FgoMain.get_os()},
				{"ptype", FgoMain.get_ptype()},
				{"rgsid", 1001},
				{"rguid", rguid},
				{"rgusk", rgusk},
				{"idfa", ""},
				{"v", "1.0.1"},
				{"mac", 0},
				{"imei", ""},
				{"type", "login"},
				{"nickname", "XXXXXX"},
				{"rkchannel", FgoMain.get_rkchannel()},
				{"assetbundleFolder", ""},
				{"appVer", FgoMain.get_game_version()},
				{"dateVer", FgoMain.get_date_ver()},
				{"lastAccessTime", FgoMain.get_timestamp_fgo()},
				{"try", ""},
				{"developmentAuthCode", FgoMain.get_developmentAuthCode()},
				{"userAgent", 1},
				{"t", 20399},
				{"s", 1},
				{"rksdkid", 1},
				{"dataVer", FgoMain.get_data_ver()}
			};

			var response = JObject.Parse(FgoMain.convert_response(NetworkAPI.CreatePostHttpResponse(FgoMain.get_main_address("login"), table)));
			var resCode = FgoMain.parse_rescode(response);
			var sguid = response["response"][0]["success"]["sguid"].ToString();
			var usk = "";
			if (response["response"][0]["usk"] != null)
			{
				usk = response["response"][0]["usk"].ToString();
				FgoMain.calc_usk(sguid, usk);
			}
			if (resCode != "00")
			{
				return new string[3] { resCode, response["response"][0]["fail"]["title"].ToString(), response["response"][0]["fail"]["detail"].ToString() };
			}
			return new string[3] { "00", response["response"][0]["success"]["sguid"].ToString(), response["response"][0]["success"]["nickname"].ToString() };
		}

		public static PlayerStatus fgo_toplogin(string uid, string nickname)
		{
			var table = new Hashtable
			{
				{"ac", "action"},
				{"key", "toplogin"},
				{"deviceid", FgoMain.get_device_id()},
				{"os", FgoMain.get_os()},
				{"ptype", FgoMain.get_ptype()},
				{"usk", FgoMain.get_usk(uid)},
				{"umk", ""},
				{"rgsid", 1001},
				{"rkchannel", FgoMain.get_rkchannel()},
				{"nickname", nickname},
				{"sgtype", 2},
				{"sgtag", 20161108},
				{"userId", uid},
				{"appVer", FgoMain.get_game_version()},
				{"dateVer", FgoMain.get_date_ver()},
				{"lastAccessTime", FgoMain.get_timestamp_fgo()},
				{"try", ""},
				{"developmentAuthCode", FgoMain.get_developmentAuthCode()},
				{"userAgent", 1},
				{"dataVer", FgoMain.get_data_ver()}
			};

			var response = JObject.Parse(FgoMain.convert_response(NetworkAPI.CreatePostHttpResponse(FgoMain.get_main_address("ac"), table)));
			var resCode = FgoMain.parse_rescode(response);
			var usk = "";
			if (response["response"][0]["usk"] != null)
			{
				usk = response["response"][0]["usk"].ToString();
				FgoMain.calc_usk(uid, usk);
			}
			var ps = new PlayerStatus();
			if (resCode != "00")
			{
				ps.uid = response["response"][0]["fail"].ToString();
				return ps;
			}
			ps.uid = response["cache"]["replaced"]["userGame"][0]["userId"].ToString();
			ps.name = response["cache"]["replaced"]["userGame"][0]["name"].ToString();
			var deck = new Dictionary<string, string>();
			foreach (JObject jt in (JArray)response["cache"]["replaced"]["userDeck"])
			{
				deck.Add(jt["id"].ToString(), jt["name"].ToString());
			}
			ps.deckList = deck;
			return ps;
		}
		public static PlayerStatus fgo_home(PlayerStatus ps)
		{
			var table = new Hashtable
			{
				{"ac", "home"},
				{"deviceid", FgoMain.get_device_id()},
				{"os", FgoMain.get_os()},
				{"ptype", FgoMain.get_ptype()},
				{"usk", FgoMain.get_usk(ps.uid)},
				{"umk", ""},
				{"rgsid", 1001},
				{"rkchannel", FgoMain.get_rkchannel()},
				{"userId", ps.uid},
				{"appVer", FgoMain.get_game_version()},
				{"dateVer", FgoMain.get_date_ver()},
				{"lastAccessTime", FgoMain.get_timestamp_fgo()},
				{"try", ""},
				{"developmentAuthCode", FgoMain.get_developmentAuthCode()},
				{"dataVer", FgoMain.get_data_ver()}
			};

			var response = JObject.Parse(FgoMain.convert_response(NetworkAPI.CreatePostHttpResponse(FgoMain.get_main_address("ac"), table)));
			var resCode = FgoMain.parse_rescode(response);
			var usk = "";
			if (response["response"][0]["usk"] != null)
			{
				usk = response["response"][0]["usk"].ToString();
				FgoMain.calc_usk(ps.uid, usk);
			}
			if (resCode != "00")
			{
				ps.uid = response["response"][0]["fail"].ToString();
				return ps;
			}
			ps.uid = response["cache"]["replaced"]["userGame"][0]["userId"].ToString();
			ps.actRecoverAt = int.Parse(response["cache"]["replaced"]["userGame"][0]["actRecoverAt"].ToString());
			ps.actMax = int.Parse(response["cache"]["replaced"]["userGame"][0]["actMax"].ToString());
			ps.lv = int.Parse(response["cache"]["replaced"]["userGame"][0]["lv"].ToString());
			ps.exp = int.Parse(response["cache"]["replaced"]["userGame"][0]["exp"].ToString());
			ps.qp = int.Parse(response["cache"]["replaced"]["userGame"][0]["qp"].ToString());
			ps.costMax = int.Parse(response["cache"]["replaced"]["userGame"][0]["costMax"].ToString());
			ps.freeStone = int.Parse(response["cache"]["replaced"]["userGame"][0]["freeStone"].ToString());
			ps.chargeStone = int.Parse(response["cache"]["replaced"]["userGame"][0]["chargeStone"].ToString());
			var item = new Dictionary<string, int>();
			foreach (JObject jt in (JArray)response["cache"]["replaced"]["userItem"])
			{
				if (jt["num"].ToString() == "0")
					continue;
				item.Add(jt["itemId"].ToString(), int.Parse(jt["num"].ToString()));
			}
			ps.itemList = item;
			var info = new Dictionary<string, string>();
			var follower = new Dictionary<string, FollowerServant[]>();
			foreach (JObject jt in (JArray)response["cache"]["updated"]["userFollower"][0]["followerInfo"])
			{
				var ja = (JArray)jt["userSvtLeaderHash"];
				var fs = new FollowerServant[ja.Count];
				for (var i = 0; i < fs.Length; i++)
				{
					fs[i].equipId = ja[i]["equipTarget1"]["svtId"].ToString();
					fs[i].equipMax = int.Parse(ja[i]["equipTarget1"]["limitCount"].ToString()) == 4 ? true : false;
				}
				follower.Add(jt["userId"].ToString(), fs);
				info.Add(jt["userName"].ToString(), jt["userId"].ToString());
			}
			ps.followerList = follower;
			ps.followerInfo = info;
			var player = new Dictionary<string, PlayerServant>();
			foreach (JObject jt in (JArray)response["cache"]["replaced"]["userSvt"])
			{
				var ps2 = new PlayerServant();
				ps2.isLock = jt["isLock"].ToString() == "1" ? true : false;
				ps2.svtId = jt["svtId"].ToString();
				player.Add(jt["id"].ToString(), ps2);
			}
			ps.servantList = player;
			return ps;
		}
		public static PlayerStatus fgo_followerlist(PlayerStatus ps)
		{
			var table = new Hashtable
			{
				{"ac", "action"},
				{"key", "followerlist"},
				{"deviceid", FgoMain.get_device_id()},
				{"os", FgoMain.get_os()},
				{"ptype", FgoMain.get_ptype()},
				{"usk", FgoMain.get_usk(ps.uid)},
				{"umk", ""},
				{"rgsid", 1001},
				{"rkchannel", FgoMain.get_rkchannel()},
				{"userId", ps.uid},
				{"appVer", FgoMain.get_game_version()},
				{"dateVer", FgoMain.get_date_ver()},
				{"lastAccessTime", FgoMain.get_timestamp_fgo()},
				{"try", ""},
				{"developmentAuthCode", FgoMain.get_developmentAuthCode()},
				{"refresh", 1},
				{"userAgent", 1},
				{"dataVer", FgoMain.get_data_ver()}
			};

			var response = JObject.Parse(FgoMain.convert_response(NetworkAPI.CreatePostHttpResponse(FgoMain.get_main_address("ac"), table)));
			var resCode = FgoMain.parse_rescode(response);
			var usk = response["response"][0]["usk"].ToString();
			FgoMain.calc_usk(ps.uid, usk);
			if (resCode != "00")
			{
				ps.uid = response["response"][0]["fail"].ToString();
				return ps;
			}
			var follower = new Dictionary<string, FollowerServant[]>();
			foreach (var jToken in (JArray)response["cache"]["updated"]["userFollower"][0]["followerInfo"])
			{
				var jt = (JObject) jToken;
				var ja = (JArray)jt["userSvtLeaderHash"];
				var fs = new FollowerServant[ja.Count];
				for (var i = 0; i < fs.Length; i++)
				{
					fs[i].equipId = ja[i]["equipTarget1"]["svtId"].ToString();
					fs[i].equipMax = int.Parse(ja[i]["equipTarget1"]["limitCount"].ToString()) == 4 ? true : false;
				}
				follower.Add(jt["userId"].ToString(), fs);
			}
			ps.followerList = follower;
			return ps;
		}

		public static BattleInfo fgo_battlesetup(string uid, string questId, string questPhase, string deckId, string followerId, int followerClass)
		{
			var table = new Hashtable
			{
				{"activeDeckId", deckId},
				{"followerId", followerId},
				{"ac", "action"},
				{"key", "battlesetup"},
				{"deviceid", FgoMain.get_device_id()},
				{"os", FgoMain.get_os()},
				{"ptype", FgoMain.get_ptype()},
				{"usk", FgoMain.get_usk(uid)},
				{"umk", ""},
				{"rgsid", 1001},
				{"rkchannel", FgoMain.get_rkchannel()},
				{"userId", uid},
				{"appVer", FgoMain.get_game_version()},
				{"dateVer", FgoMain.get_date_ver()},
				{"lastAccessTime", FgoMain.get_timestamp_fgo()},
				{"try", ""},
				{"developmentAuthCode", FgoMain.get_developmentAuthCode()},
				{"questId", questId},
				{"questPhase", questPhase},
				{"followerClassId", followerClass},
				{"battleMode", 1},
				{"itemId", 0},
				{"enemySelect", 1},
				{"userAgent", 1},
				{"dataVer", FgoMain.get_data_ver()}
			};
			var response = JObject.Parse(FgoMain.convert_response(NetworkAPI.CreatePostHttpResponse(FgoMain.get_main_address("ac"), table)));
			var resCode = FgoMain.parse_rescode(response);
			var usk = "";
			if (response["response"][0]["usk"] != null)
			{
				usk = response["response"][0]["usk"].ToString();
				FgoMain.calc_usk(uid, usk);
			}
			var bi = new BattleInfo();
			if (resCode != "00")
			{
				bi.battleResCode = resCode;
				bi.battleExtra = response["response"][0]["fail"].ToString();
				return bi;
			}
			bi.battleResCode = "00";
			bi.battleExtra = "{}";
			var cache = JObject.Parse(CryptData.ResponseCacheDecrypt(response["cache"].ToString()));
			bi.battleId = cache["replaced"]["battle"][0]["id"].ToString();
			bi.rewardExp = int.Parse(cache["replaced"]["battle"][0]["resultInfo"]["rewardExp"].ToString());
			bi.rewardQp = int.Parse(cache["replaced"]["battle"][0]["resultInfo"]["rewardQp"].ToString());
			var drop = new Dictionary<string, int>();
			var enemyDeck = (JArray)cache["replaced"]["battle"][0]["battleInfo"]["enemyDeck"];
			foreach (var jToken in enemyDeck)
			{
				var ed = (JObject) jToken;
				var svts = (JArray)ed["svts"];
				foreach (var jToken1 in svts)
				{
					var ed2 = (JObject) jToken1;
					var dropInfos = (JArray)ed2["dropInfos"];
					foreach (var jToken2 in dropInfos)
					{
						var dropJO = (JObject) jToken2;
						var id = dropJO["objectId"].ToString();
						if (drop.ContainsKey(id))
						{
							drop[id] = int.Parse(drop[id].ToString()) + int.Parse(dropJO["num"].ToString());
						}
						else
						{
							drop.Add(id, int.Parse(dropJO["num"].ToString()));
						}
					}
				}
			}
			bi.dropInfo = drop;
			return bi;
		}

		public static string[] fgo_battleresult(string uid, BattleInfo bi)
		{
			var table = new Hashtable
			{
				{"ac", "action"},
				{"key", "battleresult"},
				{"deviceid", FgoMain.get_device_id()},
				{"os", FgoMain.get_os()},
				{"ptype", FgoMain.get_ptype()},
				{"usk", FgoMain.get_usk(uid)},
				{"umk", ""},
				{"rgsid", 1001},
				{"rkchannel", FgoMain.get_rkchannel()},
				{"raidResult", "[]"},
				{"superBossResult", "[]"},
				{
					"result",
					"{\"battleId\":" + bi.battleId + ",\"battleResult\":1,\"scores\":\"\",\"action\":\"\",\"elapsedTurn\":" +
					new Random().Next(5, 10) + ",\"aliveUniqueIds\":[],\"battleStatus\":" +
					FgoMain.calc_battleStatus(uid, bi.battleId) + ",\"voicePlayedList\":\"[]\"}"
				},
				{"userId", uid},
				{"appVer", FgoMain.get_game_version()},
				{"dateVer", FgoMain.get_date_ver()},
				{"lastAccessTime", FgoMain.get_timestamp_fgo()},
				{"try", ""},
				{"developmentAuthCode", FgoMain.get_developmentAuthCode()},
				{"userAgent", 1},
				{"isBattleError", 0},
				{"dataVer", FgoMain.get_data_ver()}
			};
			var response = JObject.Parse(FgoMain.convert_response(NetworkAPI.CreatePostHttpResponse(FgoMain.get_main_address("ac"), table)));
			var resCode = FgoMain.parse_rescode(response);
			var usk = "";
			if (response["response"][0]["usk"] != null)
			{
				usk = response["response"][0]["usk"].ToString();
				FgoMain.calc_usk(uid, usk);
			}
			if (resCode != "00")
			{
				return new string[3] { resCode, response["response"][0]["fail"]["title"].ToString(), response["response"][0]["fail"]["detail"].ToString() };
			}
			return new string[1] { "00" };
		}

		public static string[] fgo_recover(string uid, int item)
		{
			var table = new Hashtable
			{
				{"ac", "action"},
				{"key", item == 0 ? "shoppurchasebystone" : "itemrecover"},
				{"deviceid", FgoMain.get_device_id()},
				{"os", FgoMain.get_os()},
				{"ptype", FgoMain.get_ptype()},
				{"usk", FgoMain.get_usk(uid)},
				{"umk", ""},
				{"rgsid", 1001},
				{"rkchannel", FgoMain.get_rkchannel()},
				{"userId", uid},
				{"appVer", FgoMain.get_game_version()},
				{"dateVer", FgoMain.get_date_ver()},
				{"lastAccessTime", FgoMain.get_timestamp_fgo()},
				{"try", ""},
				{"developmentAuthCode", FgoMain.get_developmentAuthCode()},
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
			table.Add("dataVer", FgoMain.get_data_ver());
			var response = JObject.Parse(FgoMain.convert_response(NetworkAPI.CreatePostHttpResponse(FgoMain.get_main_address("ac"), table)));
			var resCode = FgoMain.parse_rescode(response);
			var usk = "";
			if (response["response"][0]["usk"] != null)
			{
				usk = response["response"][0]["usk"].ToString();
				FgoMain.calc_usk(uid, usk);
			}
			if (resCode != "00")
			{
				return new string[3] { resCode, response["response"][0]["fail"]["title"].ToString(), response["response"][0]["fail"]["detail"].ToString() };
			}
			return new string[1] { "00" };
		}
		public static string[] fgo_shopsellsvt(string uid, string str)
		{
			var table = new Hashtable
			{
				{"ac", "action"},
				{"key", "shopsellsvt"},
				{"deviceid", FgoMain.get_device_id()},
				{"os", FgoMain.get_os()},
				{"ptype", FgoMain.get_ptype()},
				{"usk", FgoMain.get_usk(uid)},
				{"umk", ""},
				{"rgsid", 1001},
				{"rkchannel", FgoMain.get_rkchannel()},
				{"userId", uid},
				{"appVer", FgoMain.get_game_version()},
				{"dateVer", FgoMain.get_date_ver()},
				{"lastAccessTime", FgoMain.get_timestamp_fgo()},
				{"try", ""},
				{"developmentAuthCode", FgoMain.get_developmentAuthCode()},
				{"userAgent", 1},
				{"dataVer", FgoMain.get_data_ver()},
				{"sellData", $"[{str}]"}
			};
			var response = JObject.Parse(FgoMain.convert_response(NetworkAPI.CreatePostHttpResponse(FgoMain.get_main_address("ac"), table)));
			var resCode = FgoMain.parse_rescode(response);
			var usk = "";
			if (response["response"][0]["usk"] != null)
			{
				usk = response["response"][0]["usk"].ToString();
				FgoMain.calc_usk(uid, usk);
			}
			if (resCode != "00")
			{
				return new string[3] { resCode, response["response"][0]["fail"]["title"].ToString(), response["response"][0]["fail"]["detail"].ToString() };
			}
			return new string[2] { "00", response["response"][0]["success"]["sellQpPrice"].ToString() };
		}
	}
}
