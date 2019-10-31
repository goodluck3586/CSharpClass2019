namespace mook_NetworkChk
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
            this.components = new System.ComponentModel.Container();
            this.tlsBar = new System.Windows.Forms.ToolStrip();
            this.tsbtnAddHost = new System.Windows.Forms.ToolStripButton();
            this.tsbtnStart = new System.Windows.Forms.ToolStripButton();
            this.tsbtnStop = new System.Windows.Forms.ToolStripButton();
            this.tslcbTime = new System.Windows.Forms.ToolStripComboBox();
            this.lvStatus = new System.Windows.Forms.ListView();
            this.Host = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SendTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SentByte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RoundTripTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TTL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Result = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.stsBar = new System.Windows.Forms.StatusStrip();
            this.tsslblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlsBar.SuspendLayout();
            this.stsBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlsBar
            // 
            this.tlsBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAddHost,
            this.tsbtnStart,
            this.tsbtnStop,
            this.tslcbTime});
            this.tlsBar.Location = new System.Drawing.Point(0, 0);
            this.tlsBar.Name = "tlsBar";
            this.tlsBar.Size = new System.Drawing.Size(1104, 25);
            this.tlsBar.TabIndex = 1;
            this.tlsBar.Text = "toolStrip1";
            this.tlsBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tlsBar_ItemClicked);
            // 
            // tsbtnAddHost
            // 
            this.tsbtnAddHost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAddHost.Image = global::mook_NetworkChk.Properties.Resources.add;
            this.tsbtnAddHost.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAddHost.Name = "tsbtnAddHost";
            this.tsbtnAddHost.Size = new System.Drawing.Size(23, 22);
            this.tsbtnAddHost.Text = "호스트 추가";
            // 
            // tsbtnStart
            // 
            this.tsbtnStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnStart.Image = global::mook_NetworkChk.Properties.Resources._1rightarrow;
            this.tsbtnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnStart.Name = "tsbtnStart";
            this.tsbtnStart.Size = new System.Drawing.Size(23, 22);
            this.tsbtnStart.Text = "Start";
            // 
            // tsbtnStop
            // 
            this.tsbtnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnStop.Image = global::mook_NetworkChk.Properties.Resources.stop;
            this.tsbtnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnStop.Name = "tsbtnStop";
            this.tsbtnStop.Size = new System.Drawing.Size(23, 22);
            this.tsbtnStop.Text = "Stop";
            // 
            // tslcbTime
            // 
            this.tslcbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tslcbTime.Items.AddRange(new object[] {
            "5 초",
            "10 초",
            "15 초",
            "20 초",
            "30 초"});
            this.tslcbTime.Name = "tslcbTime";
            this.tslcbTime.Size = new System.Drawing.Size(75, 25);
            this.tslcbTime.Click += new System.EventHandler(this.tslcbTime_Click);
            // 
            // lvStatus
            // 
            this.lvStatus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Host,
            this.Description,
            this.SendTime,
            this.SentByte,
            this.RoundTripTime,
            this.TTL,
            this.Result});
            this.lvStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvStatus.FullRowSelect = true;
            this.lvStatus.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvStatus.Location = new System.Drawing.Point(0, 25);
            this.lvStatus.MultiSelect = false;
            this.lvStatus.Name = "lvStatus";
            this.lvStatus.Size = new System.Drawing.Size(1104, 394);
            this.lvStatus.TabIndex = 6;
            this.lvStatus.UseCompatibleStateImageBehavior = false;
            this.lvStatus.View = System.Windows.Forms.View.Details;
            // 
            // Host
            // 
            this.Host.Text = "호스트";
            this.Host.Width = 75;
            // 
            // Description
            // 
            this.Description.Text = "설명";
            this.Description.Width = 75;
            // 
            // SendTime
            // 
            this.SendTime.Text = "보낸시간";
            this.SendTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SendTime.Width = 77;
            // 
            // SentByte
            // 
            this.SentByte.Text = "Byte";
            this.SentByte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SentByte.Width = 80;
            // 
            // RoundTripTime
            // 
            this.RoundTripTime.Text = "시간";
            this.RoundTripTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RoundTripTime.Width = 100;
            // 
            // TTL
            // 
            this.TTL.Text = "TTL";
            this.TTL.Width = 50;
            // 
            // Result
            // 
            this.Result.Text = "결과";
            this.Result.Width = 50;
            // 
            // Timer
            // 
            this.Timer.Interval = 5000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // stsBar
            // 
            this.stsBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblStatus});
            this.stsBar.Location = new System.Drawing.Point(0, 397);
            this.stsBar.Name = "stsBar";
            this.stsBar.Size = new System.Drawing.Size(1104, 22);
            this.stsBar.TabIndex = 7;
            this.stsBar.Text = "statusStrip1";
            // 
            // tsslblStatus
            // 
            this.tsslblStatus.Name = "tsslblStatus";
            this.tsslblStatus.Size = new System.Drawing.Size(66, 17);
            this.tsslblStatus.Text = "상태 : 정지";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 419);
            this.Controls.Add(this.stsBar);
            this.Controls.Add(this.lvStatus);
            this.Controls.Add(this.tlsBar);
            this.Name = "Form1";
            this.Text = "네트워크 체크";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tlsBar.ResumeLayout(false);
            this.tlsBar.PerformLayout();
            this.stsBar.ResumeLayout(false);
            this.stsBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlsBar;
        private System.Windows.Forms.ToolStripButton tsbtnAddHost;
        private System.Windows.Forms.ToolStripButton tsbtnStart;
        private System.Windows.Forms.ToolStripButton tsbtnStop;
        private System.Windows.Forms.ToolStripComboBox tslcbTime;
        private System.Windows.Forms.ListView lvStatus;
        private System.Windows.Forms.ColumnHeader Host;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader SendTime;
        private System.Windows.Forms.ColumnHeader SentByte;
        private System.Windows.Forms.ColumnHeader RoundTripTime;
        private System.Windows.Forms.ColumnHeader TTL;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ColumnHeader Result;
        private System.Windows.Forms.StatusStrip stsBar;
        private System.Windows.Forms.ToolStripStatusLabel tsslblStatus;
    }
}


