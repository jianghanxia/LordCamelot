using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FGOAutoScript
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            FgoConstant.bili_sdk_const = new string[4] { "1", "112", "248", "a4e39619a09d49e9aead9b820980013a" };
            FgoConstant.fgo_const = new string[10]
            {
                "1.17.1",
                "4549de3b7a419db99cb095ebb88cc765",
                "SwitchFgo",
                "Android",
                "aK8mTxBJCwZyxBjNJSKA5xCWL7zKtgZEQNiZmffXUbyQd5aLun",
                "/rongame_beta/rgfate/60_member/",
                "/rongame_beta/rgfate/60_1001/",
                "1",
                "10",
                "1519070400",
            };
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
