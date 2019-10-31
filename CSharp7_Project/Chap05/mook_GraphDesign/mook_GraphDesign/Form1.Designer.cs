namespace mook_GraphDesign
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
            this.btnGraph = new System.Windows.Forms.Button();
            this.btnBar = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.GraphCore = new mook_GraphCore.mook_GraphCore();
            this.SuspendLayout();
            // 
            // btnGraph
            // 
            this.btnGraph.Location = new System.Drawing.Point(437, 225);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(64, 25);
            this.btnGraph.TabIndex = 7;
            this.btnGraph.Text = "그래프";
            this.btnGraph.UseVisualStyleBackColor = true;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // btnBar
            // 
            this.btnBar.Location = new System.Drawing.Point(508, 225);
            this.btnBar.Name = "btnBar";
            this.btnBar.Size = new System.Drawing.Size(64, 25);
            this.btnBar.TabIndex = 6;
            this.btnBar.Text = "막대";
            this.btnBar.UseVisualStyleBackColor = true;
            this.btnBar.Click += new System.EventHandler(this.btnBar_Click);
            // 
            // Time
            // 
            this.Time.Enabled = true;
            this.Time.Interval = 1000;
            this.Time.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // GraphCore
            // 
            this.GraphCore.Location = new System.Drawing.Point(12, 12);
            this.GraphCore.Name = "GraphCore";
            this.GraphCore.Size = new System.Drawing.Size(560, 207);
            this.GraphCore.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 262);
            this.Controls.Add(this.GraphCore);
            this.Controls.Add(this.btnGraph);
            this.Controls.Add(this.btnBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "그래프 그리기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.Button btnBar;
        private System.Windows.Forms.Timer Time;
        private mook_GraphCore.mook_GraphCore GraphCore;
    }
}
