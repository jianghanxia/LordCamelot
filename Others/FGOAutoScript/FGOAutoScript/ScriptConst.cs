using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FGOAutoScript
{
    class ScriptConst
    {
        public static string settingTime = "60";
	    public static string battleTimes { get; set; } = "1";


		public static Dictionary<string, string> mstItem = new Dictionary<string, string>();
        public static Dictionary<string, string> mstSvt = new Dictionary<string, string>();
    }
}
