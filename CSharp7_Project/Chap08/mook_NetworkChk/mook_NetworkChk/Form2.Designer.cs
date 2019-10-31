namespace mook_NetworkChk
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
            this.gbConfig = new System.Windows.Forms.GroupBox();
            this.txtHostDescription = new System.Windows.Forms.TextBox();
            this.lblHost = new System.Windows.Forms.Label();
            this.txtHostName = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConfig
            // 
            this.gbConfig.Controls.Add(this.txtHostDescription);
            this.gbConfig.Controls.Add(this.lblHost);
            this.gbConfig.Controls.Add(this.txtHostName);
            this.gbConfig.Controls.Add(this.lblDesc);
            this.gbConfig.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbConfig.ForeColor = System.Drawing.Color.Black;
            this.gbConfig.Location = new System.Drawing.Point(12, 12);
            this.gbConfig.Name = "gbConfig";
            this.gbConfig.Size = new System.Drawing.Size(283, 100);
            this.gbConfig.TabIndex = 18;
            this.gbConfig.TabStop = false;
            this.gbConfig.Text = "도메인 추가";
            // 
            // txtHostDescription
            // 
            this.txtHostDescription.AccessibleDescription = "";
            this.txtHostDescription.AccessibleName = "";
            this.txtHostDescription.Location = new System.Drawing.Point(112, 61);
            this.txtHostDescription.MaxLength = 70;
            this.txtHostDescription.Name = "txtHostDescription";
            this.txtHostDescription.Size = new System.Drawing.Size(154, 21);
            this.txtHostDescription.TabIndex = 11;
            // 
            // lblHost
            // 
            this.lblHost.AccessibleDescription = "HostField";
            this.lblHost.AccessibleName = "HostField";
            this.lblHost.ForeColor = System.Drawing.Color.Black;
            this.lblHost.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHost.Location = new System.Drawing.Point(4, 17);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(104, 32);
            this.lblHost.TabIndex = 11;
            this.lblHost.Text = "도메인/아이피 :";
            this.lblHost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHostName
            // 
            this.txtHostName.AccessibleDescription = "";
            this.txtHostName.AccessibleName = "";
            this.txtHostName.Location = new System.Drawing.Point(112, 24);
            this.txtHostName.MaxLength = 70;
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.Size = new System.Drawing.Size(154, 21);
            this.txtHostName.TabIndex = 10;
            // 
            // lblDesc
            // 
            this.lblDesc.AccessibleDescription = "Description";
            this.lblDesc.AccessibleName = "Description";
            this.lblDesc.ForeColor = System.Drawing.Color.Black;
            this.lblDesc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDesc.Location = new System.Drawing.Point(8, 61);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(100, 16);
            this.lblDesc.TabIndex = 12;
            this.lblDesc.Text = "설명 :";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Location = new System.Drawing.Point(316, 66);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "취소";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Location = new System.Drawing.Point(316, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "추가";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(412, 128);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "호스트 추가";
            this.gbConfig.ResumeLayout(false);
            this.gbConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConfig;
        internal System.Windows.Forms.TextBox txtHostDescription;
        internal System.Windows.Forms.Label lblHost;
        internal System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtHostName;
    }
}