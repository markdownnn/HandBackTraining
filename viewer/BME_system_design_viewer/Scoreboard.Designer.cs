namespace BME_system_design_viewer
{
    partial class Scoreboard
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.correctLabel = new System.Windows.Forms.Label();
            this.wrongLabel = new System.Windows.Forms.Label();
            this.retry = new System.Windows.Forms.PictureBox();
            this.returnHome = new System.Windows.Forms.PictureBox();
            this.retryHand = new System.Windows.Forms.PictureBox();
            this.returnHomeHand = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.retry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retryHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnHomeHand)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "게임 결과";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(120, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "맞춘 갯수";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(120, 266);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "틀린 갯수";
            // 
            // correctLabel
            // 
            this.correctLabel.AutoSize = true;
            this.correctLabel.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.correctLabel.Location = new System.Drawing.Point(342, 199);
            this.correctLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(40, 30);
            this.correctLabel.TabIndex = 3;
            this.correctLabel.Text = "___";
            // 
            // wrongLabel
            // 
            this.wrongLabel.AutoSize = true;
            this.wrongLabel.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.wrongLabel.Location = new System.Drawing.Point(342, 266);
            this.wrongLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wrongLabel.Name = "wrongLabel";
            this.wrongLabel.Size = new System.Drawing.Size(40, 30);
            this.wrongLabel.TabIndex = 3;
            this.wrongLabel.Text = "___";
            // 
            // retry
            // 
            this.retry.Location = new System.Drawing.Point(619, 375);
            this.retry.Name = "retry";
            this.retry.Size = new System.Drawing.Size(147, 136);
            this.retry.TabIndex = 4;
            this.retry.TabStop = false;
            this.retry.Click += new System.EventHandler(this.retry_Click);
            // 
            // returnHome
            // 
            this.returnHome.Location = new System.Drawing.Point(813, 375);
            this.returnHome.Name = "returnHome";
            this.returnHome.Size = new System.Drawing.Size(147, 136);
            this.returnHome.TabIndex = 4;
            this.returnHome.TabStop = false;
            this.returnHome.Click += new System.EventHandler(this.returnHome_Click);
            // 
            // retryHand
            // 
            this.retryHand.Location = new System.Drawing.Point(654, 280);
            this.retryHand.Name = "retryHand";
            this.retryHand.Size = new System.Drawing.Size(75, 71);
            this.retryHand.TabIndex = 5;
            this.retryHand.TabStop = false;
            // 
            // returnHomeHand
            // 
            this.returnHomeHand.Location = new System.Drawing.Point(850, 280);
            this.returnHomeHand.Name = "returnHomeHand";
            this.returnHomeHand.Size = new System.Drawing.Size(75, 71);
            this.returnHomeHand.TabIndex = 5;
            this.returnHomeHand.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(649, 514);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "다시하기";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(854, 514);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "메뉴로";
            // 
            // Scoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.returnHomeHand);
            this.Controls.Add(this.retryHand);
            this.Controls.Add(this.returnHome);
            this.Controls.Add(this.retry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.wrongLabel);
            this.Controls.Add(this.correctLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Scoreboard";
            this.Size = new System.Drawing.Size(1000, 540);
            this.Load += new System.EventHandler(this.initScoreBoard);
            ((System.ComponentModel.ISupportInitialize)(this.retry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retryHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnHomeHand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label correctLabel;
        private System.Windows.Forms.Label wrongLabel;
        private System.Windows.Forms.PictureBox retry;
        private System.Windows.Forms.PictureBox returnHome;
        private System.Windows.Forms.PictureBox retryHand;
        private System.Windows.Forms.PictureBox returnHomeHand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
