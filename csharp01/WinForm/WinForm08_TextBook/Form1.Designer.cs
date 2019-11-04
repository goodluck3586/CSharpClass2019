namespace WinForm08_TextBook
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFont = new System.Windows.Forms.ComboBox();
            this.chbBold = new System.Windows.Forms.CheckBox();
            this.chbItalic = new System.Windows.Forms.CheckBox();
            this.txtSampleText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSampleText);
            this.groupBox1.Controls.Add(this.chbItalic);
            this.groupBox1.Controls.Add(this.chbBold);
            this.groupBox1.Controls.Add(this.cboFont);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ComboBox, CheckBox, TextBox";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Font : ";
            // 
            // cboFont
            // 
            this.cboFont.FormattingEnabled = true;
            this.cboFont.Location = new System.Drawing.Point(79, 33);
            this.cboFont.Name = "cboFont";
            this.cboFont.Size = new System.Drawing.Size(194, 23);
            this.cboFont.TabIndex = 1;
            this.cboFont.SelectedIndexChanged += new System.EventHandler(this.cboFont_SelectedIndexChanged);
            // 
            // chbBold
            // 
            this.chbBold.AutoSize = true;
            this.chbBold.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chbBold.Location = new System.Drawing.Point(292, 37);
            this.chbBold.Name = "chbBold";
            this.chbBold.Size = new System.Drawing.Size(61, 19);
            this.chbBold.TabIndex = 2;
            this.chbBold.Text = "굵게";
            this.chbBold.UseVisualStyleBackColor = true;
            this.chbBold.CheckedChanged += new System.EventHandler(this.chbBold_CheckedChanged);
            // 
            // chbItalic
            // 
            this.chbItalic.AutoSize = true;
            this.chbItalic.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chbItalic.Location = new System.Drawing.Point(371, 35);
            this.chbItalic.Name = "chbItalic";
            this.chbItalic.Size = new System.Drawing.Size(74, 19);
            this.chbItalic.TabIndex = 3;
            this.chbItalic.Text = "이텔릭";
            this.chbItalic.UseVisualStyleBackColor = true;
            this.chbItalic.CheckedChanged += new System.EventHandler(this.chbItalic_CheckedChanged);
            // 
            // txtSampleText
            // 
            this.txtSampleText.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSampleText.Location = new System.Drawing.Point(21, 80);
            this.txtSampleText.Name = "txtSampleText";
            this.txtSampleText.Size = new System.Drawing.Size(477, 45);
            this.txtSampleText.TabIndex = 4;
            this.txtSampleText.Text = "Hello, C#";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 649);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSampleText;
        private System.Windows.Forms.CheckBox chbItalic;
        private System.Windows.Forms.CheckBox chbBold;
        private System.Windows.Forms.ComboBox cboFont;
        private System.Windows.Forms.Label label1;
    }
}

