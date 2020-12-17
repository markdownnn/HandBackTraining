using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace BME_system_design_viewer
{
    // 데이터를 받은 윈도우 폼에 대한 코드, MSP430의 뷰어 예제 코드와 유사하다.

    public partial class MainForm : Form
    {
        public static MainForm f; // 메인 폼에 있는 요소들에 접근하기 위해 public으로 설정해서 선언.

        SerialPort sPort;
        int[] dataBuff = new int[100];

        const int buffSize = 250;

        public static int[] handSign = new int[buffSize];

        // 추가 기능을 넣는다면 사용할 데이터 배열, 현재는 사용하지 않음.
        public static int[] etcData1 = new int[buffSize];
        public static int[] etcData2 = new int[buffSize];

        int dataIndex = 0;
        int dataCount = 0;

        int startByte = 0;
        int startFlag = 0;

        public MainForm()
        {
            InitializeComponent();
            f = this;
        }

        private void initMainForm(object sender, EventArgs e)
        {
            frame.Controls.Clear();
            Main main = new Main();
            frame.Controls.Add(main);
            setSerialPort();
        }

        private void setSerialPort()
        {
            openBtn.Enabled = true;
            closeBtn.Enabled = false;
            cboPortName.BeginUpdate();
            foreach (string comport in SerialPort.GetPortNames())
            {
                cboPortName.Items.Add(comport);
            }
            cboPortName.EndUpdate();

            cboPortName.SelectedItem = "COM4";
            txtBaudRate.Text = "115200";

            CheckForIllegalCrossThreadCalls = false;
        }

        private void closeMainForm(object sender, FormClosedEventArgs e)
        {
            if (null != sPort)
            {
                if (sPort.IsOpen)
                {
                    sPort.Close();
                    sPort.Dispose();
                    sPort = null;
                }
            }
        }

        private void clickOpen(object sender, EventArgs e)
        {
            try
            {
                if (null == sPort)
                {
                    sPort = new SerialPort();
                    sPort.DataReceived += new SerialDataReceivedEventHandler(receiveData);

                    sPort.PortName = cboPortName.SelectedItem.ToString();
                    sPort.BaudRate = Convert.ToInt32(txtBaudRate.Text);
                    sPort.DataBits = (int)8;
                    sPort.Parity = Parity.None;
                    sPort.StopBits = StopBits.One;
                    sPort.Open();
                }

                if (sPort.IsOpen)
                {
                    openBtn.Enabled = false;
                    closeBtn.Enabled = true;
                }
                else
                {
                    openBtn.Enabled = true;
                    closeBtn.Enabled = false;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void receiveData(object sender, SerialDataReceivedEventArgs e)
        {
            while (sPort.BytesToRead > 0)
            {
                if (sPort.IsOpen)
                {
                    if (startFlag == 0)
                    {
                        startByte = sPort.ReadByte();
                    }
                }
                if (startByte == 0x81)
                {
                    startFlag = 1;
                    dataBuff[dataCount] = sPort.ReadByte();

                    dataCount++;

                    if (dataCount == 3)
                    {
                        startFlag = 2;
                        dataCount = 0;
                    }

                    if (startFlag == 2)
                    {
                        handSign[dataIndex] = dataBuff[0];
                        etcData1[dataIndex] = dataBuff[1];
                        etcData2[dataIndex] = dataBuff[2];
                        dataIndex++;

                        if (dataIndex == buffSize)
                        {
                            dataIndex = 0;
                        }

                        startFlag = 0;
                    }
                }
            }
        }

        private void clickClose(object sender, EventArgs e)
        {
            if (null != sPort)
            {
                if (sPort.IsOpen)
                {
                    sPort.Close();
                    sPort.Dispose();
                    sPort = null;
                }
            }
            openBtn.Enabled = true;
            closeBtn.Enabled = false;
        }
    }
}
