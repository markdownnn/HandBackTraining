namespace BME_system_design_viewer
{
    partial class MainForm
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
            this.frame = new System.Windows.Forms.Panel();
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.cboPortName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBaudRate = new System.Windows.Forms.TextBox();
            this.openBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // frame
            // 
            this.frame.Location = new System.Drawing.Point(12, 11);
            this.frame.Name = "frame";
            this.frame.Size = new System.Drawing.Size(800, 450);
            this.frame.TabIndex = 0;
            // 
            // SerialPort
            // 
            this.SerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.receiveData);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "COM Port";
            // 
            // cboPortName
            // 
            this.cboPortName.FormattingEnabled = true;
            this.cboPortName.Location = new System.Drawing.Point(91, 479);
            this.cboPortName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboPortName.Name = "cboPortName";
            this.cboPortName.Size = new System.Drawing.Size(114, 26);
            this.cboPortName.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 482);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Baud Rate";
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.Location = new System.Drawing.Point(308, 477);
            this.txtBaudRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(114, 28);
            this.txtBaudRate.TabIndex = 9;
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(451, 475);
            this.openBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(86, 29);
            this.openBtn.TabIndex = 10;
            this.openBtn.Text = "Open";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.clickOpen);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(554, 475);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(86, 29);
            this.closeBtn.TabIndex = 11;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.clickClose);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(822, 515);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.txtBaudRate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboPortName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.frame);
            this.Name = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closeMainForm);
            this.Load += new System.EventHandler(this.initMainForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel frame;
        public System.IO.Ports.SerialPort SerialPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboPortName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBaudRate;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}

