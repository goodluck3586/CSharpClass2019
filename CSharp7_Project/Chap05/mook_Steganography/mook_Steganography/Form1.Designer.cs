namespace mook_Steganography
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
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.sfdFile = new System.Windows.Forms.SaveFileDialog();
            this.pbImgView = new System.Windows.Forms.PictureBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.plStegano = new System.Windows.Forms.Panel();
            this.lbResult = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgView)).BeginInit();
            this.plStegano.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(674, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.열기ToolStripMenuItem,
            this.toolStripSeparator1,
            this.종료ToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fileToolStripMenuItem.Text = "파일";
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.열기ToolStripMenuItem.Text = "열기(&O)";
            this.열기ToolStripMenuItem.Click += new System.EventHandler(this.열기ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.종료ToolStripMenuItem.Text = "종료(&X)";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // ofdFile
            // 
            this.ofdFile.Filter = "mage Files (*.jpg; *.png; *.bmp)|*.jpg; *.png; *.bmp\"";
            // 
            // sfdFile
            // 
            this.sfdFile.Filter = "Png Image|*.png|Bitmap Image|*.bmp";
            // 
            // pbImgView
            // 
            this.pbImgView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImgView.Location = new System.Drawing.Point(12, 34);
            this.pbImgView.Name = "pbImgView";
            this.pbImgView.Size = new System.Drawing.Size(377, 325);
            this.pbImgView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImgView.TabIndex = 1;
            this.pbImgView.TabStop = false;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(10, 25);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(41, 12);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "데이터";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(57, 16);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtData.Size = new System.Drawing.Size(197, 184);
            this.txtData.TabIndex = 3;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(57, 206);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(197, 21);
            this.txtKey.TabIndex = 5;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(10, 209);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(41, 12);
            this.lblKey.TabIndex = 4;
            this.lblKey.Text = "비밀키";
            // 
            // plStegano
            // 
            this.plStegano.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plStegano.Controls.Add(this.lbResult);
            this.plStegano.Controls.Add(this.btnDecrypt);
            this.plStegano.Controls.Add(this.btnEncrypt);
            this.plStegano.Controls.Add(this.txtKey);
            this.plStegano.Controls.Add(this.txtData);
            this.plStegano.Controls.Add(this.lblData);
            this.plStegano.Controls.Add(this.lblKey);
            this.plStegano.Location = new System.Drawing.Point(395, 34);
            this.plStegano.Name = "plStegano";
            this.plStegano.Size = new System.Drawing.Size(267, 325);
            this.plStegano.TabIndex = 6;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(12, 288);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(52, 12);
            this.lbResult.TabIndex = 8;
            this.lbResult.Text = "Result : ";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(141, 249);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(113, 23);
            this.btnDecrypt.TabIndex = 7;
            this.btnDecrypt.Text = "복호화";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(12, 249);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(113, 23);
            this.btnEncrypt.TabIndex = 6;
            this.btnEncrypt.Text = "암호화";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 371);
            this.Controls.Add(this.plStegano);
            this.Controls.Add(this.pbImgView);
            this.Controls.Add(this.msMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msMenu;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "스테가노그래피";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgView)).EndInit();
            this.plStegano.ResumeLayout(false);
            this.plStegano.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.SaveFileDialog sfdFile;
        private System.Windows.Forms.PictureBox pbImgView;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Panel plStegano;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label lbResult;
    }
}

