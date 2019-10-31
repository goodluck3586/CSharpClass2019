namespace mook_FileCM
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
            this.pgbCopy = new System.Windows.Forms.ProgressBar();
            this.lblCopy = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pgbCopy
            // 
            this.pgbCopy.Location = new System.Drawing.Point(107, 31);
            this.pgbCopy.Name = "pgbCopy";
            this.pgbCopy.Size = new System.Drawing.Size(460, 11);
            this.pgbCopy.Step = 1;
            this.pgbCopy.TabIndex = 0;
            // 
            // lblCopy
            // 
            this.lblCopy.AutoSize = true;
            this.lblCopy.Location = new System.Drawing.Point(24, 30);
            this.lblCopy.Name = "lblCopy";
            this.lblCopy.Size = new System.Drawing.Size(61, 12);
            this.lblCopy.TabIndex = 1;
            this.lblCopy.Text = "복 사 : 0%";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(24, 9);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(41, 12);
            this.lblFileName.TabIndex = 2;
            this.lblFileName.Text = "파 일 :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 65);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.lblCopy);
            this.Controls.Add(this.pgbCopy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "파일 복사";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbCopy;
        private System.Windows.Forms.Label lblCopy;
        private System.Windows.Forms.Label lblFileName;
    }
}