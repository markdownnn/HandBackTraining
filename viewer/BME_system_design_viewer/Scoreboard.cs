using System;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace BME_system_design_viewer
{
    // 점수판 화면에 관한 코드
    public partial class Scoreboard : UserControl
    {
        // 게임 화면에서 점수를 넘겨받기 위해 public으로 설정
        public int correct = 0;
        public int wrong = 0;

        bool isOn = true;

        public Scoreboard()
        {
            InitializeComponent();
        }

        private async void initScoreBoard(object sender, EventArgs e)
        {
            loadTextImg(); // 각종 버튼 이미지, 점수 등 로딩
            await Task.Delay(2000);
            while (isOn)
            {
                await Task.Delay(500); // 0.5초마다 메뉴 선택을 위한 손동작을 받음.
                chooseMenu(getUserHand(MainForm.handSign, 250));
            }
        }

        private void loadTextImg()
        {
            correctLabel.Text = Convert.ToString(correct);
            wrongLabel.Text = Convert.ToString(wrong);
            retry.SizeMode = PictureBoxSizeMode.StretchImage;
            retry.Image = Properties.Resources.retry;
            returnHome.SizeMode = PictureBoxSizeMode.StretchImage;
            returnHome.Image = Properties.Resources.return_home;
            retryHand.SizeMode = PictureBoxSizeMode.StretchImage;
            retryHand.Image = Properties.Resources.hand_rock;
            returnHomeHand.SizeMode = PictureBoxSizeMode.StretchImage;
            returnHomeHand.Image = Properties.Resources.hand_scissors;
        }

        private void chooseMenu(int hand)
        {
            switch (hand)
            {
                case 1: // 1번 손동작 시, 다시 게임 시작
                    isOn = false;
                    MainForm.f.frame.Controls.Clear();
                    Game game = new Game();
                    MainForm.f.frame.Controls.Add(game);
                    break;
                case 3: // 3번 손동작 시, 메인 메뉴로 이동.
                    isOn = false;
                    MainForm.f.frame.Controls.Clear();
                    Main main = new Main();
                    MainForm.f.frame.Controls.Add(main);
                    break;
            }
        }

        private void retry_Click(object sender, EventArgs e)
        {
            isOn = false;
            MainForm.f.frame.Controls.Clear();
            Game game = new Game();
            MainForm.f.frame.Controls.Add(game);
        }

        private void returnHome_Click(object sender, EventArgs e)
        {
            isOn = false;
            MainForm.f.frame.Controls.Clear();
            Main main = new Main();
            MainForm.f.frame.Controls.Add(main);
        }

        private int getUserHand(int[] array, int arraySize)
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
