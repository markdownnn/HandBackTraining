using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BME_system_design_viewer
{
    public partial class zeroBackTrain : UserControl
    {
        int currentImage = 1;
        public zeroBackTrain()
        {
            InitializeComponent();
        }

        private async void zeroBackTrain_Load(object sender, EventArgs e)
        {
            userHand.SizeMode = PictureBoxSizeMode.StretchImage;
            computerHand.SizeMode = PictureBoxSizeMode.StretchImage;
            computerHand.Focus();
            while (currentImage <= 6)
            {
                await processHandSign();
            }
            Form1.f.frame.Controls.Clear();
            nBackTraining screen4 = new nBackTraining();
            Form1.f.frame.Controls.Add(screen4);
        }
        private Image returnImageByNum(int num) // 1부터 6까지를 받아 해당 손동작의 이미지로 반환하는 함수
        {
            switch (num)
            {
                case 0:
                    return Properties.Resources.hand_undefined;
                case 1:
                    return Properties.Resources.hand_rock;
                case 2:
                    return Properties.Resources.hand_paper;
                case 3:
                    return Properties.Resources.hand_scissors;
                case 4:
                    return Properties.Resources.hand_okay;
                case 5:
                    return Properties.Resources.hand_thumbup;
                case 6:
                    return Properties.Resources.hand_phone;
                default:
                    return Properties.Resources.hand_undefined;
            }
        }

        private async Task processHandSign()
        {
            computerHand.Image = returnImageByNum(currentImage);

            await activateTimer();
            int handSign = checkHandSign(Form1.handSign, 250);

            userHand.Image = returnImageByNum(handSign);

            if (handSign == currentImage)
            {
                showComment.Text = "맞았습니다. 계속 진행하세요!";
                currentImage += 1;
            }
            else
            {
                showComment.Text = "틀렸습니다. 다시 한 번 해 보세요!";
            }
        }

        private async Task activateTimer()
        {
            counter.Text = "3";
            await Task.Delay(1000);
            counter.Text = "2";
            await Task.Delay(1000);
            counter.Text = "1";
            await Task.Delay(1000);
            counter.Text = "";
        }

        private int checkHandSign(int[] array, int arraySize)
        {
            int[] action = new int[7];
            int frequency = 0, maxValue = 0;

            for (int i = 0; i < arraySize; i++)
            {
                switch (array[i])
                {
                    case 0:
                        action[0]++;
                        break;
                    case 1:
                        action[1]++;
                        break;
                    case 2:
                        action[2]++;
                        break;
                    case 4:
                        action[3]++;
                        break;
                    case 8:
                        action[4]++;
                        break;
                    case 16:
                        action[5]++;
                        break;
                    case 32:
                        action[6]++;
                        break;
                    default:
                        break;
                }
            }

            for (int j = 0; j < 7; j++)
            {
                if (frequency <= action[j])
                {
                    frequency = action[j];
                    maxValue = j;
                }
            }

            return maxValue;
        }
    }
}
