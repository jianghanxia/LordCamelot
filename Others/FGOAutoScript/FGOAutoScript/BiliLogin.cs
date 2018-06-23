using Newtonsoft.Json.Linq;
using System.Collections;

namespace FGOAutoScript
{
	public class BiliLogin
	{
		public static string[] bili_rsa()
		{
			var rsa = new Hashtable
			{
				{"app_id", FgoMain.get_app_id()},
				{"c", 0},
				{"channel_id", 1},
				{"domain", "p.biligame.com"},
				{"domain_switch_count", 0},
				{"dp", "1920*1080"},
				{"game_id", FgoMain.get_app_id()},
				{"isRoot", 0},
				{"merchant_id", FgoMain.get_merchant_id()},
				{"model", "SwitchFgo"},
				{"net", 4},
				{"operators", 5},
				{"pf_ver", "4.4.4"},
				{"platform_type", 3},
				{"sdk_log_type", 1},
				{"sdk_type", 1},
				{"sdk_ver", "1.6.7.1"},
				{"server_id", FgoMain.get_server_id()},
				{"support_abis", "x86,armeabi-v7a"},
				{"timestamp", FgoMain.get_timestamp()},
				{"udid", "Pwc3BzUCYFhhB2ZeIl4i"},
				{"ver", FgoMain.get_game_version()},
				{"version", 1}
			};

			var al = new ArrayList(rsa.Keys);
			al.Sort();
			var p0 = "";
			foreach (string key in al)
			{
				p0 += rsa[key].ToString();
			}
			rsa.Add("uid", "");
			rsa.Add("original_domain", "");
			rsa.Add("sign", FgoMain.calc_sign(p0));

			var jo = JObject.Parse(NetworkAPI.CreateGetHttpResponse("http://p.biligame.com/api/client/rsa", 10000, rsa));

			return new string[2] { jo["hash"].ToString(), jo["rsa_key"].ToString() };
		}

		public static string[] bili_login(string username, string password, string hash, string rsa_key)
		{
			var login = new Hashtable
			{
				{"app_id", FgoMain.get_app_id()},
				{"c", 0},
				{"channel_id", 1},
				{"domain", "p.biligame.com"},
				{"domain_switch_count", 0},
				{"dp", "1920*1080"},
				{"game_id", FgoMain.get_app_id()},
				{"isRoot", 0},
				{"merchant_id", FgoMain.get_merchant_id()},
				{"model", "SwitchFgo"},
				{"net", 4},
				{"operators", 5},
				{"pf_ver", "4.4.4"},
				{"platform_type", 3},
				{"sdk_log_type", 1},
				{"sdk_type", 1},
				{"sdk_ver", "1.6.7.1"},
				{"server_id", FgoMain.get_server_id()},
				{"support_abis", "x86,armeabi-v7a"},
				{"timestamp", FgoMain.get_timestamp()},
				{"uid", 0},
				{"udid", "Pwc3BzUCYFhhB2ZeIl4i"},
				{"ver", FgoMain.get_game_version()},
				{"version", 1},
				{"user_id", username},
				{"pwd", RsaHelper.RSAEncrypt(rsa_key, hash + password)}
			};


			var al = new ArrayList(login.Keys);
			al.Sort();
			var p0 = "";
			foreach (string key in al)
			{
				p0 += login[key].ToString();
			}
			login.Add("original_domain", "");
			login.Add("sign", FgoMain.calc_sign(p0));

			var jo = JObject.Parse(NetworkAPI.CreatePostHttpResponse("http://p.biligame.com/api/client/login", login));
			if (!jo["code"].ToString().Equals("0"))
			{
				return new string[1] { "pwd_error" };
			}
			return new string[2] { jo["uid"].ToString(), jo["access_key"].ToString() };
		}

		public static string[] bili_userinfo(string access_key)
		{
			var user = new Hashtable
			{
				{"app_id", FgoMain.get_app_id()},
				{"c", 0},
				{"channel_id", 1},
				{"domain", "line3-sdkcenter-login.bilibiligame.net"},
				{"domain_switch_count", 0},
				{"dp", "1920*1080"},
				{"game_id", FgoMain.get_app_id()},
				{"isRoot", 0},
				{"merchant_id", FgoMain.get_merchant_id()},
				{"model", "SwitchFgo"},
				{"net", 4},
				{"operators", 5},
				{"pf_ver", "4.4.4"},
				{"platform_type", 3},
				{"sdk_log_type", 1},
				{"sdk_type", 1},
				{"sdk_ver", "1.6.7.1"},
				{"server_id", FgoMain.get_server_id()},
				{"support_abis", "x86,armeabi-v7a"},
				{"timestamp", FgoMain.get_timestamp()},
				{"udid", "Pwc3BzUCYFhhB2ZeIl4i"},
				{"ver", FgoMain.get_game_version()},
				{"version", 1},
				{"access_key", access_key}
			};


			var al = new ArrayList(user.Keys);
			al.Sort();
			var p0 = "";
			foreach (string key in al)
			{
				p0 += user[key].ToString();
			}

			user.Add("sign", FgoMain.calc_sign(p0));
			var jo = JObject.Parse(NetworkAPI.CreateGetHttpResponse("http://line3-sdkcenter-login.bilibiligame.net/api/client/user.info", 10000, user));
			return new string[2] { jo["uname"].ToString(), jo["face"].ToString() };
		}
	}
}
