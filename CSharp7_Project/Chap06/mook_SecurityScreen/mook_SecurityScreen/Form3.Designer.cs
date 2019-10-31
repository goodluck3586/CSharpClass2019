namespace mook_SecurityScreen
{
    partial class Form3
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
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblRePwd = new System.Windows.Forms.Label();
            this.txtRePwd = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.bntSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(66, 12);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(130, 21);
            this.txtPwd.TabIndex = 0;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(7, 15);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(53, 12);
            this.lblPwd.TabIndex = 1;
            this.lblPwd.Text = "비밀번호";
            // 
            // lblRePwd
            // 
            this.lblRePwd.AutoSize = true;
            this.lblRePwd.Location = new System.Drawing.Point(7, 42);
            this.lblRePwd.Name = "lblRePwd";
            this.lblRePwd.Size = new System.Drawing.Size(53, 12);
            this.lblRePwd.TabIndex = 3;
            this.lblRePwd.Text = "확      인";
            // 
            // txtRePwd
            // 
            this.txtRePwd.Location = new System.Drawing.Point(66, 39);
            this.txtRePwd.Name = "txtRePwd";
            this.txtRePwd.PasswordChar = '*';
            this.txtRePwd.Size = new System.Drawing.Size(130, 21);
            this.txtRePwd.TabIndex = 2;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(7, 70);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(53, 12);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "결      과";
            // 
            // bntSave
            // 
            this.bntSave.Location = new System.Drawing.Point(202, 10);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(75, 50);
            this.bntSave.TabIndex = 5;
            this.bntSave.Text = "저  장";
            this.bntSave.UseVisualStyleBackColor = true;
            this.bntSave.Click += new System.EventHandler(this.bntSave_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 91);
            this.Controls.Add(this.bntSave);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblRePwd);
            this.Controls.Add(this.txtRePwd);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.txtPwd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "비밀번호 생성";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblRePwd;
        private System.Windows.Forms.TextBox txtRePwd;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button bntSave;
    }
}