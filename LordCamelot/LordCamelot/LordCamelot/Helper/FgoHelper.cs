using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using LordCamelot.Services;
using LordCamelot.ViewModels;
using Newtonsoft.Json.Linq;

namespace LordCamelot.Helper
{
	public class FgoHelper
	{
		public static string get_timestamp_fgo()
		{
			var cha = (DateTime.Now - TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1)));
			return (long) cha.TotalSeconds + "";
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

		public static int GetBaseAct(long actRecoverAt, int actMax)
		{
			var span = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
			var num = actRecoverAt - (long.Parse(Convert.ToInt64(span.TotalMilliseconds).ToString()) / 1000);
			if (num <= 0L)
			{
				return actMax;
			}

			var num2 = ((num + 300L) - 1L) / 300L;
			if (actMax > num2)
			{
				return (actMax - ((int) num2));
			}

			return 0;
		}
	}
}
