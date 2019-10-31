namespace mook_Notepad
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.rdb02 = new System.Windows.Forms.RadioButton();
            this.rdb01 = new System.Windows.Forms.RadioButton();
            this.chOption = new System.Windows.Forms.CheckBox();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.lblWord = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(336, 49);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "취  소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(336, 11);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 16;
            this.btnOk.Text = "다음 찾기";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.rdb02);
            this.groupBox.Controls.Add(this.rdb01);
            this.groupBox.Location = new System.Drawing.Point(128, 40);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(200, 48);
            this.groupBox.TabIndex = 15;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "방향";
            // 
            // rdb02
            // 
            this.rdb02.AutoSize = true;
            this.rdb02.Checked = true;
            this.rdb02.Location = new System.Drawing.Point(98, 20);
            this.rdb02.Name = "rdb02";
            this.rdb02.Size = new System.Drawing.Size(59, 16);
            this.rdb02.TabIndex = 1;
            this.rdb02.TabStop = true;
            this.rdb02.Text = "아래쪽";
            this.rdb02.UseVisualStyleBackColor = true;
            // 
            // rdb01
            // 
            this.rdb01.AutoSize = true;
            this.rdb01.Location = new System.Drawing.Point(34, 20);
            this.rdb01.Name = "rdb01";
            this.rdb01.Size = new System.Drawing.Size(47, 16);
            this.rdb01.TabIndex = 0;
            this.rdb01.Text = "위쪽";
            this.rdb01.UseVisualStyleBackColor = true;
            // 
            // chOption
            // 
            this.chOption.AutoSize = true;
            this.chOption.Location = new System.Drawing.Point(16, 56);
            this.chOption.Name = "chOption";
            this.chOption.Size = new System.Drawing.Size(106, 16);
            this.chOption.TabIndex = 14;
            this.chOption.Text = "대/소문자 구분";
            this.chOption.UseVisualStyleBackColor = true;
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(76, 13);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(252, 21);
            this.txtWord.TabIndex = 13;
            this.txtWord.TextChanged += new System.EventHandler(this.txtWord_TextChanged);
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(14, 16);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(57, 12);
            this.lblWord.TabIndex = 12;
            this.lblWord.Text = "찾을 내용";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 99);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.chOption);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.lblWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "찾 기";
            this.TopMost = true;
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnOk;
        internal System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.GroupBox groupBox;
        internal System.Windows.Forms.RadioButton rdb02;
        internal System.Windows.Forms.RadioButton rdb01;
        internal System.Windows.Forms.CheckBox chOption;
    }
}