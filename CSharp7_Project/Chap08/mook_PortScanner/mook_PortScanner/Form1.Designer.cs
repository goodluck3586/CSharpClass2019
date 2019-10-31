namespace mook_PortScanner
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
            this.btnFile = new System.Windows.Forms.Button();
            this.lblFile = new System.Windows.Forms.Label();
            this.pgbScan = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.lblIp = new System.Windows.Forms.Label();
            this.fbdFile = new System.Windows.Forms.FolderBrowserDialog();
            this.lvScan = new System.Windows.Forms.ListView();
            this.chPort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOpen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(24, 130);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(241, 23);
            this.btnFile.TabIndex = 19;
            this.btnFile.Text = "파일경로";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(22, 164);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(65, 12);
            this.lblFile.TabIndex = 18;
            this.lblFile.Text = "생성 파일 :";
            this.lblFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pgbScan
            // 
            this.pgbScan.Location = new System.Drawing.Point(24, 187);
            this.pgbScan.Maximum = 50;
            this.pgbScan.Name = "pgbScan";
            this.pgbScan.Size = new System.Drawing.Size(241, 23);
            this.pgbScan.Step = 1;
            this.pgbScan.TabIndex = 17;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(190, 49);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 62);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "스  캔";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(100, 90);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(74, 21);
            this.txtEnd.TabIndex = 15;
            this.txtEnd.Text = "100";
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(100, 52);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(74, 21);
            this.txtStart.TabIndex = 14;
            this.txtStart.Text = "1";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(22, 93);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(53, 12);
            this.lblEnd.TabIndex = 13;
            this.lblEnd.Text = "종료포트";
            this.lblEnd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(22, 55);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(53, 12);
            this.lblStart.TabIndex = 12;
            this.lblStart.Text = "시작포트";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(100, 14);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(169, 21);
            this.txtIp.TabIndex = 11;
            this.txtIp.Text = "127.0.0.1";
            this.txtIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(22, 17);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(44, 12);
            this.lblIp.TabIndex = 10;
            this.lblIp.Text = "스캔 IP";
            this.lblIp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvScan
            // 
            this.lvScan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPort,
            this.chOpen});
            this.lvScan.GridLines = true;
            this.lvScan.Location = new System.Drawing.Point(285, 14);
            this.lvScan.Name = "lvScan";
            this.lvScan.Size = new System.Drawing.Size(183, 196);
            this.lvScan.TabIndex = 20;
            this.lvScan.UseCompatibleStateImageBehavior = false;
            this.lvScan.View = System.Windows.Forms.View.Details;
            // 
            // chPort
            // 
            this.chPort.Text = "port";
            this.chPort.Width = 67;
            // 
            // chOpen
            // 
            this.chOpen.Text = "open";
            this.chOpen.Width = 80;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(94, 160);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(171, 21);
            this.txtPath.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 224);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lvScan);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.pgbScan);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.lblIp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "포트 스캐너";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnFile;
        internal System.Windows.Forms.Label lblFile;
        internal System.Windows.Forms.ProgressBar pgbScan;
        internal System.Windows.Forms.Button btnStart;
        internal System.Windows.Forms.TextBox txtEnd;
        internal System.Windows.Forms.TextBox txtStart;
        internal System.Windows.Forms.Label lblEnd;
        internal System.Windows.Forms.Label lblStart;
        internal System.Windows.Forms.TextBox txtIp;
        internal System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.FolderBrowserDialog fbdFile;
        private System.Windows.Forms.ListView lvScan;
        private System.Windows.Forms.ColumnHeader chPort;
        private System.Windows.Forms.ColumnHeader chOpen;
        private System.Windows.Forms.TextBox txtPath;
    }
}

