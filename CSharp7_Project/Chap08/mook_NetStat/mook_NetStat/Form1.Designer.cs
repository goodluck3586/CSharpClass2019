namespace mook_NetStat
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
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem("");
            this.txtForPort = new System.Windows.Forms.TextBox();
            this.lblForPort = new System.Windows.Forms.Label();
            this.txtForAdd = new System.Windows.Forms.TextBox();
            this.lblForAdd = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtLocPort = new System.Windows.Forms.TextBox();
            this.lblLocPort = new System.Windows.Forms.Label();
            this.lvNetState = new System.Windows.Forms.ListView();
            this.clhLocalIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhLocalPort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhRemoteIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhRemotePort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSave = new System.Windows.Forms.Button();
            this.sfdFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // txtForPort
            // 
            this.txtForPort.Location = new System.Drawing.Point(364, 361);
            this.txtForPort.Name = "txtForPort";
            this.txtForPort.Size = new System.Drawing.Size(46, 21);
            this.txtForPort.TabIndex = 11;
            // 
            // lblForPort
            // 
            this.lblForPort.BackColor = System.Drawing.Color.Aqua;
            this.lblForPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblForPort.Location = new System.Drawing.Point(295, 362);
            this.lblForPort.Name = "lblForPort";
            this.lblForPort.Size = new System.Drawing.Size(60, 20);
            this.lblForPort.TabIndex = 14;
            this.lblForPort.Text = "외부포트";
            this.lblForPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtForAdd
            // 
            this.txtForAdd.Location = new System.Drawing.Point(204, 361);
            this.txtForAdd.Name = "txtForAdd";
            this.txtForAdd.Size = new System.Drawing.Size(86, 21);
            this.txtForAdd.TabIndex = 10;
            // 
            // lblForAdd
            // 
            this.lblForAdd.BackColor = System.Drawing.Color.LightPink;
            this.lblForAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblForAdd.Location = new System.Drawing.Point(135, 362);
            this.lblForAdd.Name = "lblForAdd";
            this.lblForAdd.Size = new System.Drawing.Size(60, 20);
            this.lblForAdd.TabIndex = 12;
            this.lblForAdd.Text = "외부주소";
            this.lblForAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(416, 361);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(40, 20);
            this.btnCheck.TabIndex = 13;
            this.btnCheck.Text = "체크";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtLocPort
            // 
            this.txtLocPort.Location = new System.Drawing.Point(81, 361);
            this.txtLocPort.Name = "txtLocPort";
            this.txtLocPort.Size = new System.Drawing.Size(46, 21);
            this.txtLocPort.TabIndex = 8;
            // 
            // lblLocPort
            // 
            this.lblLocPort.BackColor = System.Drawing.Color.GreenYellow;
            this.lblLocPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLocPort.Location = new System.Drawing.Point(12, 362);
            this.lblLocPort.Name = "lblLocPort";
            this.lblLocPort.Size = new System.Drawing.Size(60, 20);
            this.lblLocPort.TabIndex = 9;
            this.lblLocPort.Text = "로컬포트";
            this.lblLocPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvNetState
            // 
            this.lvNetState.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhLocalIP,
            this.clhLocalPort,
            this.clhRemoteIP,
            this.clhRemotePort,
            this.clhState});
            this.lvNetState.GridLines = true;
            this.lvNetState.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem16,
            listViewItem17,
            listViewItem18,
            listViewItem19,
            listViewItem20});
            this.lvNetState.Location = new System.Drawing.Point(12, 11);
            this.lvNetState.Name = "lvNetState";
            this.lvNetState.Size = new System.Drawing.Size(485, 342);
            this.lvNetState.TabIndex = 7;
            this.lvNetState.UseCompatibleStateImageBehavior = false;
            this.lvNetState.View = System.Windows.Forms.View.Details;
            // 
            // clhLocalIP
            // 
            this.clhLocalIP.Text = "로컬주소";
            this.clhLocalIP.Width = 120;
            // 
            // clhLocalPort
            // 
            this.clhLocalPort.Text = "로컬포트";
            this.clhLocalPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clhRemoteIP
            // 
            this.clhRemoteIP.Text = "외부주소";
            this.clhRemoteIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhRemoteIP.Width = 120;
            // 
            // clhRemotePort
            // 
            this.clhRemotePort.Text = "외부포트";
            this.clhRemotePort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clhState
            // 
            this.clhState.Text = "상태";
            this.clhState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhState.Width = 90;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(457, 361);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(40, 20);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // sfdFile
            // 
            this.sfdFile.DefaultExt = "txt";
            this.sfdFile.Filter = "텍스트 파일 (*.txt)|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 394);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtForPort);
            this.Controls.Add(this.lblForPort);
            this.Controls.Add(this.txtForAdd);
            this.Controls.Add(this.lblForAdd);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtLocPort);
            this.Controls.Add(this.lblLocPort);
            this.Controls.Add(this.lvNetState);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "NetStat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtForPort;
        internal System.Windows.Forms.Label lblForPort;
        internal System.Windows.Forms.TextBox txtForAdd;
        internal System.Windows.Forms.Label lblForAdd;
        internal System.Windows.Forms.Button btnCheck;
        internal System.Windows.Forms.TextBox txtLocPort;
        internal System.Windows.Forms.Label lblLocPort;
        internal System.Windows.Forms.ListView lvNetState;
        internal System.Windows.Forms.ColumnHeader clhLocalIP;
        internal System.Windows.Forms.ColumnHeader clhLocalPort;
        internal System.Windows.Forms.ColumnHeader clhRemoteIP;
        internal System.Windows.Forms.ColumnHeader clhRemotePort;
        internal System.Windows.Forms.ColumnHeader clhState;
        internal System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog sfdFile;
    }
}
