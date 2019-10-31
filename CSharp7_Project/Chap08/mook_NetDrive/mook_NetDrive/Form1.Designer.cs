namespace mook_NetDrive
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
            this.gbConfig = new System.Windows.Forms.GroupBox();
            this.txtDrive = new System.Windows.Forms.TextBox();
            this.lblDrive = new System.Windows.Forms.Label();
            this.txtUserPwd = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtNDrive = new System.Windows.Forms.TextBox();
            this.lblNDrive = new System.Windows.Forms.Label();
            this.lvFile = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnConnector = new System.Windows.Forms.Button();
            this.btnDisConn = new System.Windows.Forms.Button();
            this.gbConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConfig
            // 
            this.gbConfig.Controls.Add(this.txtDrive);
            this.gbConfig.Controls.Add(this.lblDrive);
            this.gbConfig.Controls.Add(this.txtUserPwd);
            this.gbConfig.Controls.Add(this.lblPwd);
            this.gbConfig.Controls.Add(this.txtUserID);
            this.gbConfig.Controls.Add(this.lblId);
            this.gbConfig.Controls.Add(this.txtNDrive);
            this.gbConfig.Controls.Add(this.lblNDrive);
            this.gbConfig.Location = new System.Drawing.Point(12, 12);
            this.gbConfig.Name = "gbConfig";
            this.gbConfig.Size = new System.Drawing.Size(359, 100);
            this.gbConfig.TabIndex = 78;
            this.gbConfig.TabStop = false;
            this.gbConfig.Text = "네트워드 드라이브 연결";
            // 
            // txtDrive
            // 
            this.txtDrive.Location = new System.Drawing.Point(294, 20);
            this.txtDrive.Name = "txtDrive";
            this.txtDrive.Size = new System.Drawing.Size(50, 21);
            this.txtDrive.TabIndex = 2;
            // 
            // lblDrive
            // 
            this.lblDrive.AutoSize = true;
            this.lblDrive.Location = new System.Drawing.Point(251, 28);
            this.lblDrive.Name = "lblDrive";
            this.lblDrive.Size = new System.Drawing.Size(33, 12);
            this.lblDrive.TabIndex = 63;
            this.lblDrive.Text = "Drive";
            // 
            // txtUserPwd
            // 
            this.txtUserPwd.Location = new System.Drawing.Point(247, 59);
            this.txtUserPwd.Name = "txtUserPwd";
            this.txtUserPwd.Size = new System.Drawing.Size(97, 21);
            this.txtUserPwd.TabIndex = 4;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(181, 65);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(56, 12);
            this.lblPwd.TabIndex = 61;
            this.lblPwd.Text = "UserPwd";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(71, 59);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(98, 21);
            this.txtUserID.TabIndex = 3;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(8, 65);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(42, 12);
            this.lblId.TabIndex = 59;
            this.lblId.Text = "UserID";
            // 
            // txtNDrive
            // 
            this.txtNDrive.Location = new System.Drawing.Point(71, 20);
            this.txtNDrive.Name = "txtNDrive";
            this.txtNDrive.Size = new System.Drawing.Size(170, 21);
            this.txtNDrive.TabIndex = 1;
            // 
            // lblNDrive
            // 
            this.lblNDrive.AutoSize = true;
            this.lblNDrive.Location = new System.Drawing.Point(8, 25);
            this.lblNDrive.Name = "lblNDrive";
            this.lblNDrive.Size = new System.Drawing.Size(42, 12);
            this.lblNDrive.TabIndex = 57;
            this.lblNDrive.Text = "NDrive";
            // 
            // lvFile
            // 
            this.lvFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chDate,
            this.chType,
            this.chSize});
            this.lvFile.FullRowSelect = true;
            this.lvFile.GridLines = true;
            this.lvFile.Location = new System.Drawing.Point(12, 118);
            this.lvFile.Name = "lvFile";
            this.lvFile.Size = new System.Drawing.Size(643, 176);
            this.lvFile.TabIndex = 79;
            this.lvFile.TabStop = false;
            this.lvFile.UseCompatibleStateImageBehavior = false;
            this.lvFile.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "이름";
            this.chName.Width = 250;
            // 
            // chDate
            // 
            this.chDate.Text = "수정날짜";
            this.chDate.Width = 150;
            // 
            // chType
            // 
            this.chType.Text = "유형";
            this.chType.Width = 100;
            // 
            // chSize
            // 
            this.chSize.Text = "크기";
            this.chSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chSize.Width = 100;
            // 
            // btnConnector
            // 
            this.btnConnector.Location = new System.Drawing.Point(421, 29);
            this.btnConnector.Name = "btnConnector";
            this.btnConnector.Size = new System.Drawing.Size(114, 60);
            this.btnConnector.TabIndex = 5;
            this.btnConnector.Text = "연결";
            this.btnConnector.UseVisualStyleBackColor = true;
            this.btnConnector.Click += new System.EventHandler(this.btnConnector_Click);
            // 
            // btnDisConn
            // 
            this.btnDisConn.Location = new System.Drawing.Point(541, 29);
            this.btnDisConn.Name = "btnDisConn";
            this.btnDisConn.Size = new System.Drawing.Size(114, 60);
            this.btnDisConn.TabIndex = 6;
            this.btnDisConn.Text = "연결끊기";
            this.btnDisConn.UseVisualStyleBackColor = true;
            this.btnDisConn.Click += new System.EventHandler(this.btnDisConn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 306);
            this.Controls.Add(this.btnDisConn);
            this.Controls.Add(this.btnConnector);
            this.Controls.Add(this.lvFile);
            this.Controls.Add(this.gbConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "네트워크 드라이브";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbConfig.ResumeLayout(false);
            this.gbConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConfig;
        private System.Windows.Forms.TextBox txtDrive;
        private System.Windows.Forms.Label lblDrive;
        private System.Windows.Forms.TextBox txtUserPwd;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtNDrive;
        private System.Windows.Forms.Label lblNDrive;
        private System.Windows.Forms.ListView lvFile;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chDate;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.ColumnHeader chSize;
        private System.Windows.Forms.Button btnConnector;
        private System.Windows.Forms.Button btnDisConn;
    }
}
