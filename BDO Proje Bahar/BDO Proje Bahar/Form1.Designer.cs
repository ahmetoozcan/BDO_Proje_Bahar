namespace BDO_Proje_Bahar {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Tabs = new System.Windows.Forms.TabControl();
            this.TeslaTab = new System.Windows.Forms.TabPage();
            this.TeslaStopButton = new System.Windows.Forms.Button();
            this.TeslaStopChargingButton = new System.Windows.Forms.Button();
            this.TeslaStartChargingButton = new System.Windows.Forms.Button();
            this.TeslaStartButton = new System.Windows.Forms.Button();
            this.TeslaProgressBar = new CircularProgressBar.CircularProgressBar();
            this.TeslaPictureBox = new System.Windows.Forms.PictureBox();
            this.MercedesTab = new System.Windows.Forms.TabPage();
            this.MercedesProgressBar = new CircularProgressBar.CircularProgressBar();
            this.MercedesPictureBox = new System.Windows.Forms.PictureBox();
            this.ToyotaTab = new System.Windows.Forms.TabPage();
            this.ToyotaProgressBar = new CircularProgressBar.CircularProgressBar();
            this.ToyotaPictureBox = new System.Windows.Forms.PictureBox();
            this.MerkezTab = new System.Windows.Forms.TabPage();
            this.ŞarjGroupBoxA = new System.Windows.Forms.GroupBox();
            this.ŞarjGroupBoxB = new System.Windows.Forms.GroupBox();
            this.ŞarjİstasyonuALabel = new System.Windows.Forms.Label();
            this.ŞarjİstasyonuBLabel = new System.Windows.Forms.Label();
            this.TeslaDisconnectChargeButton = new System.Windows.Forms.Button();
            this.TeslaConnectChargeButton = new System.Windows.Forms.Button();
            this.MercedesConnectChargeButton = new System.Windows.Forms.Button();
            this.MercedesDisconnectChargeButton = new System.Windows.Forms.Button();
            this.MercedesStopButton = new System.Windows.Forms.Button();
            this.MercedesStopChargingButton = new System.Windows.Forms.Button();
            this.MercedesStartChargingButton = new System.Windows.Forms.Button();
            this.MercedesStartButton = new System.Windows.Forms.Button();
            this.ToyotaConnectChargeButton = new System.Windows.Forms.Button();
            this.ToyotaDisconnectChargeButton = new System.Windows.Forms.Button();
            this.ToyotaStopButton = new System.Windows.Forms.Button();
            this.ToyotaStopChargingButton = new System.Windows.Forms.Button();
            this.ToyotaStartChargingButton = new System.Windows.Forms.Button();
            this.ToyotaStartButton = new System.Windows.Forms.Button();
            this.ToyotaCarStatusLabel = new System.Windows.Forms.Label();
            this.MercedesCarStatusLabel = new System.Windows.Forms.Label();
            this.TeslaCarStatusLabel = new System.Windows.Forms.Label();
            this.Tabs.SuspendLayout();
            this.TeslaTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeslaPictureBox)).BeginInit();
            this.MercedesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MercedesPictureBox)).BeginInit();
            this.ToyotaTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToyotaPictureBox)).BeginInit();
            this.MerkezTab.SuspendLayout();
            this.ŞarjGroupBoxA.SuspendLayout();
            this.ŞarjGroupBoxB.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.TeslaTab);
            this.Tabs.Controls.Add(this.MercedesTab);
            this.Tabs.Controls.Add(this.ToyotaTab);
            this.Tabs.Controls.Add(this.MerkezTab);
            this.Tabs.Location = new System.Drawing.Point(-4, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(988, 534);
            this.Tabs.TabIndex = 0;
            // 
            // TeslaTab
            // 
            this.TeslaTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.TeslaTab.Controls.Add(this.TeslaCarStatusLabel);
            this.TeslaTab.Controls.Add(this.TeslaConnectChargeButton);
            this.TeslaTab.Controls.Add(this.TeslaDisconnectChargeButton);
            this.TeslaTab.Controls.Add(this.TeslaStopButton);
            this.TeslaTab.Controls.Add(this.TeslaStopChargingButton);
            this.TeslaTab.Controls.Add(this.TeslaStartChargingButton);
            this.TeslaTab.Controls.Add(this.TeslaStartButton);
            this.TeslaTab.Controls.Add(this.TeslaProgressBar);
            this.TeslaTab.Controls.Add(this.TeslaPictureBox);
            this.TeslaTab.Location = new System.Drawing.Point(4, 22);
            this.TeslaTab.Name = "TeslaTab";
            this.TeslaTab.Padding = new System.Windows.Forms.Padding(3);
            this.TeslaTab.Size = new System.Drawing.Size(980, 508);
            this.TeslaTab.TabIndex = 0;
            this.TeslaTab.Text = "Tesla Model 3";
            // 
            // TeslaStopButton
            // 
            this.TeslaStopButton.Location = new System.Drawing.Point(809, 215);
            this.TeslaStopButton.Name = "TeslaStopButton";
            this.TeslaStopButton.Size = new System.Drawing.Size(152, 78);
            this.TeslaStopButton.TabIndex = 5;
            this.TeslaStopButton.Text = "Simülasyonu Kapat";
            this.TeslaStopButton.UseVisualStyleBackColor = true;
            this.TeslaStopButton.Click += new System.EventHandler(this.button10_Click);
            // 
            // TeslaStopChargingButton
            // 
            this.TeslaStopChargingButton.Location = new System.Drawing.Point(651, 215);
            this.TeslaStopChargingButton.Name = "TeslaStopChargingButton";
            this.TeslaStopChargingButton.Size = new System.Drawing.Size(152, 78);
            this.TeslaStopChargingButton.TabIndex = 4;
            this.TeslaStopChargingButton.Text = "Şarjı Durdur";
            this.TeslaStopChargingButton.UseVisualStyleBackColor = true;
            this.TeslaStopChargingButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // TeslaStartChargingButton
            // 
            this.TeslaStartChargingButton.Location = new System.Drawing.Point(493, 215);
            this.TeslaStartChargingButton.Name = "TeslaStartChargingButton";
            this.TeslaStartChargingButton.Size = new System.Drawing.Size(152, 78);
            this.TeslaStartChargingButton.TabIndex = 3;
            this.TeslaStartChargingButton.Text = "Şarjı Başlat";
            this.TeslaStartChargingButton.UseVisualStyleBackColor = true;
            this.TeslaStartChargingButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // TeslaStartButton
            // 
            this.TeslaStartButton.Location = new System.Drawing.Point(19, 215);
            this.TeslaStartButton.Name = "TeslaStartButton";
            this.TeslaStartButton.Size = new System.Drawing.Size(152, 78);
            this.TeslaStartButton.TabIndex = 2;
            this.TeslaStartButton.Text = "Simülasyonu Çalıştır";
            this.TeslaStartButton.UseVisualStyleBackColor = true;
            this.TeslaStartButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // TeslaProgressBar
            // 
            this.TeslaProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.TeslaProgressBar.AnimationSpeed = 500;
            this.TeslaProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.TeslaProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TeslaProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TeslaProgressBar.InnerColor = System.Drawing.Color.White;
            this.TeslaProgressBar.InnerMargin = 2;
            this.TeslaProgressBar.InnerWidth = -1;
            this.TeslaProgressBar.Location = new System.Drawing.Point(557, 346);
            this.TeslaProgressBar.MarqueeAnimationSpeed = 2000;
            this.TeslaProgressBar.Name = "TeslaProgressBar";
            this.TeslaProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.TeslaProgressBar.OuterMargin = -25;
            this.TeslaProgressBar.OuterWidth = 26;
            this.TeslaProgressBar.ProgressColor = System.Drawing.Color.Green;
            this.TeslaProgressBar.ProgressWidth = 25;
            this.TeslaProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.TeslaProgressBar.Size = new System.Drawing.Size(150, 150);
            this.TeslaProgressBar.StartAngle = 270;
            this.TeslaProgressBar.SubscriptColor = System.Drawing.Color.White;
            this.TeslaProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.TeslaProgressBar.SubscriptText = "";
            this.TeslaProgressBar.SuperscriptColor = System.Drawing.Color.White;
            this.TeslaProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.TeslaProgressBar.SuperscriptText = "";
            this.TeslaProgressBar.TabIndex = 1;
            this.TeslaProgressBar.Text = "%67";
            this.TeslaProgressBar.TextMargin = new System.Windows.Forms.Padding(5);
            this.TeslaProgressBar.Value = 68;
            // 
            // TeslaPictureBox
            // 
            this.TeslaPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TeslaPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("TeslaPictureBox.Image")));
            this.TeslaPictureBox.InitialImage = null;
            this.TeslaPictureBox.Location = new System.Drawing.Point(347, 6);
            this.TeslaPictureBox.Name = "TeslaPictureBox";
            this.TeslaPictureBox.Size = new System.Drawing.Size(270, 150);
            this.TeslaPictureBox.TabIndex = 0;
            this.TeslaPictureBox.TabStop = false;
            this.TeslaPictureBox.WaitOnLoad = true;
            // 
            // MercedesTab
            // 
            this.MercedesTab.Controls.Add(this.MercedesCarStatusLabel);
            this.MercedesTab.Controls.Add(this.MercedesConnectChargeButton);
            this.MercedesTab.Controls.Add(this.MercedesDisconnectChargeButton);
            this.MercedesTab.Controls.Add(this.MercedesStopButton);
            this.MercedesTab.Controls.Add(this.MercedesStopChargingButton);
            this.MercedesTab.Controls.Add(this.MercedesStartChargingButton);
            this.MercedesTab.Controls.Add(this.MercedesStartButton);
            this.MercedesTab.Controls.Add(this.MercedesProgressBar);
            this.MercedesTab.Controls.Add(this.MercedesPictureBox);
            this.MercedesTab.Location = new System.Drawing.Point(4, 22);
            this.MercedesTab.Name = "MercedesTab";
            this.MercedesTab.Padding = new System.Windows.Forms.Padding(3);
            this.MercedesTab.Size = new System.Drawing.Size(980, 508);
            this.MercedesTab.TabIndex = 1;
            this.MercedesTab.Text = "Mercedes Smart Fortwo";
            this.MercedesTab.UseVisualStyleBackColor = true;
            // 
            // MercedesProgressBar
            // 
            this.MercedesProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.MercedesProgressBar.AnimationSpeed = 500;
            this.MercedesProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.MercedesProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MercedesProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MercedesProgressBar.InnerColor = System.Drawing.Color.White;
            this.MercedesProgressBar.InnerMargin = 2;
            this.MercedesProgressBar.InnerWidth = -1;
            this.MercedesProgressBar.Location = new System.Drawing.Point(557, 346);
            this.MercedesProgressBar.MarqueeAnimationSpeed = 2000;
            this.MercedesProgressBar.Name = "MercedesProgressBar";
            this.MercedesProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.MercedesProgressBar.OuterMargin = -25;
            this.MercedesProgressBar.OuterWidth = 26;
            this.MercedesProgressBar.ProgressColor = System.Drawing.Color.Green;
            this.MercedesProgressBar.ProgressWidth = 25;
            this.MercedesProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.MercedesProgressBar.Size = new System.Drawing.Size(150, 150);
            this.MercedesProgressBar.StartAngle = 270;
            this.MercedesProgressBar.SubscriptColor = System.Drawing.Color.White;
            this.MercedesProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.MercedesProgressBar.SubscriptText = "";
            this.MercedesProgressBar.SuperscriptColor = System.Drawing.Color.White;
            this.MercedesProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.MercedesProgressBar.SuperscriptText = "";
            this.MercedesProgressBar.TabIndex = 2;
            this.MercedesProgressBar.Text = "%67";
            this.MercedesProgressBar.TextMargin = new System.Windows.Forms.Padding(5);
            this.MercedesProgressBar.Value = 68;
            // 
            // MercedesPictureBox
            // 
            this.MercedesPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MercedesPictureBox.Image")));
            this.MercedesPictureBox.InitialImage = null;
            this.MercedesPictureBox.Location = new System.Drawing.Point(347, 6);
            this.MercedesPictureBox.Name = "MercedesPictureBox";
            this.MercedesPictureBox.Size = new System.Drawing.Size(270, 150);
            this.MercedesPictureBox.TabIndex = 1;
            this.MercedesPictureBox.TabStop = false;
            this.MercedesPictureBox.WaitOnLoad = true;
            // 
            // ToyotaTab
            // 
            this.ToyotaTab.Controls.Add(this.ToyotaCarStatusLabel);
            this.ToyotaTab.Controls.Add(this.ToyotaConnectChargeButton);
            this.ToyotaTab.Controls.Add(this.ToyotaDisconnectChargeButton);
            this.ToyotaTab.Controls.Add(this.ToyotaStopButton);
            this.ToyotaTab.Controls.Add(this.ToyotaStopChargingButton);
            this.ToyotaTab.Controls.Add(this.ToyotaStartChargingButton);
            this.ToyotaTab.Controls.Add(this.ToyotaStartButton);
            this.ToyotaTab.Controls.Add(this.ToyotaProgressBar);
            this.ToyotaTab.Controls.Add(this.ToyotaPictureBox);
            this.ToyotaTab.Location = new System.Drawing.Point(4, 22);
            this.ToyotaTab.Name = "ToyotaTab";
            this.ToyotaTab.Padding = new System.Windows.Forms.Padding(3);
            this.ToyotaTab.Size = new System.Drawing.Size(980, 508);
            this.ToyotaTab.TabIndex = 2;
            this.ToyotaTab.Text = "Toyota BZ4X";
            this.ToyotaTab.UseVisualStyleBackColor = true;
            // 
            // ToyotaProgressBar
            // 
            this.ToyotaProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.ToyotaProgressBar.AnimationSpeed = 500;
            this.ToyotaProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.ToyotaProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ToyotaProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ToyotaProgressBar.InnerColor = System.Drawing.Color.White;
            this.ToyotaProgressBar.InnerMargin = 2;
            this.ToyotaProgressBar.InnerWidth = -1;
            this.ToyotaProgressBar.Location = new System.Drawing.Point(557, 346);
            this.ToyotaProgressBar.MarqueeAnimationSpeed = 2000;
            this.ToyotaProgressBar.Name = "ToyotaProgressBar";
            this.ToyotaProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.ToyotaProgressBar.OuterMargin = -25;
            this.ToyotaProgressBar.OuterWidth = 26;
            this.ToyotaProgressBar.ProgressColor = System.Drawing.Color.Green;
            this.ToyotaProgressBar.ProgressWidth = 25;
            this.ToyotaProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.ToyotaProgressBar.Size = new System.Drawing.Size(150, 150);
            this.ToyotaProgressBar.StartAngle = 270;
            this.ToyotaProgressBar.SubscriptColor = System.Drawing.Color.White;
            this.ToyotaProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.ToyotaProgressBar.SubscriptText = "";
            this.ToyotaProgressBar.SuperscriptColor = System.Drawing.Color.White;
            this.ToyotaProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.ToyotaProgressBar.SuperscriptText = "";
            this.ToyotaProgressBar.TabIndex = 2;
            this.ToyotaProgressBar.Text = "%67";
            this.ToyotaProgressBar.TextMargin = new System.Windows.Forms.Padding(5);
            this.ToyotaProgressBar.Value = 68;
            // 
            // ToyotaPictureBox
            // 
            this.ToyotaPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ToyotaPictureBox.Image")));
            this.ToyotaPictureBox.InitialImage = null;
            this.ToyotaPictureBox.Location = new System.Drawing.Point(347, 6);
            this.ToyotaPictureBox.Name = "ToyotaPictureBox";
            this.ToyotaPictureBox.Size = new System.Drawing.Size(270, 150);
            this.ToyotaPictureBox.TabIndex = 1;
            this.ToyotaPictureBox.TabStop = false;
            this.ToyotaPictureBox.WaitOnLoad = true;
            // 
            // MerkezTab
            // 
            this.MerkezTab.Controls.Add(this.ŞarjGroupBoxB);
            this.MerkezTab.Controls.Add(this.ŞarjGroupBoxA);
            this.MerkezTab.Location = new System.Drawing.Point(4, 22);
            this.MerkezTab.Name = "MerkezTab";
            this.MerkezTab.Size = new System.Drawing.Size(980, 508);
            this.MerkezTab.TabIndex = 3;
            this.MerkezTab.Text = "Merkez";
            this.MerkezTab.UseVisualStyleBackColor = true;
            // 
            // ŞarjGroupBoxA
            // 
            this.ŞarjGroupBoxA.Controls.Add(this.ŞarjİstasyonuALabel);
            this.ŞarjGroupBoxA.Location = new System.Drawing.Point(3, 3);
            this.ŞarjGroupBoxA.Name = "ŞarjGroupBoxA";
            this.ŞarjGroupBoxA.Size = new System.Drawing.Size(485, 505);
            this.ŞarjGroupBoxA.TabIndex = 1;
            this.ŞarjGroupBoxA.TabStop = false;
            this.ŞarjGroupBoxA.Text = "Şarj İstasyonu A";
            this.ŞarjGroupBoxA.UseCompatibleTextRendering = true;
            // 
            // ŞarjGroupBoxB
            // 
            this.ŞarjGroupBoxB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ŞarjGroupBoxB.Controls.Add(this.ŞarjİstasyonuBLabel);
            this.ŞarjGroupBoxB.Location = new System.Drawing.Point(485, 3);
            this.ŞarjGroupBoxB.Name = "ŞarjGroupBoxB";
            this.ŞarjGroupBoxB.Size = new System.Drawing.Size(489, 505);
            this.ŞarjGroupBoxB.TabIndex = 2;
            this.ŞarjGroupBoxB.TabStop = false;
            this.ŞarjGroupBoxB.Text = "Şarj İstasyonu B";
            this.ŞarjGroupBoxB.UseCompatibleTextRendering = true;
            // 
            // ŞarjİstasyonuALabel
            // 
            this.ŞarjİstasyonuALabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ŞarjİstasyonuALabel.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ŞarjİstasyonuALabel.Location = new System.Drawing.Point(67, 79);
            this.ŞarjİstasyonuALabel.Name = "ŞarjİstasyonuALabel";
            this.ŞarjİstasyonuALabel.Size = new System.Drawing.Size(350, 347);
            this.ŞarjİstasyonuALabel.TabIndex = 0;
            this.ŞarjİstasyonuALabel.Text = "label1";
            this.ŞarjİstasyonuALabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ŞarjİstasyonuALabel.UseCompatibleTextRendering = true;
            // 
            // ŞarjİstasyonuBLabel
            // 
            this.ŞarjİstasyonuBLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ŞarjİstasyonuBLabel.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ŞarjİstasyonuBLabel.Location = new System.Drawing.Point(69, 79);
            this.ŞarjİstasyonuBLabel.Name = "ŞarjİstasyonuBLabel";
            this.ŞarjİstasyonuBLabel.Size = new System.Drawing.Size(350, 347);
            this.ŞarjİstasyonuBLabel.TabIndex = 1;
            this.ŞarjİstasyonuBLabel.Text = "label1";
            this.ŞarjİstasyonuBLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ŞarjİstasyonuBLabel.UseCompatibleTextRendering = true;
            // 
            // TeslaDisconnectChargeButton
            // 
            this.TeslaDisconnectChargeButton.Location = new System.Drawing.Point(335, 215);
            this.TeslaDisconnectChargeButton.Name = "TeslaDisconnectChargeButton";
            this.TeslaDisconnectChargeButton.Size = new System.Drawing.Size(152, 78);
            this.TeslaDisconnectChargeButton.TabIndex = 6;
            this.TeslaDisconnectChargeButton.Text = "Şarj Cihazını Çıkar";
            this.TeslaDisconnectChargeButton.UseVisualStyleBackColor = true;
            // 
            // TeslaConnectChargeButton
            // 
            this.TeslaConnectChargeButton.Location = new System.Drawing.Point(177, 215);
            this.TeslaConnectChargeButton.Name = "TeslaConnectChargeButton";
            this.TeslaConnectChargeButton.Size = new System.Drawing.Size(152, 78);
            this.TeslaConnectChargeButton.TabIndex = 7;
            this.TeslaConnectChargeButton.Text = "Şarja Cihazını Bağla";
            this.TeslaConnectChargeButton.UseVisualStyleBackColor = true;
            // 
            // MercedesConnectChargeButton
            // 
            this.MercedesConnectChargeButton.Location = new System.Drawing.Point(177, 215);
            this.MercedesConnectChargeButton.Name = "MercedesConnectChargeButton";
            this.MercedesConnectChargeButton.Size = new System.Drawing.Size(152, 78);
            this.MercedesConnectChargeButton.TabIndex = 13;
            this.MercedesConnectChargeButton.Text = "Şarja Cihazını Bağla";
            this.MercedesConnectChargeButton.UseVisualStyleBackColor = true;
            // 
            // MercedesDisconnectChargeButton
            // 
            this.MercedesDisconnectChargeButton.Location = new System.Drawing.Point(335, 215);
            this.MercedesDisconnectChargeButton.Name = "MercedesDisconnectChargeButton";
            this.MercedesDisconnectChargeButton.Size = new System.Drawing.Size(152, 78);
            this.MercedesDisconnectChargeButton.TabIndex = 12;
            this.MercedesDisconnectChargeButton.Text = "Şarj Cihazını Çıkar";
            this.MercedesDisconnectChargeButton.UseVisualStyleBackColor = true;
            // 
            // MercedesStopButton
            // 
            this.MercedesStopButton.Location = new System.Drawing.Point(809, 215);
            this.MercedesStopButton.Name = "MercedesStopButton";
            this.MercedesStopButton.Size = new System.Drawing.Size(152, 78);
            this.MercedesStopButton.TabIndex = 11;
            this.MercedesStopButton.Text = "Simülasyonu Kapat";
            this.MercedesStopButton.UseVisualStyleBackColor = true;
            // 
            // MercedesStopChargingButton
            // 
            this.MercedesStopChargingButton.Location = new System.Drawing.Point(651, 215);
            this.MercedesStopChargingButton.Name = "MercedesStopChargingButton";
            this.MercedesStopChargingButton.Size = new System.Drawing.Size(152, 78);
            this.MercedesStopChargingButton.TabIndex = 10;
            this.MercedesStopChargingButton.Text = "Şarjı Durdur";
            this.MercedesStopChargingButton.UseVisualStyleBackColor = true;
            // 
            // MercedesStartChargingButton
            // 
            this.MercedesStartChargingButton.Location = new System.Drawing.Point(493, 215);
            this.MercedesStartChargingButton.Name = "MercedesStartChargingButton";
            this.MercedesStartChargingButton.Size = new System.Drawing.Size(152, 78);
            this.MercedesStartChargingButton.TabIndex = 9;
            this.MercedesStartChargingButton.Text = "Şarjı Başlat";
            this.MercedesStartChargingButton.UseVisualStyleBackColor = true;
            // 
            // MercedesStartButton
            // 
            this.MercedesStartButton.Location = new System.Drawing.Point(19, 215);
            this.MercedesStartButton.Name = "MercedesStartButton";
            this.MercedesStartButton.Size = new System.Drawing.Size(152, 78);
            this.MercedesStartButton.TabIndex = 8;
            this.MercedesStartButton.Text = "Simülasyonu Çalıştır";
            this.MercedesStartButton.UseVisualStyleBackColor = true;
            // 
            // ToyotaConnectChargeButton
            // 
            this.ToyotaConnectChargeButton.Location = new System.Drawing.Point(177, 215);
            this.ToyotaConnectChargeButton.Name = "ToyotaConnectChargeButton";
            this.ToyotaConnectChargeButton.Size = new System.Drawing.Size(152, 78);
            this.ToyotaConnectChargeButton.TabIndex = 13;
            this.ToyotaConnectChargeButton.Text = "Şarja Cihazını Bağla";
            this.ToyotaConnectChargeButton.UseVisualStyleBackColor = true;
            // 
            // ToyotaDisconnectChargeButton
            // 
            this.ToyotaDisconnectChargeButton.Location = new System.Drawing.Point(335, 215);
            this.ToyotaDisconnectChargeButton.Name = "ToyotaDisconnectChargeButton";
            this.ToyotaDisconnectChargeButton.Size = new System.Drawing.Size(152, 78);
            this.ToyotaDisconnectChargeButton.TabIndex = 12;
            this.ToyotaDisconnectChargeButton.Text = "Şarj Cihazını Çıkar";
            this.ToyotaDisconnectChargeButton.UseVisualStyleBackColor = true;
            // 
            // ToyotaStopButton
            // 
            this.ToyotaStopButton.Location = new System.Drawing.Point(809, 215);
            this.ToyotaStopButton.Name = "ToyotaStopButton";
            this.ToyotaStopButton.Size = new System.Drawing.Size(152, 78);
            this.ToyotaStopButton.TabIndex = 11;
            this.ToyotaStopButton.Text = "Simülasyonu Kapat";
            this.ToyotaStopButton.UseVisualStyleBackColor = true;
            // 
            // ToyotaStopChargingButton
            // 
            this.ToyotaStopChargingButton.Location = new System.Drawing.Point(651, 215);
            this.ToyotaStopChargingButton.Name = "ToyotaStopChargingButton";
            this.ToyotaStopChargingButton.Size = new System.Drawing.Size(152, 78);
            this.ToyotaStopChargingButton.TabIndex = 10;
            this.ToyotaStopChargingButton.Text = "Şarjı Durdur";
            this.ToyotaStopChargingButton.UseVisualStyleBackColor = true;
            // 
            // ToyotaStartChargingButton
            // 
            this.ToyotaStartChargingButton.Location = new System.Drawing.Point(493, 215);
            this.ToyotaStartChargingButton.Name = "ToyotaStartChargingButton";
            this.ToyotaStartChargingButton.Size = new System.Drawing.Size(152, 78);
            this.ToyotaStartChargingButton.TabIndex = 9;
            this.ToyotaStartChargingButton.Text = "Şarjı Başlat";
            this.ToyotaStartChargingButton.UseVisualStyleBackColor = true;
            // 
            // ToyotaStartButton
            // 
            this.ToyotaStartButton.Location = new System.Drawing.Point(19, 215);
            this.ToyotaStartButton.Name = "ToyotaStartButton";
            this.ToyotaStartButton.Size = new System.Drawing.Size(152, 78);
            this.ToyotaStartButton.TabIndex = 8;
            this.ToyotaStartButton.Text = "Simülasyonu Çalıştır";
            this.ToyotaStartButton.UseVisualStyleBackColor = true;
            // 
            // ToyotaCarStatusLabel
            // 
            this.ToyotaCarStatusLabel.AutoSize = true;
            this.ToyotaCarStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ToyotaCarStatusLabel.Location = new System.Drawing.Point(273, 396);
            this.ToyotaCarStatusLabel.Name = "ToyotaCarStatusLabel";
            this.ToyotaCarStatusLabel.Size = new System.Drawing.Size(158, 31);
            this.ToyotaCarStatusLabel.TabIndex = 14;
            this.ToyotaCarStatusLabel.Text = "Car Status: ";
            // 
            // MercedesCarStatusLabel
            // 
            this.MercedesCarStatusLabel.AutoSize = true;
            this.MercedesCarStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MercedesCarStatusLabel.Location = new System.Drawing.Point(273, 396);
            this.MercedesCarStatusLabel.Name = "MercedesCarStatusLabel";
            this.MercedesCarStatusLabel.Size = new System.Drawing.Size(158, 31);
            this.MercedesCarStatusLabel.TabIndex = 15;
            this.MercedesCarStatusLabel.Text = "Car Status: ";
            // 
            // TeslaCarStatusLabel
            // 
            this.TeslaCarStatusLabel.AutoSize = true;
            this.TeslaCarStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TeslaCarStatusLabel.Location = new System.Drawing.Point(273, 396);
            this.TeslaCarStatusLabel.Name = "TeslaCarStatusLabel";
            this.TeslaCarStatusLabel.Size = new System.Drawing.Size(158, 31);
            this.TeslaCarStatusLabel.TabIndex = 15;
            this.TeslaCarStatusLabel.Text = "Car Status: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(976, 530);
            this.Controls.Add(this.Tabs);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EV Charger Tracking Program";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Tabs.ResumeLayout(false);
            this.TeslaTab.ResumeLayout(false);
            this.TeslaTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeslaPictureBox)).EndInit();
            this.MercedesTab.ResumeLayout(false);
            this.MercedesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MercedesPictureBox)).EndInit();
            this.ToyotaTab.ResumeLayout(false);
            this.ToyotaTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToyotaPictureBox)).EndInit();
            this.MerkezTab.ResumeLayout(false);
            this.ŞarjGroupBoxA.ResumeLayout(false);
            this.ŞarjGroupBoxB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage TeslaTab;
        private System.Windows.Forms.TabPage MercedesTab;
        private System.Windows.Forms.TabPage ToyotaTab;
        private System.Windows.Forms.PictureBox TeslaPictureBox;
        private System.Windows.Forms.PictureBox MercedesPictureBox;
        private System.Windows.Forms.PictureBox ToyotaPictureBox;
        private CircularProgressBar.CircularProgressBar TeslaProgressBar;
        private System.Windows.Forms.Button TeslaStartButton;
        private System.Windows.Forms.Button TeslaStopChargingButton;
        private System.Windows.Forms.Button TeslaStartChargingButton;
        private CircularProgressBar.CircularProgressBar MercedesProgressBar;
        private CircularProgressBar.CircularProgressBar ToyotaProgressBar;
        private System.Windows.Forms.Button TeslaStopButton;
        private System.Windows.Forms.TabPage MerkezTab;
        private System.Windows.Forms.GroupBox ŞarjGroupBoxB;
        private System.Windows.Forms.GroupBox ŞarjGroupBoxA;
        private System.Windows.Forms.Label ŞarjİstasyonuBLabel;
        private System.Windows.Forms.Label ŞarjİstasyonuALabel;
        private System.Windows.Forms.Button TeslaConnectChargeButton;
        private System.Windows.Forms.Button TeslaDisconnectChargeButton;
        private System.Windows.Forms.Button MercedesConnectChargeButton;
        private System.Windows.Forms.Button MercedesDisconnectChargeButton;
        private System.Windows.Forms.Button MercedesStopButton;
        private System.Windows.Forms.Button MercedesStopChargingButton;
        private System.Windows.Forms.Button MercedesStartChargingButton;
        private System.Windows.Forms.Button MercedesStartButton;
        private System.Windows.Forms.Button ToyotaConnectChargeButton;
        private System.Windows.Forms.Button ToyotaDisconnectChargeButton;
        private System.Windows.Forms.Button ToyotaStopButton;
        private System.Windows.Forms.Button ToyotaStopChargingButton;
        private System.Windows.Forms.Button ToyotaStartChargingButton;
        private System.Windows.Forms.Button ToyotaStartButton;
        private System.Windows.Forms.Label TeslaCarStatusLabel;
        private System.Windows.Forms.Label MercedesCarStatusLabel;
        private System.Windows.Forms.Label ToyotaCarStatusLabel;
    }
}

