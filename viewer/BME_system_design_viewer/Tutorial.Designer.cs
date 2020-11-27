namespace BME_system_design_viewer
{
    partial class Tutorial
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
            this.counter = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userHand = new System.Windows.Forms.PictureBox();
            this.computerHand = new System.Windows.Forms.PictureBox();
            this.showComment = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerHand)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.label1.Location = new System.Drawing.Point(684, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "0-back Training";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(50, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "제시된 손 모양을 따라하세요.";
            // 
            // counter
            // 
            this.counter.AutoSize = true;
            this.counter.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.counter.ForeColor = System.Drawing.Color.Red;
            this.counter.Location = new System.Drawing.Point(450, 208);
            this.counter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(0, 96);
            this.counter.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(740, 390);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "나의 손동작";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(139, 390);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Follow Me!";
            // 
            // userHand
            // 
            this.userHand.Location = new System.Drawing.Point(674, 129);
            this.userHand.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.userHand.Name = "userHand";
            this.userHand.Size = new System.Drawing.Size(250, 240);
            this.userHand.TabIndex = 5;
            this.userHand.TabStop = false;
            // 
            // computerHand
            // 
            this.computerHand.Location = new System.Drawing.Point(76, 129);
            this.computerHand.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.computerHand.Name = "computerHand";
            this.computerHand.Size = new System.Drawing.Size(250, 240);
            this.computerHand.TabIndex = 6;
            this.computerHand.TabStop = false;
            // 
            // showComment
            // 
            this.showComment.AutoSize = true;
            this.showComment.Location = new System.Drawing.Point(307, 486);
            this.showComment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.showComment.Name = "showComment";
            this.showComment.Size = new System.Drawing.Size(0, 18);
            this.showComment.TabIndex = 10;
            // 
            // Tutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.showComment);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userHand);
            this.Controls.Add(this.computerHand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Tutorial";
            this.Size = new System.Drawing.Size(1000, 540);
            this.Load += new System.EventHandler(this.initTutorial);
            ((System.ComponentModel.ISupportInitialize)(this.userHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerHand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label counter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox userHand;
        private System.Windows.Forms.PictureBox computerHand;
        private System.Windows.Forms.Label showComment;
    }
}
