namespace FGOAutoScript
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnGetVersion = new System.Windows.Forms.Button();
			this.btnRefreshInv = new System.Windows.Forms.Button();
			this.itemInv = new System.Windows.Forms.DataGridView();
			this.label7 = new System.Windows.Forms.Label();
			this.nowAp = new System.Windows.Forms.TextBox();
			this.maxAp = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.deckList = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.followerClass = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.questId = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.questPhase = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.resultTime = new System.Windows.Forms.TextBox();
			this.startBattle = new System.Windows.Forms.Button();
			this.battleTimer = new System.Windows.Forms.Timer(this.components);
			this.followerBox = new System.Windows.Forms.ComboBox();
			this.btnRecoverAp = new System.Windows.Forms.Button();
			this.apBox = new System.Windows.Forms.ComboBox();
			this.battleTimes = new System.Windows.Forms.TextBox();
			this.finishBattle = new System.Windows.Forms.Button();
			this.autoApple = new System.Windows.Forms.CheckBox();
			this.logBox = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.equipMin = new System.Windows.Forms.TextBox();
			this.fullEquip = new System.Windows.Forms.CheckBox();
			this.autoSell = new System.Windows.Forms.CheckBox();
			this.equipMax = new System.Windows.Forms.TextBox();
			this.sellExp = new System.Windows.Forms.Button();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.gachaId = new System.Windows.Forms.TextBox();
			this.shopIdIndex = new System.Windows.Forms.TextBox();
			this.func = new System.Windows.Forms.ComboBox();
			this.stoneOrTicket = new System.Windows.Forms.ComboBox();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.freeStone = new System.Windows.Forms.TextBox();
			this.chargeStone = new System.Windows.Forms.TextBox();
			this.sellThreeStars = new System.Windows.Forms.Button();
			this.output = new System.Windows.Forms.Button();
			this.versionLabel = new System.Windows.Forms.TextBox();
			this.face = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.user = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.password = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.id = new System.Windows.Forms.TextBox();
			this.name = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.itemInv)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.face)).BeginInit();
			this.SuspendLayout();
			// 
			// btnLogin
			// 
			this.btnLogin.Enabled = false;
			this.btnLogin.Location = new System.Drawing.Point(279, 60);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(75, 23);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.TabStop = false;
			this.btnLogin.Text = "登录";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnGetVersion
			// 
			this.btnGetVersion.Location = new System.Drawing.Point(224, 11);
			this.btnGetVersion.Name = "btnGetVersion";
			this.btnGetVersion.Size = new System.Drawing.Size(52, 23);
			this.btnGetVersion.TabIndex = 7;
			this.btnGetVersion.TabStop = false;
			this.btnGetVersion.Text = "获取";
			this.btnGetVersion.UseVisualStyleBackColor = true;
			this.btnGetVersion.Click += new System.EventHandler(this.btnGetVersion_Click);
			// 
			// btnRefreshInv
			// 
			this.btnRefreshInv.Enabled = false;
			this.btnRefreshInv.Location = new System.Drawing.Point(355, 60);
			this.btnRefreshInv.Name = "btnRefreshInv";
			this.btnRefreshInv.Size = new System.Drawing.Size(75, 23);
			this.btnRefreshInv.TabIndex = 14;
			this.btnRefreshInv.TabStop = false;
			this.btnRefreshInv.Text = "刷新";
			this.btnRefreshInv.UseVisualStyleBackColor = true;
			this.btnRefreshInv.Click += new System.EventHandler(this.btnRefreshInv_Click);
			// 
			// itemInv
			// 
			this.itemInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.itemInv.Location = new System.Drawing.Point(12, 137);
			this.itemInv.Name = "itemInv";
			this.itemInv.ReadOnly = true;
			this.itemInv.RowTemplate.Height = 23;
			this.itemInv.Size = new System.Drawing.Size(264, 306);
			this.itemInv.TabIndex = 15;
			this.itemInv.TabStop = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(279, 141);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(41, 12);
			this.label7.TabIndex = 16;
			this.label7.Text = "行动力";
			// 
			// nowAp
			// 
			this.nowAp.Location = new System.Drawing.Point(322, 137);
			this.nowAp.Name = "nowAp";
			this.nowAp.ReadOnly = true;
			this.nowAp.Size = new System.Drawing.Size(52, 21);
			this.nowAp.TabIndex = 17;
			this.nowAp.TabStop = false;
			this.nowAp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// maxAp
			// 
			this.maxAp.Location = new System.Drawing.Point(373, 137);
			this.maxAp.Name = "maxAp";
			this.maxAp.ReadOnly = true;
			this.maxAp.Size = new System.Drawing.Size(56, 21);
			this.maxAp.TabIndex = 18;
			this.maxAp.TabStop = false;
			this.maxAp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(284, 165);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(29, 12);
			this.label8.TabIndex = 19;
			this.label8.Text = "编队";
			// 
			// deckList
			// 
			this.deckList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.deckList.FormattingEnabled = true;
			this.deckList.Location = new System.Drawing.Point(322, 161);
			this.deckList.Name = "deckList";
			this.deckList.Size = new System.Drawing.Size(107, 20);
			this.deckList.TabIndex = 20;
			this.deckList.TabStop = false;
			this.deckList.TextChanged += new System.EventHandler(this.deckList_TextChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(279, 188);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(41, 12);
			this.label9.TabIndex = 21;
			this.label9.Text = "嫖好友";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(283, 212);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(29, 12);
			this.label10.TabIndex = 23;
			this.label10.Text = "职阶";
			// 
			// followerClass
			// 
			this.followerClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.followerClass.FormattingEnabled = true;
			this.followerClass.Items.AddRange(new object[] {
            "ALL",
            "SABER",
            "ARCHER",
            "LANCER",
            "RIDER",
            "CASTER",
            "ASSASSIN",
            "BERSERKER"});
			this.followerClass.Location = new System.Drawing.Point(322, 209);
			this.followerClass.Name = "followerClass";
			this.followerClass.Size = new System.Drawing.Size(107, 20);
			this.followerClass.TabIndex = 24;
			this.followerClass.TabStop = false;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(284, 283);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(47, 12);
			this.label11.TabIndex = 25;
			this.label11.Text = "questId";
			// 
			// questId
			// 
			this.questId.Location = new System.Drawing.Point(337, 280);
			this.questId.Name = "questId";
			this.questId.Size = new System.Drawing.Size(92, 21);
			this.questId.TabIndex = 26;
			this.questId.TabStop = false;
			this.questId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(284, 307);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(65, 12);
			this.label12.TabIndex = 27;
			this.label12.Text = "questPhase";
			// 
			// questPhase
			// 
			this.questPhase.Location = new System.Drawing.Point(354, 304);
			this.questPhase.Name = "questPhase";
			this.questPhase.Size = new System.Drawing.Size(75, 21);
			this.questPhase.TabIndex = 28;
			this.questPhase.TabStop = false;
			this.questPhase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(284, 331);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(65, 12);
			this.label13.TabIndex = 29;
			this.label13.Text = "时间（秒）";
			// 
			// resultTime
			// 
			this.resultTime.Location = new System.Drawing.Point(354, 328);
			this.resultTime.Name = "resultTime";
			this.resultTime.Size = new System.Drawing.Size(75, 21);
			this.resultTime.TabIndex = 30;
			this.resultTime.TabStop = false;
			this.resultTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.resultTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.resultTime_KeyPress);
			// 
			// startBattle
			// 
			this.startBattle.Enabled = false;
			this.startBattle.Location = new System.Drawing.Point(353, 353);
			this.startBattle.Name = "startBattle";
			this.startBattle.Size = new System.Drawing.Size(39, 23);
			this.startBattle.TabIndex = 31;
			this.startBattle.TabStop = false;
			this.startBattle.Text = "开始";
			this.startBattle.UseVisualStyleBackColor = true;
			this.startBattle.Click += new System.EventHandler(this.startBattle_Click);
			// 
			// battleTimer
			// 
			this.battleTimer.Interval = 1000;
			this.battleTimer.Tick += new System.EventHandler(this.battleTimer_Tick);
			// 
			// followerBox
			// 
			this.followerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.followerBox.FormattingEnabled = true;
			this.followerBox.Location = new System.Drawing.Point(322, 185);
			this.followerBox.Name = "followerBox";
			this.followerBox.Size = new System.Drawing.Size(107, 20);
			this.followerBox.TabIndex = 32;
			this.followerBox.TabStop = false;
			// 
			// btnRecoverAp
			// 
			this.btnRecoverAp.Enabled = false;
			this.btnRecoverAp.Location = new System.Drawing.Point(365, 378);
			this.btnRecoverAp.Name = "btnRecoverAp";
			this.btnRecoverAp.Size = new System.Drawing.Size(65, 23);
			this.btnRecoverAp.TabIndex = 33;
			this.btnRecoverAp.TabStop = false;
			this.btnRecoverAp.Text = "回体力";
			this.btnRecoverAp.UseVisualStyleBackColor = true;
			this.btnRecoverAp.Click += new System.EventHandler(this.btnRecoverAp_Click);
			// 
			// apBox
			// 
			this.apBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.apBox.FormattingEnabled = true;
			this.apBox.Items.AddRange(new object[] {
            "石头",
            "金苹果",
            "银苹果",
            "铜苹果"});
			this.apBox.Location = new System.Drawing.Point(281, 380);
			this.apBox.Name = "apBox";
			this.apBox.Size = new System.Drawing.Size(76, 20);
			this.apBox.TabIndex = 34;
			this.apBox.TabStop = false;
			// 
			// battleTimes
			// 
			this.battleTimes.Location = new System.Drawing.Point(280, 355);
			this.battleTimes.Name = "battleTimes";
			this.battleTimes.Size = new System.Drawing.Size(67, 21);
			this.battleTimes.TabIndex = 35;
			this.battleTimes.TabStop = false;
			this.battleTimes.Text = "1";
			this.battleTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.battleTimes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.battleTimes_KeyPress);
			// 
			// finishBattle
			// 
			this.finishBattle.Enabled = false;
			this.finishBattle.Location = new System.Drawing.Point(391, 353);
			this.finishBattle.Name = "finishBattle";
			this.finishBattle.Size = new System.Drawing.Size(39, 23);
			this.finishBattle.TabIndex = 36;
			this.finishBattle.TabStop = false;
			this.finishBattle.Text = "停止";
			this.finishBattle.UseVisualStyleBackColor = true;
			this.finishBattle.Click += new System.EventHandler(this.finishBattle_Click);
			// 
			// autoApple
			// 
			this.autoApple.AutoSize = true;
			this.autoApple.Location = new System.Drawing.Point(282, 403);
			this.autoApple.Name = "autoApple";
			this.autoApple.Size = new System.Drawing.Size(120, 16);
			this.autoApple.TabIndex = 37;
			this.autoApple.TabStop = false;
			this.autoApple.Text = "刷图无AP自动回复";
			this.autoApple.UseVisualStyleBackColor = true;
			// 
			// logBox
			// 
			this.logBox.Location = new System.Drawing.Point(435, 3);
			this.logBox.Multiline = true;
			this.logBox.Name = "logBox";
			this.logBox.ReadOnly = true;
			this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.logBox.Size = new System.Drawing.Size(310, 529);
			this.logBox.TabIndex = 38;
			this.logBox.TabStop = false;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(283, 236);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(53, 12);
			this.label14.TabIndex = 39;
			this.label14.Text = "礼装代码";
			// 
			// equipMin
			// 
			this.equipMin.Location = new System.Drawing.Point(342, 232);
			this.equipMin.Name = "equipMin";
			this.equipMin.Size = new System.Drawing.Size(87, 21);
			this.equipMin.TabIndex = 40;
			this.equipMin.TabStop = false;
			this.equipMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.equipMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.equipId_KeyPress);
			// 
			// fullEquip
			// 
			this.fullEquip.AutoSize = true;
			this.fullEquip.Location = new System.Drawing.Point(285, 258);
			this.fullEquip.Name = "fullEquip";
			this.fullEquip.Size = new System.Drawing.Size(48, 16);
			this.fullEquip.TabIndex = 41;
			this.fullEquip.TabStop = false;
			this.fullEquip.Text = "满破";
			this.fullEquip.UseVisualStyleBackColor = true;
			// 
			// autoSell
			// 
			this.autoSell.AutoSize = true;
			this.autoSell.Location = new System.Drawing.Point(282, 424);
			this.autoSell.Name = "autoSell";
			this.autoSell.Size = new System.Drawing.Size(84, 16);
			this.autoSell.TabIndex = 42;
			this.autoSell.TabStop = false;
			this.autoSell.Text = "自动卖狗粮";
			this.autoSell.UseVisualStyleBackColor = true;
			// 
			// equipMax
			// 
			this.equipMax.Location = new System.Drawing.Point(342, 256);
			this.equipMax.Name = "equipMax";
			this.equipMax.Size = new System.Drawing.Size(87, 21);
			this.equipMax.TabIndex = 43;
			this.equipMax.TabStop = false;
			this.equipMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.equipMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.equipMax_KeyPress);
			// 
			// sellExp
			// 
			this.sellExp.Enabled = false;
			this.sellExp.Location = new System.Drawing.Point(365, 420);
			this.sellExp.Name = "sellExp";
			this.sellExp.Size = new System.Drawing.Size(64, 23);
			this.sellExp.TabIndex = 44;
			this.sellExp.TabStop = false;
			this.sellExp.Text = "卖狗粮";
			this.sellExp.UseVisualStyleBackColor = true;
			this.sellExp.Click += new System.EventHandler(this.sellExp_Click);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(14, 450);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(47, 12);
			this.label15.TabIndex = 45;
			this.label15.Text = "gachaId";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(14, 471);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(29, 12);
			this.label16.TabIndex = 46;
			this.label16.Text = "抽法";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(14, 493);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(59, 12);
			this.label17.TabIndex = 47;
			this.label17.Text = "石头/呼符";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(14, 514);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(71, 12);
			this.label18.TabIndex = 48;
			this.label18.Text = "shopIdIndex";
			// 
			// gachaId
			// 
			this.gachaId.Location = new System.Drawing.Point(95, 447);
			this.gachaId.Name = "gachaId";
			this.gachaId.Size = new System.Drawing.Size(100, 21);
			this.gachaId.TabIndex = 49;
			this.gachaId.TabStop = false;
			this.gachaId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// shopIdIndex
			// 
			this.shopIdIndex.Location = new System.Drawing.Point(95, 511);
			this.shopIdIndex.Name = "shopIdIndex";
			this.shopIdIndex.Size = new System.Drawing.Size(100, 21);
			this.shopIdIndex.TabIndex = 50;
			this.shopIdIndex.TabStop = false;
			this.shopIdIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// func
			// 
			this.func.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.func.FormattingEnabled = true;
			this.func.Items.AddRange(new object[] {
            "单抽",
            "十连"});
			this.func.Location = new System.Drawing.Point(95, 469);
			this.func.Name = "func";
			this.func.Size = new System.Drawing.Size(100, 20);
			this.func.TabIndex = 51;
			this.func.TabStop = false;
			// 
			// stoneOrTicket
			// 
			this.stoneOrTicket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.stoneOrTicket.FormattingEnabled = true;
			this.stoneOrTicket.Items.AddRange(new object[] {
            "石头",
            "呼符"});
			this.stoneOrTicket.Location = new System.Drawing.Point(95, 490);
			this.stoneOrTicket.Name = "stoneOrTicket";
			this.stoneOrTicket.Size = new System.Drawing.Size(100, 20);
			this.stoneOrTicket.TabIndex = 52;
			this.stoneOrTicket.TabStop = false;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(203, 450);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(53, 12);
			this.label19.TabIndex = 53;
			this.label19.Text = "免费石头";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(317, 450);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(53, 12);
			this.label20.TabIndex = 54;
			this.label20.Text = "付费石头";
			// 
			// freeStone
			// 
			this.freeStone.Location = new System.Drawing.Point(257, 446);
			this.freeStone.Name = "freeStone";
			this.freeStone.ReadOnly = true;
			this.freeStone.Size = new System.Drawing.Size(56, 21);
			this.freeStone.TabIndex = 55;
			this.freeStone.TabStop = false;
			this.freeStone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// chargeStone
			// 
			this.chargeStone.Location = new System.Drawing.Point(372, 446);
			this.chargeStone.Name = "chargeStone";
			this.chargeStone.ReadOnly = true;
			this.chargeStone.Size = new System.Drawing.Size(56, 21);
			this.chargeStone.TabIndex = 56;
			this.chargeStone.TabStop = false;
			this.chargeStone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// sellThreeStars
			// 
			this.sellThreeStars.Enabled = false;
			this.sellThreeStars.Location = new System.Drawing.Point(365, 490);
			this.sellThreeStars.Name = "sellThreeStars";
			this.sellThreeStars.Size = new System.Drawing.Size(65, 23);
			this.sellThreeStars.TabIndex = 58;
			this.sellThreeStars.TabStop = false;
			this.sellThreeStars.Text = "狗粮全卖";
			this.sellThreeStars.UseVisualStyleBackColor = true;
			this.sellThreeStars.Click += new System.EventHandler(this.sellThreeStars_Click);
			// 
			// output
			// 
			this.output.Enabled = false;
			this.output.Location = new System.Drawing.Point(365, 468);
			this.output.Name = "output";
			this.output.Size = new System.Drawing.Size(65, 23);
			this.output.TabIndex = 59;
			this.output.TabStop = false;
			this.output.Text = "输出记录";
			this.output.UseVisualStyleBackColor = true;
			this.output.Click += new System.EventHandler(this.output_Click);
			// 
			// versionLabel
			// 
			this.versionLabel.Location = new System.Drawing.Point(143, 12);
			this.versionLabel.Name = "versionLabel";
			this.versionLabel.Size = new System.Drawing.Size(75, 21);
			this.versionLabel.TabIndex = 60;
			this.versionLabel.Text = "1.17.1";
			this.versionLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// face
			// 
			this.face.Location = new System.Drawing.Point(12, 41);
			this.face.Name = "face";
			this.face.Size = new System.Drawing.Size(90, 90);
			this.face.TabIndex = 61;
			this.face.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(108, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 62;
			this.label1.Text = "账号";
			// 
			// user
			// 
			this.user.Enabled = false;
			this.user.Location = new System.Drawing.Point(143, 38);
			this.user.Name = "user";
			this.user.Size = new System.Drawing.Size(133, 21);
			this.user.TabIndex = 63;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(108, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 64;
			this.label2.Text = "密码";
			// 
			// password
			// 
			this.password.Enabled = false;
			this.password.Location = new System.Drawing.Point(143, 60);
			this.password.Name = "password";
			this.password.PasswordChar = '●';
			this.password.Size = new System.Drawing.Size(133, 21);
			this.password.TabIndex = 65;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(108, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 12);
			this.label3.TabIndex = 66;
			this.label3.Text = "代码";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(108, 109);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 12);
			this.label4.TabIndex = 67;
			this.label4.Text = "名字";
			// 
			// id
			// 
			this.id.Location = new System.Drawing.Point(143, 83);
			this.id.Name = "id";
			this.id.ReadOnly = true;
			this.id.Size = new System.Drawing.Size(133, 21);
			this.id.TabIndex = 68;
			// 
			// name
			// 
			this.name.Location = new System.Drawing.Point(143, 106);
			this.name.Name = "name";
			this.name.ReadOnly = true;
			this.name.Size = new System.Drawing.Size(133, 21);
			this.name.TabIndex = 69;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(747, 537);
			this.Controls.Add(this.name);
			this.Controls.Add(this.id);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.password);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.user);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.face);
			this.Controls.Add(this.versionLabel);
			this.Controls.Add(this.output);
			this.Controls.Add(this.sellThreeStars);
			this.Controls.Add(this.chargeStone);
			this.Controls.Add(this.freeStone);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.stoneOrTicket);
			this.Controls.Add(this.func);
			this.Controls.Add(this.shopIdIndex);
			this.Controls.Add(this.gachaId);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.sellExp);
			this.Controls.Add(this.equipMax);
			this.Controls.Add(this.autoSell);
			this.Controls.Add(this.fullEquip);
			this.Controls.Add(this.equipMin);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.logBox);
			this.Controls.Add(this.autoApple);
			this.Controls.Add(this.finishBattle);
			this.Controls.Add(this.battleTimes);
			this.Controls.Add(this.apBox);
			this.Controls.Add(this.btnRecoverAp);
			this.Controls.Add(this.followerBox);
			this.Controls.Add(this.startBattle);
			this.Controls.Add(this.resultTime);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.questPhase);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.questId);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.followerClass);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.deckList);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.maxAp);
			this.Controls.Add(this.nowAp);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.itemInv);
			this.Controls.Add(this.btnRefreshInv);
			this.Controls.Add(this.btnGetVersion);
			this.Controls.Add(this.btnLogin);
			this.Name = "MainForm";
			this.Text = "LCScript 1.0";
			this.TopMost = true;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.itemInv)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.face)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnGetVersion;
        private System.Windows.Forms.Button btnRefreshInv;
        private System.Windows.Forms.DataGridView itemInv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nowAp;
        private System.Windows.Forms.TextBox maxAp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox deckList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox followerClass;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox questId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox questPhase;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox resultTime;
        private System.Windows.Forms.Button startBattle;
        private System.Windows.Forms.Timer battleTimer;
        private System.Windows.Forms.ComboBox followerBox;
        private System.Windows.Forms.Button btnRecoverAp;
        private System.Windows.Forms.ComboBox apBox;
        private System.Windows.Forms.TextBox battleTimes;
        private System.Windows.Forms.Button finishBattle;
        private System.Windows.Forms.CheckBox autoApple;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox equipMin;
        private System.Windows.Forms.CheckBox fullEquip;
        private System.Windows.Forms.CheckBox autoSell;
        private System.Windows.Forms.TextBox equipMax;
        private System.Windows.Forms.Button sellExp;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox gachaId;
        private System.Windows.Forms.TextBox shopIdIndex;
        private System.Windows.Forms.ComboBox func;
        private System.Windows.Forms.ComboBox stoneOrTicket;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox freeStone;
        private System.Windows.Forms.TextBox chargeStone;
        private System.Windows.Forms.Button sellThreeStars;
        private System.Windows.Forms.Button output;
        private System.Windows.Forms.TextBox versionLabel;
        private System.Windows.Forms.PictureBox face;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox name;
    }
}

