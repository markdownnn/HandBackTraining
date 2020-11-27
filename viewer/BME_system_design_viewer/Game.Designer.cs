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
            this.label1 = new System.Windows.Forms.Label();
            this.computerHandImg = new System.Windows.Forms.PictureBox();
            this.userHandImg = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.displayStage = new System.Windows.Forms.Label();
            this.displayCurrentProblem = new System.Windows.Forms.Label();
            this.displayCounter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.computerHandImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userHandImg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.label1.Location = new System.Drawing.Point(684, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "N-back Training";
            // 
            // computerHandImg
            // 
            this.computerHandImg.Location = new System.Drawing.Point(94, 150);
            this.computerHandImg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.computerHandImg.Name = "computerHandImg";
            this.computerHandImg.Size = new System.Drawing.Size(250, 240);
            this.computerHandImg.TabIndex = 2;
            this.computerHandImg.TabStop = false;
            // 
            // userHandImg
            // 
            this.userHandImg.Location = new System.Drawing.Point(693, 150);
            this.userHandImg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.userHandImg.Name = "userHandImg";
            this.userHandImg.Size = new System.Drawing.Size(250, 240);
            this.userHandImg.TabIndex = 2;
            this.userHandImg.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(157, 411);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Follow Me!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(759, 411);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "나의 손동작";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(759, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "난이도";
            // 
            // displayStage
            // 
            this.displayStage.AutoSize = true;
            this.displayStage.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.displayStage.Location = new System.Drawing.Point(849, 93);
            this.displayStage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.displayStage.Name = "displayStage";
            this.displayStage.Size = new System.Drawing.Size(43, 22);
            this.displayStage.TabIndex = 3;
            this.displayStage.Text = "___";
            // 
            // displayCurrentProblem
            // 
            this.displayCurrentProblem.AutoSize = true;
            this.displayCurrentProblem.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.displayCurrentProblem.Location = new System.Drawing.Point(194, 111);
            this.displayCurrentProblem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.displayCurrentProblem.Name = "displayCurrentProblem";
            this.displayCurrentProblem.Size = new System.Drawing.Size(43, 22);
            this.displayCurrentProblem.TabIndex = 3;
            this.displayCurrentProblem.Text = "___";
            // 
            // displayCounter
            // 
            this.displayCounter.AutoSize = true;
            this.displayCounter.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.displayCounter.ForeColor = System.Drawing.Color.Red;
            this.displayCounter.Location = new System.Drawing.Point(469, 230);
            this.displayCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.displayCounter.Name = "displayCounter";
            this.displayCounter.Size = new System.Drawing.Size(0, 96);
            this.displayCounter.TabIndex = 4;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.displayCounter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.displayStage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.displayCurrentProblem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userHandImg);
            this.Controls.Add(this.computerHandImg);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Game";
            this.Size = new System.Drawing.Size(1000, 540);
            this.Load += new System.EventHandler(this.initGame);
            ((System.ComponentModel.ISupportInitialize)(this.computerHandImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userHandImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox computerHandImg;
        private System.Windows.Forms.PictureBox userHandImg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label displayStage;
        private System.Windows.Forms.Label displayCurrentProblem;
        private System.Windows.Forms.Label displayCounter;
    }
}
