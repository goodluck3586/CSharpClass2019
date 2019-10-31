namespace mook_WaterMark
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
            this.btnView = new System.Windows.Forms.Button();
            this.lblOpacity = new System.Windows.Forms.Label();
            this.hsbOpacity = new System.Windows.Forms.HScrollBar();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.txtBack = new System.Windows.Forms.TextBox();
            this.lblMark = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.picbView = new System.Windows.Forms.PictureBox();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.sfdImage = new System.Windows.Forms.SaveFileDialog();
            this.fdlg = new System.Windows.Forms.FontDialog();
            this.cdlg = new System.Windows.Forms.ColorDialog();
            this.msBar = new System.Windows.Forms.MenuStrip();
            this.폰트설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.글꼴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.색상ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picbView)).BeginInit();
            this.msBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(291, 60);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 22;
            this.btnView.Text = "미리보기";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lblOpacity
            // 
            this.lblOpacity.AutoSize = true;
            this.lblOpacity.Location = new System.Drawing.Point(10, 115);
            this.lblOpacity.Name = "lblOpacity";
            this.lblOpacity.Size = new System.Drawing.Size(41, 12);
            this.lblOpacity.TabIndex = 21;
            this.lblOpacity.Text = "투명도";
            // 
            // hsbOpacity
            // 
            this.hsbOpacity.Location = new System.Drawing.Point(58, 109);
            this.hsbOpacity.Minimum = 1;
            this.hsbOpacity.Name = "hsbOpacity";
            this.hsbOpacity.Size = new System.Drawing.Size(226, 22);
            this.hsbOpacity.TabIndex = 20;
            this.hsbOpacity.Value = 50;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(291, 33);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "배경파일";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtMark
            // 
            this.txtMark.Location = new System.Drawing.Point(58, 62);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(226, 21);
            this.txtMark.TabIndex = 17;
            // 
            // txtBack
            // 
            this.txtBack.Location = new System.Drawing.Point(58, 36);
            this.txtBack.Name = "txtBack";
            this.txtBack.Size = new System.Drawing.Size(226, 21);
            this.txtBack.TabIndex = 16;
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.Location = new System.Drawing.Point(10, 65);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(37, 12);
            this.lblMark.TabIndex = 15;
            this.lblMark.Text = "마  킹";
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Location = new System.Drawing.Point(10, 39);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(37, 12);
            this.lblBack.TabIndex = 14;
            this.lblBack.Text = "배  경";
            // 
            // picbView
            // 
            this.picbView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbView.Location = new System.Drawing.Point(10, 163);
            this.picbView.Name = "picbView";
            this.picbView.Size = new System.Drawing.Size(356, 310);
            this.picbView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbView.TabIndex = 13;
            this.picbView.TabStop = false;
            // 
            // ofdFile
            // 
            this.ofdFile.Filter = "JPEG Images(*.jpg,*.jpeg)|*.jpg;*.jpeg|GIF Image(*.gif)|*.gif|Bitmap(*.bmp)|*.bmp" +
    "|All Image Format|*.jpg;*.jpeg;*.gif*.bmp";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(291, 91);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 40);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "저장하기";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // sfdImage
            // 
            this.sfdImage.Filter = "이미지 파일(*.jpg)|*.jpg";
            // 
            // msBar
            // 
            this.msBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.폰트설정ToolStripMenuItem});
            this.msBar.Location = new System.Drawing.Point(0, 0);
            this.msBar.Name = "msBar";
            this.msBar.Size = new System.Drawing.Size(376, 24);
            this.msBar.TabIndex = 24;
            this.msBar.Text = "menuStrip1";
            // 
            // 폰트설정ToolStripMenuItem
            // 
            this.폰트설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.글꼴ToolStripMenuItem,
            this.색상ToolStripMenuItem});
            this.폰트설정ToolStripMenuItem.Name = "폰트설정ToolStripMenuItem";
            this.폰트설정ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.폰트설정ToolStripMenuItem.Text = "폰트 설정";
            // 
            // 글꼴ToolStripMenuItem
            // 
            this.글꼴ToolStripMenuItem.Name = "글꼴ToolStripMenuItem";
            this.글꼴ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.글꼴ToolStripMenuItem.Text = "글꼴";
            this.글꼴ToolStripMenuItem.Click += new System.EventHandler(this.글꼴ToolStripMenuItem_Click);
            // 
            // 색상ToolStripMenuItem
            // 
            this.색상ToolStripMenuItem.Name = "색상ToolStripMenuItem";
            this.색상ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.색상ToolStripMenuItem.Text = "색상";
            this.색상ToolStripMenuItem.Click += new System.EventHandler(this.색상ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 481);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lblOpacity);
            this.Controls.Add(this.hsbOpacity);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtMark);
            this.Controls.Add(this.txtBack);
            this.Controls.Add(this.lblMark);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.picbView);
            this.Controls.Add(this.msBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msBar;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "워터마킹";
            ((System.ComponentModel.ISupportInitialize)(this.picbView)).EndInit();
            this.msBar.ResumeLayout(false);
            this.msBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnView;
        internal System.Windows.Forms.Label lblOpacity;
        internal System.Windows.Forms.HScrollBar hsbOpacity;
        internal System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.TextBox txtMark;
        internal System.Windows.Forms.TextBox txtBack;
        internal System.Windows.Forms.Label lblMark;
        internal System.Windows.Forms.Label lblBack;
        internal System.Windows.Forms.PictureBox picbView;
        internal System.Windows.Forms.OpenFileDialog ofdFile;
        internal System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog sfdImage;
        private System.Windows.Forms.FontDialog fdlg;
        private System.Windows.Forms.ColorDialog cdlg;
        private System.Windows.Forms.MenuStrip msBar;
        private System.Windows.Forms.ToolStripMenuItem 폰트설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 글꼴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 색상ToolStripMenuItem;
    }
}



