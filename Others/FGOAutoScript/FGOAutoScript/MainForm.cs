using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FGOAutoScript
{
    public partial class MainForm : Form
    {

        PlayerStatus ps = new PlayerStatus();
        BattleInfo bif = new BattleInfo();
        string deckId = "";

        private int battleTime = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        public void topLogin(string uid, string nickname)
        {
            var toplogin = FgoRequest.fgo_toplogin(uid, nickname);
            if (toplogin.uid.Length != 12)
            {
                LogHelper.createFailMessageBox(toplogin);
                return;
            }
            ps = toplogin;
            id.Text = ps.uid;
            name.Text = ps.name;
            var i = 0;
            foreach (var deckName in ps.deckList.Values)
            {
                deckList.Items.Insert(i, deckName);
                i++;
            }
            deckList.SelectedIndex = 0;
            logBox.AppendText(LogHelper.getPrefix() + "登录第二步成功.\r\n");
        }

        private void home()
        {
            var home = FgoRequest.fgo_home(ps);
            if (ps.uid.Length != 12)
            {
                logBox.AppendText(LogHelper.createFailMessageBox(ps));
                return;
            }
            ps = home;
            //if (((DataTable)itemInv.DataSource).Rows.Count > 0)
            //{
                var invTable = new DataTable();
                invTable.Columns.AddRange(new DataColumn[] { new DataColumn("物品名字"), new DataColumn("数量") });
                foreach (var item in ps.itemList)
                {
                    if (item.Value != 0)
                    {
                        if (ScriptConst.mstItem.ContainsKey(item.Key))
                        {
                            invTable.Rows.Add(ScriptConst.mstItem[item.Key], item.Value);
                        }
                        else
                        {
                            invTable.Rows.Add(item.Key, item.Value);
                        }
                    }
                }
                itemInv.DataSource = invTable;
            //}
            maxAp.Text = ps.actMax.ToString();
            nowAp.Text = FgoMain.GetBaseAct(ps.actRecoverAt, ps.actMax).ToString();
            freeStone.Text = ps.freeStone.ToString();
            chargeStone.Text = ps.chargeStone.ToString();
            followerBox.Items.Clear();
            var isFound = false;
            var i = 0;
            foreach (var fs in ps.followerInfo.Keys)
            {
                followerBox.Items.Insert(i, fs);
                if (equipMin.Text.Equals("") && !equipMax.Text.Equals(""))
                    equipMin.Text = equipMax.Text;
                else if (equipMax.Text.Equals("") && !equipMin.Text.Equals(""))
                    equipMax.Text = equipMin.Text;
                if (!equipMin.Text.Equals("") && !equipMax.Text.Equals("") && !isFound)
                {
                    var fsp = ps.followerList[ps.followerInfo[fs]];
                    for (var ii = 0; ii < fsp.Length; ii++)
                    {
                        if (fullEquip.Checked && !fsp[ii].equipMax)
                            continue;
                        if (!(int.Parse(fsp[ii].equipId) >= int.Parse(equipMin.Text)))
                            continue;
                        if (!(int.Parse(fsp[ii].equipId) <= int.Parse(equipMax.Text)))
                            continue;
                        followerBox.SelectedIndex = i;
                        followerClass.SelectedIndex = ii;
                        isFound = true;
                    }
                }
                    i++;
            }
            logBox.AppendText(LogHelper.getPrefix() + "刷新数据成功.\r\n");
        }

        private void battlesetup()
        {
            btnRefreshInv.Enabled = false;
            btnRecoverAp.Enabled = false;
            sellExp.Enabled = false;
            if (resultTime.Text != "")
                resultTime.Text = "30";
            startBattle.Enabled = false;
            battleTimes.ReadOnly = true;
            var bi = FgoRequest.fgo_battlesetup(ps.uid, questId.Text,questPhase.Text,deckId,ps.followerInfo[followerBox.Text], followerClass.SelectedIndex);
            bif = bi;
            if (bi.battleResCode != "00")
            {
                var jo = JObject.Parse(bi.battleExtra);
                if (jo["detail"].ToString().IndexOf("AP不足") != -1 && autoApple.Checked)
                {
                    if (!recoverAp(apBox.SelectedIndex))
                    {
                        goto sth;
                    }
                    battlesetup();
                    return;
                }
                if (jo["detail"].ToString().IndexOf("从者数量") != -1 && autoSell.Checked)
                {
                    if (!sellExpFunc(0))
                    {
                        goto sth;
                    }
                    battlesetup();
                    return;
                }
                logBox.AppendText(LogHelper.createFailMessageBox(new string[] { "00", jo["title"].ToString(), jo["detail"].ToString()}));
                sth:
                btnRefreshInv.Enabled = true;
                btnRecoverAp.Enabled = true;
                sellExp.Enabled = true;
                startBattle.Enabled = true;
                battleTimes.ReadOnly = false;
                battleTimes.Text = ScriptConst.battleTimes;
                return;
            }
            logBox.AppendText(LogHelper.getPrefix() + "战斗" + bi.battleId + "掉落：\r\n");
            foreach(var dic in bi.dropInfo)
            {
                if (ScriptConst.mstItem.ContainsKey(dic.Key))
                {
                    logBox.AppendText(LogHelper.getPrefix() + ScriptConst.mstItem[dic.Key] + " x " + dic.Value + "\r\n");
                }
                else
                {
                    logBox.AppendText(LogHelper.getPrefix() + dic.Key + " x " + dic.Value + "\r\n");
                }
            }
            ScriptConst.settingTime = resultTime.Text;
            battleTime = int.Parse(ScriptConst.settingTime);
            battleTimer.Enabled = true;
            resultTime.Enabled = false;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var rsa = BiliLogin.bili_rsa();
            var bl = BiliLogin.bili_login(user.Text, password.Text, rsa[0], rsa[1]);
            if (bl[0] == "pwd_error")
            {
                MessageBox.Show("密码错误");
                return;
            }
            var userinfo = BiliLogin.bili_userinfo(bl[1]);
            face.BackgroundImageLayout = ImageLayout.Stretch;
            face.SizeMode = PictureBoxSizeMode.StretchImage;
            face.Load(userinfo[1]);
            var center = FgoRequest.fgo_logintomembercenter(userinfo[0], bl[0], bl[1]);
            if (center[0] != "00")
            {
                logBox.AppendText(LogHelper.createFailMessageBox(center));
                return;
            }
            var login = FgoRequest.fgo_login(center[1], center[2]);
            if (login[0] != "00")
            {
                logBox.AppendText(LogHelper.createFailMessageBox(login));
                return;
            }
            logBox.AppendText(LogHelper.getPrefix() + FgoMain.get_usk(login[1]) + "\r\n");
            btnLogin.Enabled = false;
            btnRefreshInv.Enabled = true;
            startBattle.Enabled = true;
            finishBattle.Enabled = true;
            btnRecoverAp.Enabled = true;
            sellExp.Enabled = true;
            //startKeJin.Enabled = true;
            sellThreeStars.Enabled = true;
            output.Enabled = true;
            logBox.AppendText(LogHelper.getPrefix() + "登录第一步成功.\r\n");
            topLogin(login[1], login[2]);
            home();
        }

        private void btnGetVersion_Click(object sender, EventArgs e)
        {
            FgoConstant.fgo_const[0] = versionLabel.Text;
            FgoRequest.fgo_server();
            var member = FgoRequest.fgo_member();
            if (member[0] != "00")
            {
                logBox.AppendText(LogHelper.createFailMessageBox(member));
                return;
            }
            logBox.AppendText(LogHelper.getPrefix() + "服务器获取成功 [" + FgoMain.get_data_ver() + "]\r\n");
            btnLogin.Enabled = true;
            btnGetVersion.Enabled = false;
            user.Enabled = true;
            password.Enabled = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            func.SelectedIndex = 0;
            stoneOrTicket.SelectedIndex = 0;
            if (File.Exists("data2"))
            {
                try
                {
                    var data = DataEncoder.Decode(FgoMain.convert_response(File.ReadAllText("data2"))).Split('\\');
                    user.Text = data[0];
                    password.Text = data[1];
                    equipMin.Text = data[2];
                    equipMax.Text = data[3];
                    fullEquip.Checked = bool.Parse(data[4]);
                    questId.Text = data[5];
                    questPhase.Text = data[6];
                    resultTime.Text = data[7];
                    battleTimes.Text = data[8];
                    if (!data[9].Equals(""))
                        apBox.SelectedIndex = int.Parse(data[9]);
                    autoApple.Checked = bool.Parse(data[10]);
                    autoSell.Checked = bool.Parse(data[11]);
                }
                catch (Exception)
                {
                    File.Delete("data2");
                }
                if (File.Exists("itemdata.json"))
                {
                    var sr = new StreamReader("itemdata.json", Encoding.UTF8, true);
                    try
                    {
                        JToken itemData = (JObject)JsonConvert.DeserializeObject(sr.ReadToEnd());
                        foreach (JProperty item in itemData)
                        {
                            ScriptConst.mstItem.Add(item.Name.ToString(), item.Value.ToString());
                        }
                    }
                    catch (Exception)
                    {
                    }
                    sr.Close();
                    sr.Dispose();
                }
                if (File.Exists("svtdata.json"))
                {
                    var sr = new StreamReader("svtdata.json", Encoding.UTF8, true);
                    try
                    {
                        JToken svtData = (JObject)JsonConvert.DeserializeObject(sr.ReadToEnd());
                        foreach (JProperty item in svtData)
                        {
                            ScriptConst.mstSvt.Add(item.Name.ToString(), item.Value.ToString());
                        }
                    }
                    catch (Exception)
                    {
                    }
                    sr.Close();
                    sr.Dispose();
                }
            }
            var invTable = new DataTable();
            invTable.Columns.AddRange(new DataColumn[] { new DataColumn("物品名字"), new DataColumn("数量") });
            itemInv.DataSource = invTable;
            logBox.AppendText(LogHelper.getPrefix() + "程序加载成功.\r\n");
        }

        private void btnRefreshInv_Click(object sender, EventArgs e)
        {
            home();
        }

        private void startBattle_Click(object sender, EventArgs e)
        {
            ScriptConst.battleTimes = battleTimes.Text;
            battlesetup();
        }

        private void battleTimer_Tick(object sender, EventArgs e)
        {
            resultTime.Text = battleTime.ToString();
            battleTime--;
            if (battleTime < 0)
            {
                var br = FgoRequest.fgo_battleresult(ps.uid, bif);
                battleTimes.Text = (int.Parse(battleTimes.Text) - 1).ToString();
                if (br[0] != "00") 
                {
                    battleTimer.Enabled = false;
                    logBox.AppendText(LogHelper.createFailMessageBox(br));
                    startBattle.Enabled = true;
                    btnRefreshInv.Enabled = true;
                    btnRecoverAp.Enabled = true;
                    sellExp.Enabled = true;
                    resultTime.Enabled = true;
                    resultTime.Text = ScriptConst.settingTime;
                    battleTimes.Text = ScriptConst.battleTimes;
                    battleTimes.ReadOnly = false;
                    return;
                }
                battleTimer.Enabled = false;
                home();
                startBattle.Enabled = true;
                resultTime.Enabled = true;
                resultTime.Text = ScriptConst.settingTime;
                battleTimes.ReadOnly = false;
                btnRefreshInv.Enabled = true;
                btnRecoverAp.Enabled = true;
                sellExp.Enabled = true;
                if (int.Parse(battleTimes.Text) > 0)
                    battlesetup();
                else
                {
                    battleTimes.Text = ScriptConst.battleTimes;
                }
            }
        }

        private void finishBattle_Click(object sender, EventArgs e)
        {
            if (battleTimer.Enabled)
                battleTimes.Text = "1";
        }

        private void battleTimes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void resultTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnRecoverAp_Click(object sender, EventArgs e)
        {
            recoverAp(apBox.SelectedIndex);
        }

        private bool recoverAp(int selectedIndex)
        {
            var rec = FgoRequest.fgo_recover(ps.uid, selectedIndex);
            if (rec[0] != "00")
            {
                logBox.AppendText(LogHelper.createFailMessageBox(rec));
                return false;
            }
            logBox.AppendText(LogHelper.getPrefix() + "体力已回复.\r\n");
            home();
            return true;
        }

        private void equipId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void equipMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void sellExp_Click(object sender, EventArgs e)
        {
            sellExpFunc(0);
        }

        private bool sellExpFunc(int type)
        {
            var idList = new List<string>();
            foreach (var pse in ps.servantList)
            {
                var fse = pse.Value;
                if (fse.isLock)
                    continue;
                if (type == 0)
                {
                    if (!fse.svtId.StartsWith("970") && fse.svtId != "9770300")
                        continue;
                    if (fse.svtId.EndsWith("400"))
                        continue;
                }
                else
                {
                    if (!fse.svtId.StartsWith("970") && !fse.svtId.StartsWith("9750") && !fse.svtId.StartsWith("9770"))
                        continue;
                }
                idList.Add(pse.Key);
            }
            var idListArray = idList.ToArray();
            var str = string.Empty;
            for (var i = 0; i < idListArray.Length; i++)
            {
                if (i > 0)
                {
                    str = str + ",";
                }
                var str2 = str;
                var objArray1 = new object[] { str2, "{\"id\":", long.Parse(idListArray[i]), ",\"num\":1}" };
                str = string.Concat(objArray1);
            }
            var sell = FgoRequest.fgo_shopsellsvt(ps.uid, str);
            if (sell[0] != "00")
            {
                logBox.AppendText(LogHelper.createFailMessageBox(sell));
                return false;
            }
            logBox.AppendText(LogHelper.getPrefix() + "狗粮已出售.\r\n");
            logBox.AppendText(LogHelper.getPrefix() + "总计: " + idListArray.Length + "\r\n");
            logBox.AppendText(LogHelper.getPrefix() + "获得QP: " + sell[1] + "\r\n");
            home();
            return true;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var fs = new FileStream("data2", FileMode.Create);
            var save = Convert.ToBase64String(Encoding.UTF8.GetBytes(DataEncoder.Encode(user.Text + "\\" + password.Text + "\\" + equipMin.Text + "\\" + equipMax.Text + "\\" + fullEquip.Checked.ToString() + "\\" + questId.Text + "\\" + questPhase.Text + "\\" + resultTime.Text + "\\" + battleTimes.Text + "\\" + apBox.SelectedIndex.ToString() + "\\" + autoApple.Checked.ToString() + "\\" + autoSell.Checked.ToString())));
            var saveData = Encoding.UTF8.GetBytes(save);
            fs.Write(saveData, 0, saveData.Length);
            fs.Close();
            fs.Dispose();
        }

        /*
        private void startKeJin_Click(object sender, EventArgs e)
        {
            IDictionary<string, string> gachadraw = NetworkAPI.PostAcRequest("gachadraw");
            gachadraw.Add("gachaId", gachaId.Text);
            if (func.SelectedIndex == 0)
            {
                gachadraw.Add("num", "1");
                gachadraw.Add("shopIdIndex", "1");
                if (stoneOrTicket.SelectedIndex == 0)
                    gachadraw.Add("ticketItemId", "0");
                else
                    gachadraw.Add("ticketItemId", "4001");
            }
            else
            {
                gachadraw.Add("shopIdIndex", "2");
                gachadraw.Add("num", "10");
                gachadraw.Add("ticketItemId", "0");
            }
            HttpWebResponse gachadrawRes = NetworkAPI.CreatePostHttpResponse(ScriptConst.fgoServer[0] + ScriptConst.rongame_beta_2 + "ac.php", gachadraw);
            string gachadrawJson = NetworkAPI.GetStringByBase64(new StreamReader(gachadrawRes.GetResponseStream()).ReadToEnd());
            JObject gdResponse = (JObject)((JArray)((JObject)JsonConvert.DeserializeObject(gachadrawJson))["response"])[0];
            if (gdResponse["resCode"].ToString() != "00")
            {
                logBox.AppendText(NetworkAPI.CreateFailMessageBox(gdResponse));
                return;
            }
            ScriptConst.usk = gdResponse["usk"].ToString();
            usk.Text = ScriptConst.usk;
            JArray gachaInfos = (JArray)((JObject)gdResponse["success"])["gachaInfos"];
            for (int i = 0; i < gachaInfos.Count; i++)
            {
                JObject data = (JObject)gachaInfos[i];
                string objectId = data["objectId"].ToString();
                if (ScriptConst.mstSvt.ContainsKey(objectId))
                {
                    logBox.AppendText(LogHelper.getPrefix() + i + ": " + ScriptConst.mstSvt[objectId] + "\r\n");
                }
                else
                {
                    logBox.AppendText(LogHelper.getPrefix() + i + ": " + objectId + "\r\n");
                }
            }
            JObject userGame = (JObject)((JArray)((JObject)((JObject)((JObject)JsonConvert.DeserializeObject(gachadrawJson))["cache"])["updated"])["userGame"])[0];
            freeStone.Text = userGame["freeStone"].ToString();
            chargeStone.Text = userGame["chargeStone"].ToString();
        }
        */

        private void sellThreeStars_Click(object sender, EventArgs e)
        {
            home();
            sellExpFunc(1);
        }

        private void output_Click(object sender, EventArgs e)
        {
            var fs = File.Open(ps.uid + ".txt", FileMode.Create);
            var data = Encoding.UTF8.GetBytes(logBox.Text);
            fs.Write(data,0,data.Length);
            fs.Close();
            fs.Dispose();
        }

        private void deckList_TextChanged(object sender, EventArgs e)
        {
            if (ps.deckList != null && ps.deckList.Count != 0)
            {
                foreach (var item in ps.deckList)
                {
                    if (deckList.Text == item.Value)
                    {
                        deckId = item.Key;
                        break;
                    }
                }
            }
        }
    }
}
