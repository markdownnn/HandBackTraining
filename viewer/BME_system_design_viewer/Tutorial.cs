using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BME_system_design_viewer
{
    public partial class Tutorial : UserControl
    {
        int computerHand = 1;
        public Tutorial()
        {
            InitializeComponent();
        }

        private async void initTutorial(object sender, EventArgs e)
        {
            userHandImg.SizeMode = PictureBoxSizeMode.StretchImage;
            computerHandImg.SizeMode = PictureBoxSizeMode.StretchImage;
            computerHandImg.Focus();

            while (computerHand <= 6) await nextProblem();

            showComment.Text = "3초 후에 자동으로 시작됩니다.";
            await runTimer();

            MainForm.f.frame.Controls.Clear();
            Game game = new Game();
            MainForm.f.frame.Controls.Add(game);
        }
        private Image getImageByNum(int num) // 1부터 6까지를 받아 해당 손동작의 이미지로 반환하는 함수
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

        private async Task nextProblem()
        {
            computerHandImg.Image = getImageByNum(computerHand);

            await runTimer();
            int userHand = checkHandSign(MainForm.handSign, 250);

            userHandImg.Image = getImageByNum(userHand);

            if (userHand == computerHand)
            {
                showComment.Text = "맞았습니다. 계속 진행하세요!";
                computerHand += 1;
            }
            else
            {
                showComment.Text = "틀렸습니다. 다시 한 번 해 보세요!";
            }
        }

        private async Task runTimer()
        {
            displayCounter.Text = "3";
            await Task.Delay(1000);
            displayCounter.Text = "2";
            await Task.Delay(1000);
            displayCounter.Text = "1";
            await Task.Delay(1000);
            displayCounter.Text = "";
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
