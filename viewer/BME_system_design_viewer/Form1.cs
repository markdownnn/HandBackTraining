using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace BME_system_design_viewer
{
    public partial class Form1 : Form
    {
        public static Form1 f;

        SerialPort sPort;
        int[] dataBuff = new int[100];

        const int buffSize = 250;

        public static int[] handSign = new int[buffSize];
        public static int[] emg1 = new int[buffSize];
        public static int[] emg2 = new int[buffSize];

        int dataIndex = 0;
        int dataCount = 0;

        int startByte = 0;
        int startFlag = 0;

        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            f = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frame.Controls.Clear();
            gameStart screen1 = new gameStart();
            frame.Controls.Add(screen1);

            setSerialPort();
        }

        private void setSerialPort()
        {
            btnOpen.Enabled = true;
            btnClose.Enabled = false;
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

        private void formClosed(object sender, FormClosedEventArgs e)
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

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (null == sPort)
                {
                    sPort = new SerialPort();
                    sPort.DataReceived += new SerialDataReceivedEventHandler(SPort_DataReceived);

                    sPort.PortName = cboPortName.SelectedItem.ToString();
                    sPort.BaudRate = Convert.ToInt32(txtBaudRate.Text);
                    sPort.DataBits = (int)8;
                    sPort.Parity = Parity.None;
                    sPort.StopBits = StopBits.One;
                    sPort.Open();
                }

                if (sPort.IsOpen)
                {
                    btnOpen.Enabled = false;
                    btnClose.Enabled = true;
                }
                else
                {
                    btnOpen.Enabled = true;
                    btnClose.Enabled = false;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
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
                        emg1[dataIndex] = dataBuff[1];
                        emg2[dataIndex] = dataBuff[2];
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

        private void btnClose_Click(object sender, EventArgs e)
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

            btnOpen.Enabled = true;
            btnClose.Enabled = false;
        }

        private void hi_Click(object sender, EventArgs e)
        {
            int randomHand = rand.Next(6);

            switch (randomHand)
            {
                case 0:
                    randomHand = 1;
                    break;
                case 1:
                    randomHand = 2;
                    break;
                case 2:
                    randomHand = 4;
                    break;
                case 3:
                    randomHand = 8;
                    break;
                case 4:
                    randomHand = 16;
                    break;
                case 5:
                    randomHand = 32;
                    break;
            }
        }
    }
}
