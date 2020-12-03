namespace BME_system_design_viewer
{
    partial class Main
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
            this.startBtn = new System.Windows.Forms.PictureBox();
            this.descriptionBtn = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lionImg = new System.Windows.Forms.PictureBox();
            this.startImg = new System.Windows.Forms.PictureBox();
            this.descriptionImg = new System.Windows.Forms.PictureBox();
            this.exitImg = new System.Windows.Forms.PictureBox();
            this.titleImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.startBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lionImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleImg)).BeginInit();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(54, 248);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(150, 150);
            this.startBtn.TabIndex = 2;
            this.startBtn.TabStop = false;
            this.startBtn.Click += new System.EventHandler(this.startClicked);
            // 
            // descriptionBtn
            // 
            this.descriptionBtn.Location = new System.Drawing.Point(326, 248);
            this.descriptionBtn.Name = "descriptionBtn";
            this.descriptionBtn.Size = new System.Drawing.Size(150, 150);
            this.descriptionBtn.TabIndex = 2;
            this.descriptionBtn.TabStop = false;
            this.descriptionBtn.Click += new System.EventHandler(this.descriptionClicked);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(596, 248);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(150, 150);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.TabStop = false;
            this.exitBtn.Click += new System.EventHandler(this.quitClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(82, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "게임 시작";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(359, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "게임 방법";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(645, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "끝내기";
            // 
            // lionImg
            // 
            this.lionImg.Location = new System.Drawing.Point(669, 17);
            this.lionImg.Name = "lionImg";
            this.lionImg.Size = new System.Drawing.Size(118, 114);
            this.lionImg.TabIndex = 2;
            this.lionImg.TabStop = false;
            // 
            // startImg
            // 
            this.startImg.Location = new System.Drawing.Point(82, 137);
            this.startImg.Name = "startImg";
            this.startImg.Size = new System.Drawing.Size(90, 90);
            this.startImg.TabIndex = 2;
            this.startImg.TabStop = false;
            // 
            // descriptionImg
            // 
            this.descriptionImg.Location = new System.Drawing.Point(359, 137);
            this.descriptionImg.Name = "descriptionImg";
            this.descriptionImg.Size = new System.Drawing.Size(90, 90);
            this.descriptionImg.TabIndex = 2;
            this.descriptionImg.TabStop = false;
            // 
            // exitImg
            // 
            this.exitImg.Location = new System.Drawing.Point(626, 137);
            this.exitImg.Name = "exitImg";
            this.exitImg.Size = new System.Drawing.Size(90, 90);
            this.exitImg.TabIndex = 2;
            this.exitImg.TabStop = false;
            // 
            // titleImg
            // 
            this.titleImg.Location = new System.Drawing.Point(3, 30);
            this.titleImg.Name = "titleImg";
            this.titleImg.Size = new System.Drawing.Size(660, 68);
            this.titleImg.TabIndex = 5;
            this.titleImg.TabStop = false;
            // 
            // Main
            // 
            this.Controls.Add(this.titleImg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.descriptionBtn);
            this.Controls.Add(this.lionImg);
            this.Controls.Add(this.exitImg);
            this.Controls.Add(this.descriptionImg);
            this.Controls.Add(this.startImg);
            this.Controls.Add(this.startBtn);
            this.Name = "Main";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.mainLoad);
            ((System.ComponentModel.ISupportInitialize)(this.startBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lionImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox startBtn;
        private System.Windows.Forms.PictureBox descriptionBtn;
        private System.Windows.Forms.PictureBox exitBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox lionImg;
        private System.Windows.Forms.PictureBox startImg;
        private System.Windows.Forms.PictureBox descriptionImg;
        private System.Windows.Forms.PictureBox exitImg;
        private System.Windows.Forms.PictureBox titleImg;
    }
}
