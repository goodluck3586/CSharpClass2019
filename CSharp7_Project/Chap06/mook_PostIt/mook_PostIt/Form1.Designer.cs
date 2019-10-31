namespace mook_PostIt
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
            this.tOpen = new System.Windows.Forms.Timer(this.components);
            this.rtbMemo = new System.Windows.Forms.RichTextBox();
            this.tsBar = new System.Windows.Forms.ToolStrip();
            this.tsbtnClose = new System.Windows.Forms.ToolStripButton();
            this.tsddbtnOption = new System.Windows.Forms.ToolStripDropDownButton();
            this.자동실행ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.쪽지저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.메모숨김ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tClose = new System.Windows.Forms.Timer(this.components);
            this.tsBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tOpen
            // 
            this.tOpen.Interval = 5;
            this.tOpen.Tick += new System.EventHandler(this.tOpen_Tick);
            // 
            // rtbMemo
            // 
            this.rtbMemo.BackColor = System.Drawing.Color.LightBlue;
            this.rtbMemo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMemo.Location = new System.Drawing.Point(0, 25);
            this.rtbMemo.Name = "rtbMemo";
            this.rtbMemo.Size = new System.Drawing.Size(300, 275);
            this.rtbMemo.TabIndex = 5;
            this.rtbMemo.Text = "";
            // 
            // tsBar
            // 
            this.tsBar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tsBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnClose,
            this.tsddbtnOption});
            this.tsBar.Location = new System.Drawing.Point(0, 0);
            this.tsBar.Name = "tsBar";
            this.tsBar.Size = new System.Drawing.Size(300, 25);
            this.tsBar.TabIndex = 4;
            this.tsBar.Text = "ToolStrip1";
            this.tsBar.DoubleClick += new System.EventHandler(this.tsBar_DoubleClick);
            this.tsBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsBar_MouseDown);
            this.tsBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tsBar_MouseMove);
            this.tsBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tsBar_MouseUp);
            // 
            // tsbtnClose
            // 
            this.tsbtnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnClose.Image = global::mook_PostIt.Properties.Resources.close;
            this.tsbtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnClose.Name = "tsbtnClose";
            this.tsbtnClose.Size = new System.Drawing.Size(23, 22);
            this.tsbtnClose.Text = "닫기";
            this.tsbtnClose.ToolTipText = "닫기";
            this.tsbtnClose.Click += new System.EventHandler(this.tsbtnClose_Click);
            // 
            // tsddbtnOption
            // 
            this.tsddbtnOption.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsddbtnOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.자동실행ToolStripMenuItem,
            this.쪽지저장ToolStripMenuItem,
            this.메모숨김ToolStripMenuItem,
            this.ToolStripSeparator1,
            this.끝내기ToolStripMenuItem});
            this.tsddbtnOption.Image = global::mook_PostIt.Properties.Resources.option;
            this.tsddbtnOption.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbtnOption.Name = "tsddbtnOption";
            this.tsddbtnOption.Size = new System.Drawing.Size(29, 22);
            this.tsddbtnOption.Text = "환경설정";
            this.tsddbtnOption.ToolTipText = "환경설정";
            // 
            // 자동실행ToolStripMenuItem
            // 
            this.자동실행ToolStripMenuItem.Name = "자동실행ToolStripMenuItem";
            this.자동실행ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.자동실행ToolStripMenuItem.Text = "자동실행";
            this.자동실행ToolStripMenuItem.Click += new System.EventHandler(this.자동실행ToolStripMenuItem_Click);
            // 
            // 쪽지저장ToolStripMenuItem
            // 
            this.쪽지저장ToolStripMenuItem.Name = "쪽지저장ToolStripMenuItem";
            this.쪽지저장ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.쪽지저장ToolStripMenuItem.Text = "쪽지저장";
            this.쪽지저장ToolStripMenuItem.Click += new System.EventHandler(this.쪽지저장ToolStripMenuItem_Click);
            // 
            // 메모숨김ToolStripMenuItem
            // 
            this.메모숨김ToolStripMenuItem.Name = "메모숨김ToolStripMenuItem";
            this.메모숨김ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.메모숨김ToolStripMenuItem.Text = "메모숨김";
            this.메모숨김ToolStripMenuItem.Click += new System.EventHandler(this.메모숨김ToolStripMenuItem_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.끝내기ToolStripMenuItem.Text = "끝  내 기";
            this.끝내기ToolStripMenuItem.Click += new System.EventHandler(this.끝내기ToolStripMenuItem_Click);
            // 
            // tClose
            // 
            this.tClose.Interval = 5;
            this.tClose.Tick += new System.EventHandler(this.tClose_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.rtbMemo);
            this.Controls.Add(this.tsBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "포스트 잇";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tsBar.ResumeLayout(false);
            this.tsBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tOpen;
        private System.Windows.Forms.RichTextBox rtbMemo;
        private System.Windows.Forms.ToolStrip tsBar;
        private System.Windows.Forms.Timer tClose;
        private System.Windows.Forms.ToolStripButton tsbtnClose;
        private System.Windows.Forms.ToolStripDropDownButton tsddbtnOption;
        private System.Windows.Forms.ToolStripMenuItem 자동실행ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 쪽지저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 메모숨김ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
    }
}

