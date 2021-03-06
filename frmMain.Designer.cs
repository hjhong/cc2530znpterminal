namespace CC2530ZNP
{
  partial class mForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mForm));
            this.txtSendData = new System.Windows.Forms.TextBox();
            this.lblSend = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.rbHex = new System.Windows.Forms.RadioButton();
            this.rbText = new System.Windows.Forms.RadioButton();
            this.gbMode = new System.Windows.Forms.GroupBox();
            this.lblComPort = new System.Windows.Forms.Label();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.lblParity = new System.Windows.Forms.Label();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.lblDataBits = new System.Windows.Forms.Label();
            this.cmbDataBits = new System.Windows.Forms.ComboBox();
            this.lblStopBits = new System.Windows.Forms.Label();
            this.cmbStopBits = new System.Windows.Forms.ComboBox();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.gbPortSettings = new System.Windows.Forms.GroupBox();
            this.lnkAbout = new System.Windows.Forms.LinkLabel();
            this.gbCC2530ZNP = new System.Windows.Forms.GroupBox();
            this.btnGetDeviceInfo = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnVersion = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStartAPP = new System.Windows.Forms.Button();
            this.gbZNPConfig = new System.Windows.Forms.GroupBox();
            this.txtPanID = new System.Windows.Forms.TextBox();
            this.cmbChannel = new System.Windows.Forms.ComboBox();
            this.btnLogicTypeRead = new System.Windows.Forms.Button();
            this.btnLogicTypeWrite = new System.Windows.Forms.Button();
            this.btnPanIDRead = new System.Windows.Forms.Button();
            this.btnPanIDWrite = new System.Windows.Forms.Button();
            this.btnChannRead = new System.Windows.Forms.Button();
            this.btnChannWrite = new System.Windows.Forms.Button();
            this.lblChannel = new System.Windows.Forms.Label();
            this.cmbLogicType = new System.Windows.Forms.ComboBox();
            this.lblLogicType = new System.Windows.Forms.Label();
            this.lblPanID = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.gbAddress = new System.Windows.Forms.GroupBox();
            this.cmbNwkAddr = new System.Windows.Forms.ComboBox();
            this.lblNwkAddr = new System.Windows.Forms.Label();
            this.gbLight = new System.Windows.Forms.GroupBox();
            this.btnLightON = new System.Windows.Forms.Button();
            this.btnLightOFF = new System.Windows.Forms.Button();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbConsole = new System.Windows.Forms.RichTextBox();
            this.gbMode.SuspendLayout();
            this.gbPortSettings.SuspendLayout();
            this.gbCC2530ZNP.SuspendLayout();
            this.gbZNPConfig.SuspendLayout();
            this.gbAddress.SuspendLayout();
            this.gbLight.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSendData
            // 
            this.txtSendData.Location = new System.Drawing.Point(102, 473);
            this.txtSendData.Name = "txtSendData";
            this.txtSendData.Size = new System.Drawing.Size(290, 21);
            this.txtSendData.TabIndex = 2;
            this.txtSendData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSendData_KeyDown);
            this.txtSendData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSendData_KeyPress);
            // 
            // lblSend
            // 
            this.lblSend.AutoSize = true;
            this.lblSend.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSend.Location = new System.Drawing.Point(24, 477);
            this.lblSend.Name = "lblSend";
            this.lblSend.Size = new System.Drawing.Size(75, 12);
            this.lblSend.TabIndex = 1;
            this.lblSend.Text = "Send &Data:";
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSend.Location = new System.Drawing.Point(398, 468);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(164, 31);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // cmbPortName
            // 
            this.cmbPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPortName.FormattingEnabled = true;
            this.cmbPortName.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6"});
            this.cmbPortName.Location = new System.Drawing.Point(13, 35);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(67, 20);
            this.cmbPortName.TabIndex = 1;
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "28800",
            "36000",
            "57600",
            "115200"});
            this.cmbBaudRate.Location = new System.Drawing.Point(86, 35);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(69, 20);
            this.cmbBaudRate.TabIndex = 3;
            this.cmbBaudRate.Validating += new System.ComponentModel.CancelEventHandler(this.cmbBaudRate_Validating);
            // 
            // rbHex
            // 
            this.rbHex.AutoSize = true;
            this.rbHex.Checked = true;
            this.rbHex.Location = new System.Drawing.Point(13, 20);
            this.rbHex.Name = "rbHex";
            this.rbHex.Size = new System.Drawing.Size(44, 16);
            this.rbHex.TabIndex = 1;
            this.rbHex.TabStop = true;
            this.rbHex.Text = "Hex";
            this.rbHex.CheckedChanged += new System.EventHandler(this.rbHex_CheckedChanged);
            // 
            // rbText
            // 
            this.rbText.AutoSize = true;
            this.rbText.Location = new System.Drawing.Point(13, 42);
            this.rbText.Name = "rbText";
            this.rbText.Size = new System.Drawing.Size(51, 16);
            this.rbText.TabIndex = 0;
            this.rbText.Text = "Text";
            this.rbText.CheckedChanged += new System.EventHandler(this.rbText_CheckedChanged);
            // 
            // gbMode
            // 
            this.gbMode.Controls.Add(this.rbText);
            this.gbMode.Controls.Add(this.rbHex);
            this.gbMode.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbMode.Location = new System.Drawing.Point(398, 390);
            this.gbMode.Name = "gbMode";
            this.gbMode.Size = new System.Drawing.Size(89, 68);
            this.gbMode.TabIndex = 5;
            this.gbMode.TabStop = false;
            this.gbMode.Text = "Data &Mode";
            // 
            // lblComPort
            // 
            this.lblComPort.AutoSize = true;
            this.lblComPort.Location = new System.Drawing.Point(13, 17);
            this.lblComPort.Name = "lblComPort";
            this.lblComPort.Size = new System.Drawing.Size(68, 12);
            this.lblComPort.TabIndex = 0;
            this.lblComPort.Text = "COM Port:";
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Location = new System.Drawing.Point(84, 17);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(75, 12);
            this.lblBaudRate.TabIndex = 2;
            this.lblBaudRate.Text = "Baud Rate:";
            // 
            // lblParity
            // 
            this.lblParity.AutoSize = true;
            this.lblParity.Location = new System.Drawing.Point(161, 17);
            this.lblParity.Name = "lblParity";
            this.lblParity.Size = new System.Drawing.Size(54, 12);
            this.lblParity.TabIndex = 4;
            this.lblParity.Text = "Parity:";
            // 
            // cmbParity
            // 
            this.cmbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.cmbParity.Location = new System.Drawing.Point(163, 35);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(60, 20);
            this.cmbParity.TabIndex = 5;
            // 
            // lblDataBits
            // 
            this.lblDataBits.AutoSize = true;
            this.lblDataBits.Location = new System.Drawing.Point(227, 17);
            this.lblDataBits.Name = "lblDataBits";
            this.lblDataBits.Size = new System.Drawing.Size(75, 12);
            this.lblDataBits.TabIndex = 6;
            this.lblDataBits.Text = "Data Bits:";
            // 
            // cmbDataBits
            // 
            this.cmbDataBits.FormattingEnabled = true;
            this.cmbDataBits.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.cmbDataBits.Location = new System.Drawing.Point(229, 35);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(60, 20);
            this.cmbDataBits.TabIndex = 7;
            this.cmbDataBits.Validating += new System.ComponentModel.CancelEventHandler(this.cmbDataBits_Validating);
            // 
            // lblStopBits
            // 
            this.lblStopBits.AutoSize = true;
            this.lblStopBits.Location = new System.Drawing.Point(298, 17);
            this.lblStopBits.Name = "lblStopBits";
            this.lblStopBits.Size = new System.Drawing.Size(75, 12);
            this.lblStopBits.TabIndex = 8;
            this.lblStopBits.Text = "Stop Bits:";
            // 
            // cmbStopBits
            // 
            this.cmbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStopBits.FormattingEnabled = true;
            this.cmbStopBits.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbStopBits.Location = new System.Drawing.Point(298, 35);
            this.cmbStopBits.Name = "cmbStopBits";
            this.cmbStopBits.Size = new System.Drawing.Size(65, 20);
            this.cmbStopBits.TabIndex = 9;
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenPort.Location = new System.Drawing.Point(493, 396);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(69, 62);
            this.btnOpenPort.TabIndex = 6;
            this.btnOpenPort.Text = "&Open";
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // gbPortSettings
            // 
            this.gbPortSettings.Controls.Add(this.lblComPort);
            this.gbPortSettings.Controls.Add(this.cmbPortName);
            this.gbPortSettings.Controls.Add(this.lblStopBits);
            this.gbPortSettings.Controls.Add(this.cmbBaudRate);
            this.gbPortSettings.Controls.Add(this.cmbStopBits);
            this.gbPortSettings.Controls.Add(this.lblBaudRate);
            this.gbPortSettings.Controls.Add(this.lblDataBits);
            this.gbPortSettings.Controls.Add(this.cmbParity);
            this.gbPortSettings.Controls.Add(this.cmbDataBits);
            this.gbPortSettings.Controls.Add(this.lblParity);
            this.gbPortSettings.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbPortSettings.Location = new System.Drawing.Point(11, 387);
            this.gbPortSettings.Name = "gbPortSettings";
            this.gbPortSettings.Size = new System.Drawing.Size(381, 71);
            this.gbPortSettings.TabIndex = 4;
            this.gbPortSettings.TabStop = false;
            this.gbPortSettings.Text = "SerialPort &Settings";
            // 
            // lnkAbout
            // 
            this.lnkAbout.Location = new System.Drawing.Point(0, 0);
            this.lnkAbout.Name = "lnkAbout";
            this.lnkAbout.Size = new System.Drawing.Size(100, 23);
            this.lnkAbout.TabIndex = 15;
            // 
            // gbCC2530ZNP
            // 
            this.gbCC2530ZNP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbCC2530ZNP.Controls.Add(this.btnGetDeviceInfo);
            this.gbCC2530ZNP.Controls.Add(this.btnRegister);
            this.gbCC2530ZNP.Controls.Add(this.btnVersion);
            this.gbCC2530ZNP.Controls.Add(this.btnReset);
            this.gbCC2530ZNP.Controls.Add(this.btnStartAPP);
            this.gbCC2530ZNP.Controls.Add(this.gbZNPConfig);
            this.gbCC2530ZNP.Controls.Add(this.btnStart);
            this.gbCC2530ZNP.Enabled = false;
            this.gbCC2530ZNP.Location = new System.Drawing.Point(577, 7);
            this.gbCC2530ZNP.Name = "gbCC2530ZNP";
            this.gbCC2530ZNP.Size = new System.Drawing.Size(227, 366);
            this.gbCC2530ZNP.TabIndex = 13;
            this.gbCC2530ZNP.TabStop = false;
            this.gbCC2530ZNP.Text = "Cc2530znp Control";
            // 
            // btnGetDeviceInfo
            // 
            this.btnGetDeviceInfo.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGetDeviceInfo.ForeColor = System.Drawing.Color.Black;
            this.btnGetDeviceInfo.Location = new System.Drawing.Point(10, 326);
            this.btnGetDeviceInfo.Name = "btnGetDeviceInfo";
            this.btnGetDeviceInfo.Size = new System.Drawing.Size(204, 23);
            this.btnGetDeviceInfo.TabIndex = 16;
            this.btnGetDeviceInfo.Tag = "z";
            this.btnGetDeviceInfo.Text = "UTIL_GET_DEVICE_INFO ";
            this.btnGetDeviceInfo.Click += new System.EventHandler(this.btnGetDeviceInfo_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.Location = new System.Drawing.Point(8, 239);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(206, 23);
            this.btnRegister.TabIndex = 14;
            this.btnRegister.Text = "ZB_APP_REGISTER_REQUEST";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnVersion
            // 
            this.btnVersion.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnVersion.ForeColor = System.Drawing.Color.Green;
            this.btnVersion.Location = new System.Drawing.Point(8, 52);
            this.btnVersion.Name = "btnVersion";
            this.btnVersion.Size = new System.Drawing.Size(206, 23);
            this.btnVersion.TabIndex = 13;
            this.btnVersion.Text = "SYS_VERSION";
            this.btnVersion.Click += new System.EventHandler(this.btnVersion_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReset.ForeColor = System.Drawing.Color.Red;
            this.btnReset.Location = new System.Drawing.Point(8, 20);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(206, 23);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "SYS_RESET_REQ";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStartAPP
            // 
            this.btnStartAPP.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStartAPP.ForeColor = System.Drawing.Color.Blue;
            this.btnStartAPP.Location = new System.Drawing.Point(10, 297);
            this.btnStartAPP.Name = "btnStartAPP";
            this.btnStartAPP.Size = new System.Drawing.Size(204, 23);
            this.btnStartAPP.TabIndex = 0;
            this.btnStartAPP.Text = "ZDO_STARTUP_FROM_APP";
            this.btnStartAPP.Click += new System.EventHandler(this.btnStartAPP_Click);
            // 
            // gbZNPConfig
            // 
            this.gbZNPConfig.Controls.Add(this.txtPanID);
            this.gbZNPConfig.Controls.Add(this.cmbChannel);
            this.gbZNPConfig.Controls.Add(this.btnLogicTypeRead);
            this.gbZNPConfig.Controls.Add(this.btnLogicTypeWrite);
            this.gbZNPConfig.Controls.Add(this.btnPanIDRead);
            this.gbZNPConfig.Controls.Add(this.btnPanIDWrite);
            this.gbZNPConfig.Controls.Add(this.btnChannRead);
            this.gbZNPConfig.Controls.Add(this.btnChannWrite);
            this.gbZNPConfig.Controls.Add(this.lblChannel);
            this.gbZNPConfig.Controls.Add(this.cmbLogicType);
            this.gbZNPConfig.Controls.Add(this.lblLogicType);
            this.gbZNPConfig.Controls.Add(this.lblPanID);
            this.gbZNPConfig.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbZNPConfig.ForeColor = System.Drawing.Color.Blue;
            this.gbZNPConfig.Location = new System.Drawing.Point(8, 81);
            this.gbZNPConfig.Name = "gbZNPConfig";
            this.gbZNPConfig.Size = new System.Drawing.Size(206, 152);
            this.gbZNPConfig.TabIndex = 11;
            this.gbZNPConfig.TabStop = false;
            this.gbZNPConfig.Text = "Network Configuration";
            // 
            // txtPanID
            // 
            this.txtPanID.ForeColor = System.Drawing.Color.Blue;
            this.txtPanID.Location = new System.Drawing.Point(12, 35);
            this.txtPanID.Name = "txtPanID";
            this.txtPanID.Size = new System.Drawing.Size(130, 21);
            this.txtPanID.TabIndex = 13;
            this.txtPanID.Text = "FFFE";
            this.txtPanID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbChannel
            // 
            this.cmbChannel.ForeColor = System.Drawing.Color.Blue;
            this.cmbChannel.FormattingEnabled = true;
            this.cmbChannel.Items.AddRange(new object[] {
            "CH11:0x00000800",
            "CH12:0x00001000",
            "CH13:0x00002000",
            "CH14:0x00004000",
            "CH15:0x00008000",
            "CH16:0x00010000",
            "CH17:0x00020000",
            "CH18:0x00040000",
            "CH19:0x00080000",
            "CH20:0x00100000",
            "CH21:0x00200000",
            "CH22:0x00400000",
            "CH23:0x00800000",
            "CH24:0x01000000",
            "CH25:0x02000000",
            "CH26:0x04000000"});
            this.cmbChannel.Location = new System.Drawing.Point(12, 75);
            this.cmbChannel.Name = "cmbChannel";
            this.cmbChannel.Size = new System.Drawing.Size(130, 20);
            this.cmbChannel.TabIndex = 10;
            this.cmbChannel.Text = "CH26:0x04000000";
            // 
            // btnLogicTypeRead
            // 
            this.btnLogicTypeRead.Location = new System.Drawing.Point(154, 114);
            this.btnLogicTypeRead.Name = "btnLogicTypeRead";
            this.btnLogicTypeRead.Size = new System.Drawing.Size(20, 20);
            this.btnLogicTypeRead.TabIndex = 19;
            this.btnLogicTypeRead.Text = "R";
            this.btnLogicTypeRead.UseVisualStyleBackColor = true;
            this.btnLogicTypeRead.Click += new System.EventHandler(this.btnLogicTypeRead_Click);
            // 
            // btnLogicTypeWrite
            // 
            this.btnLogicTypeWrite.Location = new System.Drawing.Point(176, 114);
            this.btnLogicTypeWrite.Name = "btnLogicTypeWrite";
            this.btnLogicTypeWrite.Size = new System.Drawing.Size(20, 20);
            this.btnLogicTypeWrite.TabIndex = 20;
            this.btnLogicTypeWrite.Text = "W";
            this.btnLogicTypeWrite.UseVisualStyleBackColor = true;
            this.btnLogicTypeWrite.Click += new System.EventHandler(this.btnLogicTypeWrite_Click);
            // 
            // btnPanIDRead
            // 
            this.btnPanIDRead.Location = new System.Drawing.Point(154, 35);
            this.btnPanIDRead.Name = "btnPanIDRead";
            this.btnPanIDRead.Size = new System.Drawing.Size(20, 20);
            this.btnPanIDRead.TabIndex = 17;
            this.btnPanIDRead.Text = "R";
            this.btnPanIDRead.UseVisualStyleBackColor = true;
            this.btnPanIDRead.Click += new System.EventHandler(this.btnPanIDRead_Click);
            // 
            // btnPanIDWrite
            // 
            this.btnPanIDWrite.Location = new System.Drawing.Point(176, 35);
            this.btnPanIDWrite.Name = "btnPanIDWrite";
            this.btnPanIDWrite.Size = new System.Drawing.Size(20, 20);
            this.btnPanIDWrite.TabIndex = 18;
            this.btnPanIDWrite.Text = "W";
            this.btnPanIDWrite.UseVisualStyleBackColor = true;
            this.btnPanIDWrite.Click += new System.EventHandler(this.btnPanIDWrite_Click);
            // 
            // btnChannRead
            // 
            this.btnChannRead.Location = new System.Drawing.Point(154, 75);
            this.btnChannRead.Name = "btnChannRead";
            this.btnChannRead.Size = new System.Drawing.Size(20, 20);
            this.btnChannRead.TabIndex = 15;
            this.btnChannRead.Text = "R";
            this.btnChannRead.UseVisualStyleBackColor = true;
            this.btnChannRead.Click += new System.EventHandler(this.btnChannRead_Click);
            // 
            // btnChannWrite
            // 
            this.btnChannWrite.Location = new System.Drawing.Point(176, 75);
            this.btnChannWrite.Name = "btnChannWrite";
            this.btnChannWrite.Size = new System.Drawing.Size(20, 20);
            this.btnChannWrite.TabIndex = 16;
            this.btnChannWrite.Text = "W";
            this.btnChannWrite.UseVisualStyleBackColor = true;
            this.btnChannWrite.Click += new System.EventHandler(this.btnChannWrite_Click);
            // 
            // lblChannel
            // 
            this.lblChannel.AutoSize = true;
            this.lblChannel.Location = new System.Drawing.Point(10, 60);
            this.lblChannel.Name = "lblChannel";
            this.lblChannel.Size = new System.Drawing.Size(61, 12);
            this.lblChannel.TabIndex = 9;
            this.lblChannel.Text = "Channel:";
            // 
            // cmbLogicType
            // 
            this.cmbLogicType.ForeColor = System.Drawing.Color.Blue;
            this.cmbLogicType.FormattingEnabled = true;
            this.cmbLogicType.Items.AddRange(new object[] {
            "Coordinator",
            "Router",
            "EndDevice"});
            this.cmbLogicType.Location = new System.Drawing.Point(12, 114);
            this.cmbLogicType.Name = "cmbLogicType";
            this.cmbLogicType.Size = new System.Drawing.Size(130, 20);
            this.cmbLogicType.TabIndex = 14;
            this.cmbLogicType.Text = "Coordinator";
            // 
            // lblLogicType
            // 
            this.lblLogicType.AutoSize = true;
            this.lblLogicType.Location = new System.Drawing.Point(10, 99);
            this.lblLogicType.Name = "lblLogicType";
            this.lblLogicType.Size = new System.Drawing.Size(75, 12);
            this.lblLogicType.TabIndex = 14;
            this.lblLogicType.Text = "LogicType:";
            // 
            // lblPanID
            // 
            this.lblPanID.AutoSize = true;
            this.lblPanID.Location = new System.Drawing.Point(10, 20);
            this.lblPanID.Name = "lblPanID";
            this.lblPanID.Size = new System.Drawing.Size(47, 12);
            this.lblPanID.TabIndex = 12;
            this.lblPanID.Text = "PanID:";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.ForeColor = System.Drawing.Color.Blue;
            this.btnStart.Location = new System.Drawing.Point(8, 268);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(206, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "ZB_START_REQUEST";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // gbAddress
            // 
            this.gbAddress.Controls.Add(this.cmbNwkAddr);
            this.gbAddress.Controls.Add(this.lblNwkAddr);
            this.gbAddress.Location = new System.Drawing.Point(577, 379);
            this.gbAddress.Name = "gbAddress";
            this.gbAddress.Size = new System.Drawing.Size(227, 47);
            this.gbAddress.TabIndex = 12;
            this.gbAddress.TabStop = false;
            this.gbAddress.Text = "Device Select";
            // 
            // cmbNwkAddr
            // 
            this.cmbNwkAddr.FormattingEnabled = true;
            this.cmbNwkAddr.Location = new System.Drawing.Point(94, 20);
            this.cmbNwkAddr.Name = "cmbNwkAddr";
            this.cmbNwkAddr.Size = new System.Drawing.Size(110, 20);
            this.cmbNwkAddr.TabIndex = 4;
            // 
            // lblNwkAddr
            // 
            this.lblNwkAddr.AutoSize = true;
            this.lblNwkAddr.Location = new System.Drawing.Point(53, 25);
            this.lblNwkAddr.Name = "lblNwkAddr";
            this.lblNwkAddr.Size = new System.Drawing.Size(35, 12);
            this.lblNwkAddr.TabIndex = 3;
            this.lblNwkAddr.Text = "Addr:";
            // 
            // gbLight
            // 
            this.gbLight.Controls.Add(this.btnLightON);
            this.gbLight.Controls.Add(this.btnLightOFF);
            this.gbLight.Location = new System.Drawing.Point(577, 432);
            this.gbLight.Name = "gbLight";
            this.gbLight.Size = new System.Drawing.Size(227, 67);
            this.gbLight.TabIndex = 12;
            this.gbLight.TabStop = false;
            this.gbLight.Text = "HomeAutomation Light Control";
            // 
            // btnLightON
            // 
            this.btnLightON.Location = new System.Drawing.Point(20, 20);
            this.btnLightON.Name = "btnLightON";
            this.btnLightON.Size = new System.Drawing.Size(73, 37);
            this.btnLightON.TabIndex = 2;
            this.btnLightON.Text = "ON";
            this.btnLightON.UseVisualStyleBackColor = true;
            this.btnLightON.Click += new System.EventHandler(this.btnLightON_Click);
            // 
            // btnLightOFF
            // 
            this.btnLightOFF.Location = new System.Drawing.Point(130, 20);
            this.btnLightOFF.Name = "btnLightOFF";
            this.btnLightOFF.Size = new System.Drawing.Size(74, 37);
            this.btnLightOFF.TabIndex = 5;
            this.btnLightOFF.Text = "OFF";
            this.btnLightOFF.UseVisualStyleBackColor = true;
            this.btnLightOFF.Click += new System.EventHandler(this.btnLightOFF_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.exportLogToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(139, 48);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exportLogToolStripMenuItem
            // 
            this.exportLogToolStripMenuItem.Name = "exportLogToolStripMenuItem";
            this.exportLogToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.exportLogToolStripMenuItem.Text = "Export Log";
            this.exportLogToolStripMenuItem.Click += new System.EventHandler(this.exportLogToolStripMenuItem_Click);
            // 
            // rtbConsole
            // 
            this.rtbConsole.ContextMenuStrip = this.contextMenuStrip;
            this.rtbConsole.Location = new System.Drawing.Point(11, 7);
            this.rtbConsole.Name = "rtbConsole";
            this.rtbConsole.Size = new System.Drawing.Size(560, 366);
            this.rtbConsole.TabIndex = 14;
            this.rtbConsole.Text = "";
            // 
            // mForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 508);
            this.Controls.Add(this.gbAddress);
            this.Controls.Add(this.gbLight);
            this.Controls.Add(this.gbCC2530ZNP);
            this.Controls.Add(this.gbPortSettings);
            this.Controls.Add(this.gbMode);
            this.Controls.Add(this.lblSend);
            this.Controls.Add(this.txtSendData);
            this.Controls.Add(this.btnOpenPort);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.rtbConsole);
            this.Controls.Add(this.lnkAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(559, 269);
            this.Name = "mForm";
            this.Text = "cc2530znpTerminal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.gbMode.ResumeLayout(false);
            this.gbMode.PerformLayout();
            this.gbPortSettings.ResumeLayout(false);
            this.gbPortSettings.PerformLayout();
            this.gbCC2530ZNP.ResumeLayout(false);
            this.gbZNPConfig.ResumeLayout(false);
            this.gbZNPConfig.PerformLayout();
            this.gbAddress.ResumeLayout(false);
            this.gbAddress.PerformLayout();
            this.gbLight.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    //  private System.Windows.Forms.RichTextBox 
    private System.Windows.Forms.TextBox txtSendData;
    private System.Windows.Forms.Label lblSend;
    private System.Windows.Forms.Button btnSend;
    private System.Windows.Forms.ComboBox cmbPortName;
    private System.Windows.Forms.ComboBox cmbBaudRate;
    private System.Windows.Forms.RadioButton rbHex;
    private System.Windows.Forms.RadioButton rbText;
    private System.Windows.Forms.GroupBox gbMode;
    private System.Windows.Forms.Label lblComPort;
    private System.Windows.Forms.Label lblBaudRate;
    private System.Windows.Forms.Label lblParity;
    private System.Windows.Forms.ComboBox cmbParity;
    private System.Windows.Forms.Label lblDataBits;
    private System.Windows.Forms.ComboBox cmbDataBits;
    private System.Windows.Forms.Label lblStopBits;
    private System.Windows.Forms.ComboBox cmbStopBits;
    private System.Windows.Forms.Button btnOpenPort;
    private System.Windows.Forms.GroupBox gbPortSettings;
    private System.Windows.Forms.LinkLabel lnkAbout;
    //
    //private RichTextBoxPrintCtrl rtfTerminal;
    private System.Windows.Forms.GroupBox gbCC2530ZNP;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
    private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
    private System.Windows.Forms.Button btnLightON;
    private System.Windows.Forms.Label lblNwkAddr;
    private System.Windows.Forms.Button btnLightOFF;
    private System.Windows.Forms.ComboBox cmbNwkAddr;
    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.ComboBox cmbChannel;
    private System.Windows.Forms.Label lblChannel;
    private System.Windows.Forms.GroupBox gbZNPConfig;
    private System.Windows.Forms.TextBox txtPanID;
    private System.Windows.Forms.Label lblPanID;
    private System.Windows.Forms.GroupBox gbAddress;
    private System.Windows.Forms.GroupBox gbLight;
    private System.Windows.Forms.ComboBox cmbLogicType;
    private System.Windows.Forms.Label lblLogicType;
    private System.Windows.Forms.Button btnChannWrite;
    private System.Windows.Forms.Button btnChannRead;
    private System.Windows.Forms.Button btnLogicTypeRead;
    private System.Windows.Forms.Button btnLogicTypeWrite;
    private System.Windows.Forms.Button btnPanIDRead;
    private System.Windows.Forms.Button btnPanIDWrite;
    private System.Windows.Forms.Button btnVersion;
    private System.Windows.Forms.Button btnReset;
    private System.Windows.Forms.Button btnStartAPP;
    private System.Windows.Forms.RichTextBox rtbConsole;
    private System.Windows.Forms.ToolStripMenuItem exportLogToolStripMenuItem;
    private System.Windows.Forms.Button btnGetDeviceInfo;
    private System.Windows.Forms.Button btnRegister;
  }
}

