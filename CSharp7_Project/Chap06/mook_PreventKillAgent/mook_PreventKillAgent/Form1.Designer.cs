namespace mook_PreventKillAgent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nyiTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsPopup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.종료EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOff = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.cmsPopup.SuspendLayout();
            this.SuspendLayout();
            // 
            // nyiTray
            // 
            this.nyiTray.ContextMenuStrip = this.cmsPopup;
            this.nyiTray.Icon = ((System.Drawing.Icon)(resources.GetObject("nyiTray.Icon")));
            this.nyiTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.nyiTray_MouseDoubleClick);
            // 
            // cmsPopup
            // 
            this.cmsPopup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.열기ToolStripMenuItem,
            this.toolStripSeparator1,
            this.종료EToolStripMenuItem});
            this.cmsPopup.Name = "cmsPopup";
            this.cmsPopup.Size = new System.Drawing.Size(120, 54);
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.열기ToolStripMenuItem.Text = "열 기(&O)";
            this.열기ToolStripMenuItem.Click += new System.EventHandler(this.열기ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(116, 6);
            // 
            // 종료EToolStripMenuItem
            // 
            this.종료EToolStripMenuItem.Name = "종료EToolStripMenuItem";
            this.종료EToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.종료EToolStripMenuItem.Text = "종 료(&X)";
            this.종료EToolStripMenuItem.Click += new System.EventHandler(this.종료EToolStripMenuItem_Click);
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(102, 88);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(75, 23);
            this.btnOff.TabIndex = 2;
            this.btnOff.Text = "완전 종료";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(21, 32);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(53, 12);
            this.lblMsg.TabIndex = 3;
            this.lblMsg.Text = "메시지 : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 135);
            this.ContextMenuStrip = this.cmsPopup;
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnOff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "메시지 받기";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cmsPopup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon nyiTray;
        private System.Windows.Forms.ContextMenuStrip cmsPopup;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 종료EToolStripMenuItem;
        internal System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Label lblMsg;
    }
}
