namespace SeriaoPortTool
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label7 = new Label();
            textbSendInterval = new TextBox();
            ckbContinuSend = new CheckBox();
            ckbAddEnd = new CheckBox();
            ckbHexSend = new CheckBox();
            btnSend = new Button();
            cboxTimeStamp = new CheckBox();
            cboxRTS = new CheckBox();
            cboxDTR = new CheckBox();
            cboxAutoSave = new CheckBox();
            cboxHex = new CheckBox();
            btnClearInput = new Button();
            btnSaveForm = new Button();
            btbDisconnect = new Button();
            btnConnect = new Button();
            combVerifyBit = new ComboBox();
            combStopBit = new ComboBox();
            combDataBit = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            combBauRate = new ComboBox();
            label2 = new Label();
            combPortName = new ComboBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBoxRecv = new TextBox();
            groupBox2 = new GroupBox();
            textBoxSed = new TextBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textbSendInterval);
            panel1.Controls.Add(ckbContinuSend);
            panel1.Controls.Add(ckbAddEnd);
            panel1.Controls.Add(ckbHexSend);
            panel1.Controls.Add(btnSend);
            panel1.Controls.Add(cboxTimeStamp);
            panel1.Controls.Add(cboxRTS);
            panel1.Controls.Add(cboxDTR);
            panel1.Controls.Add(cboxAutoSave);
            panel1.Controls.Add(cboxHex);
            panel1.Controls.Add(btnClearInput);
            panel1.Controls.Add(btnSaveForm);
            panel1.Controls.Add(btbDisconnect);
            panel1.Controls.Add(btnConnect);
            panel1.Controls.Add(combVerifyBit);
            panel1.Controls.Add(combStopBit);
            panel1.Controls.Add(combDataBit);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(combBauRate);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(combPortName);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(854, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 889);
            panel1.TabIndex = 3;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(315, 827);
            label7.Name = "label7";
            label7.Size = new Size(47, 31);
            label7.TabIndex = 26;
            label7.Text = "ms";
            // 
            // textbSendInterval
            // 
            textbSendInterval.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textbSendInterval.Location = new Point(238, 824);
            textbSendInterval.Name = "textbSendInterval";
            textbSendInterval.Size = new Size(71, 38);
            textbSendInterval.TabIndex = 25;
            textbSendInterval.Text = "1000";
            // 
            // ckbContinuSend
            // 
            ckbContinuSend.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ckbContinuSend.AutoSize = true;
            ckbContinuSend.Enabled = false;
            ckbContinuSend.Location = new Point(13, 824);
            ckbContinuSend.Name = "ckbContinuSend";
            ckbContinuSend.Size = new Size(142, 35);
            ckbContinuSend.TabIndex = 24;
            ckbContinuSend.Text = "连续发送";
            ckbContinuSend.UseVisualStyleBackColor = true;
            ckbContinuSend.CheckedChanged += ckbContinuSend_CheckedChanged;
            // 
            // ckbAddEnd
            // 
            ckbAddEnd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ckbAddEnd.AutoSize = true;
            ckbAddEnd.Location = new Point(238, 768);
            ckbAddEnd.Name = "ckbAddEnd";
            ckbAddEnd.Size = new Size(138, 35);
            ckbAddEnd.TabIndex = 23;
            ckbAddEnd.Text = "添加\\r\\n";
            ckbAddEnd.UseVisualStyleBackColor = true;
            // 
            // ckbHexSend
            // 
            ckbHexSend.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ckbHexSend.AutoSize = true;
            ckbHexSend.Location = new Point(13, 768);
            ckbHexSend.Name = "ckbHexSend";
            ckbHexSend.Size = new Size(170, 35);
            ckbHexSend.TabIndex = 22;
            ckbHexSend.Text = "16进制发送";
            ckbHexSend.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSend.Enabled = false;
            btnSend.Location = new Point(13, 697);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(375, 46);
            btnSend.TabIndex = 21;
            btnSend.Text = "发送";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // cboxTimeStamp
            // 
            cboxTimeStamp.AutoSize = true;
            cboxTimeStamp.Location = new Point(13, 539);
            cboxTimeStamp.Name = "cboxTimeStamp";
            cboxTimeStamp.Size = new Size(118, 35);
            cboxTimeStamp.TabIndex = 18;
            cboxTimeStamp.Text = "时间戳";
            cboxTimeStamp.UseVisualStyleBackColor = true;
            // 
            // cboxRTS
            // 
            cboxRTS.AutoSize = true;
            cboxRTS.Location = new Point(238, 483);
            cboxRTS.Name = "cboxRTS";
            cboxRTS.Size = new Size(90, 35);
            cboxRTS.TabIndex = 17;
            cboxRTS.Text = "RTS";
            cboxRTS.UseVisualStyleBackColor = true;
            // 
            // cboxDTR
            // 
            cboxDTR.AutoSize = true;
            cboxDTR.Location = new Point(13, 483);
            cboxDTR.Name = "cboxDTR";
            cboxDTR.Size = new Size(94, 35);
            cboxDTR.TabIndex = 16;
            cboxDTR.Text = "DTR";
            cboxDTR.UseVisualStyleBackColor = true;
            // 
            // cboxAutoSave
            // 
            cboxAutoSave.AutoSize = true;
            cboxAutoSave.Location = new Point(238, 428);
            cboxAutoSave.Name = "cboxAutoSave";
            cboxAutoSave.Size = new Size(142, 35);
            cboxAutoSave.TabIndex = 15;
            cboxAutoSave.Text = "自动保存";
            cboxAutoSave.UseVisualStyleBackColor = true;
            // 
            // cboxHex
            // 
            cboxHex.AutoSize = true;
            cboxHex.Location = new Point(13, 428);
            cboxHex.Name = "cboxHex";
            cboxHex.Size = new Size(170, 35);
            cboxHex.TabIndex = 14;
            cboxHex.Text = "16进制显示";
            cboxHex.UseVisualStyleBackColor = true;
            // 
            // btnClearInput
            // 
            btnClearInput.Location = new Point(238, 364);
            btnClearInput.Name = "btnClearInput";
            btnClearInput.Size = new Size(150, 46);
            btnClearInput.TabIndex = 13;
            btnClearInput.Text = "清除接收";
            btnClearInput.UseVisualStyleBackColor = true;
            btnClearInput.Click += btnClearInput_Click;
            // 
            // btnSaveForm
            // 
            btnSaveForm.Enabled = false;
            btnSaveForm.Location = new Point(13, 364);
            btnSaveForm.Name = "btnSaveForm";
            btnSaveForm.Size = new Size(150, 46);
            btnSaveForm.TabIndex = 12;
            btnSaveForm.Text = "保存窗口";
            btnSaveForm.UseVisualStyleBackColor = true;
            // 
            // btbDisconnect
            // 
            btbDisconnect.Enabled = false;
            btbDisconnect.Location = new Point(238, 300);
            btbDisconnect.Name = "btbDisconnect";
            btbDisconnect.Size = new Size(150, 46);
            btbDisconnect.TabIndex = 11;
            btbDisconnect.Text = "断开";
            btbDisconnect.UseVisualStyleBackColor = true;
            btbDisconnect.Click += btbDisconnect_Click;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(13, 300);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(150, 46);
            btnConnect.TabIndex = 10;
            btnConnect.Text = "连接";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // combVerifyBit
            // 
            combVerifyBit.DropDownStyle = ComboBoxStyle.DropDownList;
            combVerifyBit.FormattingEnabled = true;
            combVerifyBit.Items.AddRange(new object[] { "none", "odd", "even" });
            combVerifyBit.Location = new Point(146, 229);
            combVerifyBit.Name = "combVerifyBit";
            combVerifyBit.Size = new Size(242, 39);
            combVerifyBit.TabIndex = 9;
            // 
            // combStopBit
            // 
            combStopBit.DropDownStyle = ComboBoxStyle.DropDownList;
            combStopBit.FormattingEnabled = true;
            combStopBit.Items.AddRange(new object[] { "1", "1.5", "2" });
            combStopBit.Location = new Point(146, 184);
            combStopBit.Name = "combStopBit";
            combStopBit.Size = new Size(242, 39);
            combStopBit.TabIndex = 8;
            // 
            // combDataBit
            // 
            combDataBit.DropDownStyle = ComboBoxStyle.DropDownList;
            combDataBit.FormattingEnabled = true;
            combDataBit.Items.AddRange(new object[] { "6", "7", "8", "9" });
            combDataBit.Location = new Point(146, 139);
            combDataBit.Name = "combDataBit";
            combDataBit.Size = new Size(242, 39);
            combDataBit.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 237);
            label5.Name = "label5";
            label5.Size = new Size(86, 31);
            label5.TabIndex = 6;
            label5.Text = "校验位";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 192);
            label4.Name = "label4";
            label4.Size = new Size(86, 31);
            label4.TabIndex = 5;
            label4.Text = "停止位";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 147);
            label3.Name = "label3";
            label3.Size = new Size(86, 31);
            label3.TabIndex = 4;
            label3.Text = "数据位";
            // 
            // combBauRate
            // 
            combBauRate.DisplayMember = "1";
            combBauRate.DropDownStyle = ComboBoxStyle.DropDownList;
            combBauRate.FormattingEnabled = true;
            combBauRate.Items.AddRange(new object[] { "9600", "19200", "38400", "57600", "115200" });
            combBauRate.Location = new Point(146, 94);
            combBauRate.Name = "combBauRate";
            combBauRate.Size = new Size(242, 39);
            combBauRate.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 102);
            label2.Name = "label2";
            label2.Size = new Size(86, 31);
            label2.TabIndex = 2;
            label2.Text = "波特率";
            // 
            // combPortName
            // 
            combPortName.DropDownStyle = ComboBoxStyle.DropDownList;
            combPortName.FormattingEnabled = true;
            combPortName.ImeMode = ImeMode.NoControl;
            combPortName.Location = new Point(13, 49);
            combPortName.Name = "combPortName";
            combPortName.Size = new Size(375, 39);
            combPortName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 31);
            label1.TabIndex = 0;
            label1.Text = "串口选择";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(textBoxRecv);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(854, 683);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "接收区";
            // 
            // textBoxRecv
            // 
            textBoxRecv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxRecv.Location = new Point(3, 34);
            textBoxRecv.Multiline = true;
            textBoxRecv.Name = "textBoxRecv";
            textBoxRecv.ReadOnly = true;
            textBoxRecv.ScrollBars = ScrollBars.Both;
            textBoxRecv.Size = new Size(848, 646);
            textBoxRecv.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxSed);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 689);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(854, 200);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "发送区";
            // 
            // textBoxSed
            // 
            textBoxSed.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSed.Location = new Point(3, 34);
            textBoxSed.Multiline = true;
            textBoxSed.Name = "textBoxSed";
            textBoxSed.Size = new Size(848, 163);
            textBoxSed.TabIndex = 0;
            textBoxSed.Text = "hello world";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 889);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "SerialPort";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox combBauRate;
        private Label label2;
        private ComboBox combPortName;
        private Label label1;
        private ComboBox combVerifyBit;
        private ComboBox combStopBit;
        private ComboBox combDataBit;
        private CheckBox cboxAutoSave;
        private CheckBox cboxHex;
        private Button btnClearInput;
        private Button btnSaveForm;
        private Button btbDisconnect;
        private Button btnConnect;
        private CheckBox cboxTimeStamp;
        private CheckBox cboxRTS;
        private CheckBox cboxDTR;
        private Button btnSend;
        private Label label7;
        private TextBox textbSendInterval;
        private CheckBox ckbContinuSend;
        private CheckBox ckbAddEnd;
        private CheckBox ckbHexSend;
        private GroupBox groupBox1;
        private TextBox textBoxRecv;
        private GroupBox groupBox2;
        private TextBox textBoxSed;
    }
}