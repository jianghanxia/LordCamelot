using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LordCamelot.Helper;
using LordCamelot.Models;
using Newtonsoft.Json.Linq;

namespace LordCamelot.Services
{
	public class Remote
	{
		public static async Task fgo_member()
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
				{"username", "lv9999"},
				{"type", "login"},
				{"password", "111111"},
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

			var response = JObject.Parse(FgoHelper.convert_response(await Network.HttpPostAsync("https://line3-s2-bili-fate.bilibiligame.net/rongame_beta/rgfate/60_member/member.php", table)));
			var resCode = FgoHelper.parse_rescode(response);

			if (resCode != "00")
			{
				throw new Exception(response["response"][0]["fail"]["detail"].ToString());
			}

			Constant.DataVer = response["response"][0]["success"]["version"].ToString();
		}
	}
}
