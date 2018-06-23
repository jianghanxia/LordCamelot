using FGOAutoScript;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace FGOAutoScript
{
	class FgoMain
	{
		public static Dictionary<string, string> usk = new Dictionary<string, string>();

		public static string get_merchant_id()
		{
			return FgoConstant.bili_sdk_const[0];
		}

		public static string get_app_id()
		{
			return FgoConstant.bili_sdk_const[1];
		}

		public static string get_server_id()
		{
			return FgoConstant.bili_sdk_const[2];
		}
		public static string get_app_key()
		{
			return FgoConstant.bili_sdk_const[3];
		}
		public static string get_game_version()
		{
			return FgoConstant.fgo_const[0];
		}

		public static string get_device_id()
		{
			return FgoConstant.fgo_const[1];
		}
		public static string get_os()
		{
			return FgoConstant.fgo_const[2];
		}
		public static string get_ptype()
		{
			return FgoConstant.fgo_const[3];
		}
		public static string get_developmentAuthCode()
		{
			return FgoConstant.fgo_const[4];
		}
		public static string get_pre_address(string file)
		{
			return FgoConstant.fgo_const[5] + file + ".php";
		}
		public static string get_main_address(string file)
		{
			return FgoConstant.fgo_const[6] + file + ".php";
		}
		public static string get_data_ver()
		{
			return FgoConstant.fgo_const[7];
		}
		public static string get_rkchannel()
		{
			return FgoConstant.fgo_const[8];
		}
		public static string get_date_ver()
		{
			return FgoConstant.fgo_const[9];
		}
		public static string get_timestamp()
		{
			var cha = (DateTime.Now - TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1)));
			return (long)cha.TotalMilliseconds + "";
		}

		public static string get_timestamp_fgo()
		{
			var cha = (DateTime.Now - TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1)));
			return (long)cha.Milliseconds + "";
		}

		public static string get_act_timestamp()
		{
			var span = DateTime.UtcNow - new DateTime(0x7b2, 1, 1, 0, 0, 0, 0);
			return Convert.ToInt64(span.TotalMilliseconds).ToString();
		}

		public static string convert_response(string b64)
		{
			b64 = HttpUtility.UrlDecode(b64);
			var b642 = Convert.FromBase64String(b64);
			return Encoding.UTF8.GetString(b642);
		}
		public static string parse_rescode(JObject jo)
		{
			return jo["response"][0]["resCode"].ToString();
		}
		public static Dictionary<string, string>[] parse_response(JObject jo)
		{
			var response = new Dictionary<string, string>();
			foreach (var key in jo)
			{
				if (key.Key.Equals("success") || key.Key.Equals("fail"))
					continue;
				response.Add(key.Key.ToString(), key.Value.ToString());
			}
			var success = new Dictionary<string, string>();
			foreach (var key in (JObject)jo["success"])
			{
				if (key.Key.Equals("announcement"))
					continue;
				success.Add(key.Key.ToString(), key.Value.ToString());
			}
			var fail = new Dictionary<string, string>();
			foreach (var key in (JObject)jo["fail"])
			{
				fail.Add(key.Key.ToString(), key.Value.ToString());
			}
			return new Dictionary<string, string>[3] { response, success, fail };
		}
		public static string calc_sign(string p0)
		{
			var md5 = MD5.Create();
			var data = md5.ComputeHash(Encoding.Default.GetBytes(p0 + get_app_key()));
			var sb = new StringBuilder();
			for (var i = 0; i < data.Length; i++)
			{
				sb.Append(data[i].ToString("x2"));
			}
			return sb.ToString();
		}
		public static void calc_usk(string uid, string usk_)
		{
			if (!usk.ContainsKey(uid))
			{
				usk.Add(uid, CryptData.EncryptMD5Usk(usk_));
			}
			else
			{
				usk[uid] = CryptData.EncryptMD5Usk(usk_);
			}
		}
		public static string get_usk(string uid)
		{
			return usk[uid].ToString();
		}
		public static string calc_battleStatus(string uid, string battleId)
		{
			return Crc32.Compute(BitConverter.GetBytes((long)(long.Parse(uid) + 1)).Concat<byte>(BitConverter.GetBytes((long)(0L - 0x408fd5L))).Concat<byte>(BitConverter.GetBytes((long)(0L / 2L))).Concat<byte>(BitConverter.GetBytes((long)(long.Parse(battleId) - 0x7fffffffL))).Concat<byte>(BitConverter.GetBytes((long)(0L - 0x25acf6L))).ToArray<byte>()).ToString();
		}
		public static int GetBaseAct(long actRecoverAt, int actMax)
		{
			var num = actRecoverAt - (long.Parse(get_act_timestamp()) / 0x3e8L);
			if (num <= 0L)
			{
				return actMax;
			}
			var num2 = ((num + 300L) - 1L) / 300L;
			if (actMax > num2)
			{
				return (actMax - ((int)num2));
			}
			return 0;
		}



	}
}
