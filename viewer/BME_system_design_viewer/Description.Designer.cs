namespace BME_system_design_viewer
{
    partial class Description
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Description));
            this.label2 = new System.Windows.Forms.Label();
            this.startImg = new System.Windows.Forms.PictureBox();
            this.startBtn = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.startImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(854, 502);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "게임 시작";
            // 
            // startImg
            // 
            this.startImg.Location = new System.Drawing.Point(854, 235);
            this.startImg.Name = "startImg";
            this.startImg.Size = new System.Drawing.Size(90, 90);
            this.startImg.TabIndex = 6;
            this.startImg.TabStop = false;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(826, 340);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(150, 150);
            this.startBtn.TabIndex = 4;
            this.startBtn.TabStop = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(36, 16);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(489, 511);
            this.axWindowsMediaPlayer1.TabIndex = 7;
            // 
            // Description
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.startImg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Description";
            this.Size = new System.Drawing.Size(1000, 540);
            this.Load += new System.EventHandler(this.Description_Load);
            ((System.ComponentModel.ISupportInitialize)(this.startImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox startBtn;
        private System.Windows.Forms.PictureBox startImg;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}
