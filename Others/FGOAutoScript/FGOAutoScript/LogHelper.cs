using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FGOAutoScript
{
    class LogHelper
    {
        public static string getPrefix()
        {
            return $"[{DateTime.Now:hh:mm:ss}] ";
        }

        public static string createFailMessageBox(string[] res)
        {
            MessageBox.Show(res[2], res[1]);
            return $"{getPrefix()}{res[2] + "\r\n"}";
        }

        public static string createFailMessageBox(PlayerStatus ps)
        {
           var  extra = JObject.Parse(ps.uid);
            MessageBox.Show(extra["detail"].ToString(), extra["title"].ToString());
            return $"{getPrefix()}{extra["detail"] + "\r\n"}";
        }
    }
}
