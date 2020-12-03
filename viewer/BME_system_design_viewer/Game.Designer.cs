namespace BME_system_design_viewer
{
    partial class Game
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
            this.computerHandImg = new System.Windows.Forms.PictureBox();
            this.userHandImg = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stageLabel = new System.Windows.Forms.Label();
            this.counterLabel = new System.Windows.Forms.Label();
            this.gameImg = new System.Windows.Forms.PictureBox();
            this.levelUpImg = new System.Windows.Forms.PictureBox();
            this.levelDownImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.computerHandImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userHandImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelUpImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelDownImage)).BeginInit();
            this.SuspendLayout();
            // 
            // computerHandImg
            // 
            this.computerHandImg.Location = new System.Drawing.Point(71, 208);
            this.computerHandImg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.computerHandImg.Name = "computerHandImg";
            this.computerHandImg.Size = new System.Drawing.Size(250, 240);
            this.computerHandImg.TabIndex = 2;
            this.computerHandImg.TabStop = false;
            // 
            // userHandImg
            // 
            this.userHandImg.Location = new System.Drawing.Point(673, 208);
            this.userHandImg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.userHandImg.Name = "userHandImg";
            this.userHandImg.Size = new System.Drawing.Size(250, 240);
            this.userHandImg.TabIndex = 2;
            this.userHandImg.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(134, 469);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Follow Me!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(739, 469);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "나의 손동작";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(353, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "난이도";
            // 
            // stageLabel
            // 
            this.stageLabel.AutoSize = true;
            this.stageLabel.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.stageLabel.Location = new System.Drawing.Point(451, 139);
            this.stageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stageLabel.Name = "stageLabel";
            this.stageLabel.Size = new System.Drawing.Size(40, 30);
            this.stageLabel.TabIndex = 3;
            this.stageLabel.Text = "___";
            // 
            // counterLabel
            // 
            this.counterLabel.AutoSize = true;
            this.counterLabel.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.counterLabel.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.counterLabel.Location = new System.Drawing.Point(958, 33);
            this.counterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(0, 54);
            this.counterLabel.TabIndex = 4;
            // 
            // gameImg
            // 
            this.gameImg.Location = new System.Drawing.Point(250, 12);
            this.gameImg.Name = "gameImg";
            this.gameImg.Size = new System.Drawing.Size(492, 95);
            this.gameImg.TabIndex = 12;
            this.gameImg.TabStop = false;
            // 
            // levelUpImg
            // 
            this.levelUpImg.Location = new System.Drawing.Point(515, 129);
            this.levelUpImg.Name = "levelUpImg";
            this.levelUpImg.Size = new System.Drawing.Size(52, 53);
            this.levelUpImg.TabIndex = 13;
            this.levelUpImg.TabStop = false;
            this.levelUpImg.Click += new System.EventHandler(this.levelUpImg_Click);
            // 
            // levelDownImage
            // 
            this.levelDownImage.Location = new System.Drawing.Point(587, 129);
            this.levelDownImage.Name = "levelDownImage";
            this.levelDownImage.Size = new System.Drawing.Size(52, 53);
            this.levelDownImage.TabIndex = 13;
            this.levelDownImage.TabStop = false;
            this.levelDownImage.Click += new System.EventHandler(this.levelDownImage_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.levelDownImage);
            this.Controls.Add(this.levelUpImg);
            this.Controls.Add(this.gameImg);
            this.Controls.Add(this.counterLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stageLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userHandImg);
            this.Controls.Add(this.computerHandImg);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Game";
            this.Size = new System.Drawing.Size(1000, 540);
            this.Load += new System.EventHandler(this.initGame);
            ((System.ComponentModel.ISupportInitialize)(this.computerHandImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userHandImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelUpImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelDownImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox computerHandImg;
        private System.Windows.Forms.PictureBox userHandImg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label stageLabel;
        private System.Windows.Forms.Label counterLabel;
        private System.Windows.Forms.PictureBox gameImg;
        private System.Windows.Forms.PictureBox levelUpImg;
        private System.Windows.Forms.PictureBox levelDownImage;
    }
}
