namespace mook_DataLoading
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
            this.lbltmp = new System.Windows.Forms.Label();
            this.picLoad = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltmp
            // 
            this.lbltmp.AutoSize = true;
            this.lbltmp.Location = new System.Drawing.Point(0, 0);
            this.lbltmp.Name = "lbltmp";
            this.lbltmp.Size = new System.Drawing.Size(0, 12);
            this.lbltmp.TabIndex = 1;
            // 
            // picLoad
            // 
            this.picLoad.Image = global::mook_DataLoading.Properties.Resources.loading_bar;
            this.picLoad.Location = new System.Drawing.Point(-3, 0);
            this.picLoad.Name = "picLoad";
            this.picLoad.Size = new System.Drawing.Size(153, 51);
            this.picLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLoad.TabIndex = 0;
            this.picLoad.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(148, 38);
            this.Controls.Add(this.lbltmp);
            this.Controls.Add(this.picLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "로딩";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLoad;
        private System.Windows.Forms.Label lbltmp;
    }
}