namespace BME_system_design_viewer
{
    partial class nBackTraining
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
            this.computerHand = new System.Windows.Forms.PictureBox();
            this.userHand = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stageDisplay = new System.Windows.Forms.Label();
            this.indexDisplay = new System.Windows.Forms.Label();
            this.counter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.computerHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userHand)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.label1.Location = new System.Drawing.Point(479, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "N-back Training";
            // 
            // computerHand
            // 
            this.computerHand.Location = new System.Drawing.Point(66, 100);
            this.computerHand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.computerHand.Name = "computerHand";
            this.computerHand.Size = new System.Drawing.Size(175, 160);
            this.computerHand.TabIndex = 2;
            this.computerHand.TabStop = false;
            // 
            // userHand
            // 
            this.userHand.Location = new System.Drawing.Point(485, 100);
            this.userHand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userHand.Name = "userHand";
            this.userHand.Size = new System.Drawing.Size(175, 160);
            this.userHand.TabIndex = 2;
            this.userHand.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(110, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Follow Me!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(531, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "나의 손동작";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(531, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "난이도";
            // 
            // stageDisplay
            // 
            this.stageDisplay.AutoSize = true;
            this.stageDisplay.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.stageDisplay.Location = new System.Drawing.Point(594, 62);
            this.stageDisplay.Name = "stageDisplay";
            this.stageDisplay.Size = new System.Drawing.Size(31, 15);
            this.stageDisplay.TabIndex = 3;
            this.stageDisplay.Text = "___";
            // 
            // indexDisplay
            // 
            this.indexDisplay.AutoSize = true;
            this.indexDisplay.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.indexDisplay.Location = new System.Drawing.Point(136, 74);
            this.indexDisplay.Name = "indexDisplay";
            this.indexDisplay.Size = new System.Drawing.Size(31, 15);
            this.indexDisplay.TabIndex = 3;
            this.indexDisplay.Text = "___";
            // 
            // counter
            // 
            this.counter.AutoSize = true;
            this.counter.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.counter.ForeColor = System.Drawing.Color.Red;
            this.counter.Location = new System.Drawing.Point(328, 153);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(0, 64);
            this.counter.TabIndex = 4;
            // 
            // nBackTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.counter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stageDisplay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.indexDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userHand);
            this.Controls.Add(this.computerHand);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "nBackTraining";
            this.Size = new System.Drawing.Size(700, 360);
            this.Load += new System.EventHandler(this.nBackTraining_Load);
            ((System.ComponentModel.ISupportInitialize)(this.computerHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userHand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox computerHand;
        private System.Windows.Forms.PictureBox userHand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label stageDisplay;
        private System.Windows.Forms.Label indexDisplay;
        private System.Windows.Forms.Label counter;
    }
}
