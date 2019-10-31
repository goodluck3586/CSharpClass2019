namespace mook_Message
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.plOption = new System.Windows.Forms.Panel();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.lblIp = new System.Windows.Forms.Label();
            this.cbServer = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.plGroup = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.plMessage = new System.Windows.Forms.Panel();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.tsBar = new System.Windows.Forms.ToolStrip();
            this.ssBar = new System.Windows.Forms.StatusStrip();
            this.tsslblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsddbtnOption = new System.Windows.Forms.ToolStripDropDownButton();
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.닫기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnConn = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDisconn = new System.Windows.Forms.ToolStripButton();
            this.plOption.SuspendLayout();
            this.plGroup.SuspendLayout();
            this.plMessage.SuspendLayout();
            this.tsBar.SuspendLayout();
            this.ssBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // plOption
            // 
            this.plOption.BackColor = System.Drawing.Color.AliceBlue;
            this.plOption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plOption.Controls.Add(this.txtIp);
            this.plOption.Controls.Add(this.lblIp);
            this.plOption.Controls.Add(this.cbServer);
            this.plOption.Controls.Add(this.btnClose);
            this.plOption.Controls.Add(this.txtPort);
            this.plOption.Controls.Add(this.lblPort);
            this.plOption.Controls.Add(this.txtId);
            this.plOption.Controls.Add(this.lblId);
            this.plOption.Controls.Add(this.btnSave);
            this.plOption.Location = new System.Drawing.Point(43, 83);
            this.plOption.Name = "plOption";
            this.plOption.Size = new System.Drawing.Size(200, 147);
            this.plOption.TabIndex = 15;
            this.plOption.Visible = false;
            // 
            // txtIp
            // 
            this.txtIp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIp.Location = new System.Drawing.Point(73, 11);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(100, 21);
            this.txtIp.TabIndex = 10;
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(25, 14);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(24, 12);
            this.lblIp.TabIndex = 9;
            this.lblIp.Text = "IP :";
            // 
            // cbServer
            // 
            this.cbServer.AutoSize = true;
            this.cbServer.Location = new System.Drawing.Point(28, 92);
            this.cbServer.Name = "cbServer";
            this.cbServer.Size = new System.Drawing.Size(72, 16);
            this.cbServer.TabIndex = 8;
            this.cbServer.Text = "서버실행";
            this.cbServer.UseVisualStyleBackColor = true;
            this.cbServer.CheckedChanged += new System.EventHandler(this.cbServer_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(107, 114);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(65, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "닫 기";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtPort
            // 
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPort.Location = new System.Drawing.Point(73, 65);
            this.txtPort.Name = "txtPort";
            this.txtPort.ReadOnly = true;
            this.txtPort.Size = new System.Drawing.Size(100, 21);
            this.txtPort.TabIndex = 6;
            this.txtPort.Text = "62000";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(25, 68);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(46, 12);
            this.lblPort.TabIndex = 5;
            this.lblPort.Text = "PORT :";
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Location = new System.Drawing.Point(73, 38);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 21);
            this.txtId.TabIndex = 4;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(25, 41);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(24, 12);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "ID :";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(27, 114);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(61, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "설 정";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // plGroup
            // 
            this.plGroup.BackColor = System.Drawing.Color.RoyalBlue;
            this.plGroup.Controls.Add(this.btnSend);
            this.plGroup.Controls.Add(this.plMessage);
            this.plGroup.Location = new System.Drawing.Point(0, 268);
            this.plGroup.Name = "plGroup";
            this.plGroup.Size = new System.Drawing.Size(292, 53);
            this.plGroup.TabIndex = 14;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.White;
            this.btnSend.Enabled = false;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Location = new System.Drawing.Point(222, 10);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(65, 35);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "보내기";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // plMessage
            // 
            this.plMessage.BackColor = System.Drawing.Color.White;
            this.plMessage.Controls.Add(this.txtMessage);
            this.plMessage.Location = new System.Drawing.Point(6, 10);
            this.plMessage.Name = "plMessage";
            this.plMessage.Size = new System.Drawing.Size(210, 35);
            this.plMessage.TabIndex = 0;
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.White;
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMessage.Enabled = false;
            this.txtMessage.Location = new System.Drawing.Point(5, 10);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(201, 14);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            this.txtMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMessage_KeyPress);
            // 
            // rtbText
            // 
            this.rtbText.BackColor = System.Drawing.Color.White;
            this.rtbText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbText.Location = new System.Drawing.Point(0, 28);
            this.rtbText.Name = "rtbText";
            this.rtbText.ReadOnly = true;
            this.rtbText.Size = new System.Drawing.Size(292, 238);
            this.rtbText.TabIndex = 13;
            this.rtbText.TabStop = false;
            this.rtbText.Text = "";
            // 
            // tsBar
            // 
            this.tsBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbtnOption,
            this.tsbtnConn,
            this.tsbtnDisconn});
            this.tsBar.Location = new System.Drawing.Point(0, 0);
            this.tsBar.Name = "tsBar";
            this.tsBar.Size = new System.Drawing.Size(294, 25);
            this.tsBar.TabIndex = 12;
            this.tsBar.Text = "ToolStrip1";
            // 
            // ssBar
            // 
            this.ssBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblTime});
            this.ssBar.Location = new System.Drawing.Point(0, 325);
            this.ssBar.Name = "ssBar";
            this.ssBar.Size = new System.Drawing.Size(294, 22);
            this.ssBar.TabIndex = 11;
            this.ssBar.Text = "StatusStrip1";
            // 
            // tsslblTime
            // 
            this.tsslblTime.Name = "tsslblTime";
            this.tsslblTime.Size = new System.Drawing.Size(127, 17);
            this.tsslblTime.Text = "메시지 받은 시간 출력";
            // 
            // tsddbtnOption
            // 
            this.tsddbtnOption.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsddbtnOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.설정ToolStripMenuItem,
            this.ToolStripSeparator1,
            this.닫기ToolStripMenuItem});
            this.tsddbtnOption.Image = global::mook_Message.Properties.Resources.option;
            this.tsddbtnOption.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbtnOption.Name = "tsddbtnOption";
            this.tsddbtnOption.Size = new System.Drawing.Size(29, 22);
            this.tsddbtnOption.Text = "환경설정";
            this.tsddbtnOption.ToolTipText = "환경설정";
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.설정ToolStripMenuItem.Text = "설 정";
            this.설정ToolStripMenuItem.Click += new System.EventHandler(this.설정ToolStripMenuItem_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // 닫기ToolStripMenuItem
            // 
            this.닫기ToolStripMenuItem.Name = "닫기ToolStripMenuItem";
            this.닫기ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.닫기ToolStripMenuItem.Text = "닫 기";
            this.닫기ToolStripMenuItem.Click += new System.EventHandler(this.닫기ToolStripMenuItem_Click);
            // 
            // tsbtnConn
            // 
            this.tsbtnConn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnConn.Enabled = false;
            this.tsbtnConn.Image = global::mook_Message.Properties.Resources.connection;
            this.tsbtnConn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnConn.Name = "tsbtnConn";
            this.tsbtnConn.Size = new System.Drawing.Size(23, 22);
            this.tsbtnConn.Text = "연결";
            this.tsbtnConn.Click += new System.EventHandler(this.tsbtnConn_Click);
            // 
            // tsbtnDisconn
            // 
            this.tsbtnDisconn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnDisconn.Enabled = false;
            this.tsbtnDisconn.Image = global::mook_Message.Properties.Resources.disconnection;
            this.tsbtnDisconn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDisconn.Name = "tsbtnDisconn";
            this.tsbtnDisconn.Size = new System.Drawing.Size(23, 22);
            this.tsbtnDisconn.Text = "끊기";
            this.tsbtnDisconn.ToolTipText = "끊기";
            this.tsbtnDisconn.Click += new System.EventHandler(this.tsbtnDisconn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 347);
            this.Controls.Add(this.plOption);
            this.Controls.Add(this.plGroup);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.tsBar);
            this.Controls.Add(this.ssBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "1:1 채팅";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.plOption.ResumeLayout(false);
            this.plOption.PerformLayout();
            this.plGroup.ResumeLayout(false);
            this.plMessage.ResumeLayout(false);
            this.plMessage.PerformLayout();
            this.tsBar.ResumeLayout(false);
            this.tsBar.PerformLayout();
            this.ssBar.ResumeLayout(false);
            this.ssBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtIp;
        internal System.Windows.Forms.Label lblIp;
        internal System.Windows.Forms.CheckBox cbServer;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.TextBox txtPort;
        internal System.Windows.Forms.Label lblPort;
        internal System.Windows.Forms.TextBox txtId;
        internal System.Windows.Forms.Label lblId;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.ToolStripDropDownButton tsddbtnOption;
        internal System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripMenuItem 닫기ToolStripMenuItem;
        internal System.Windows.Forms.ToolStripButton tsbtnConn;
        internal System.Windows.Forms.ToolStripButton tsbtnDisconn;
        private System.Windows.Forms.Panel plOption;
        private System.Windows.Forms.Panel plGroup;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel plMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.ToolStrip tsBar;
        private System.Windows.Forms.StatusStrip ssBar;
        private System.Windows.Forms.ToolStripStatusLabel tsslblTime;
    }
}
