using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BME_system_design_viewer
{
    // 튜토리얼인 0-Back Training에 관련한 코드

    public partial class Tutorial : UserControl
    {
        int computerHand = 1; // 문제에서 주어지는 손동작. 튜토리얼이므로 1부터 6까지 주어진다.

        public Tutorial()
        {
            InitializeComponent();
        }

        private async void initTutorial(object sender, EventArgs e)
        {
            userHandImg.SizeMode = PictureBoxSizeMode.StretchImage;
            computerHandImg.SizeMode = PictureBoxSizeMode.StretchImage;

            gameImg.SizeMode = PictureBoxSizeMode.StretchImage;
            gameImg.Image = Properties.Resources.tutorial;

            computerHandImg.Focus(); // 키보드 입력으로 게임을 플레이 할 때 필요한 함수, 현재는 사용하지 않음.

            while (computerHand <= 6) await nextProblem(); // 6번 동작을 끝낼 때까지 계속 다음 문제가 주어진다. (맞춘다면)

            // 모든 문제를 맞췄을 경우, 다음 화면으로 넘어간다.
            showComment.Text = "3초 후에 자동으로 시작됩니다.";
            await runTimer();

            MainForm.f.frame.Controls.Clear();
            Game game = new Game();
            MainForm.f.frame.Controls.Add(game); // 게임 화면으로 넘어감.
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

        // 다음 문제에 대한 함수, 단 문제를 맞추지 못한다면 똑같은 문제를 반복한다.
        private async Task nextProblem()
        {
            // 현재 문제 손동작에 해당하는 그림을 왼쪽 PictureBox에 띄운다.
            computerHandImg.Image = getImageByNum(computerHand);

            await runTimer(); // 3초간 대기 (유저에게 손동작을 취할 대기 시간을 줌)
            int userHand = getUserHand(MainForm.handSign, 250); // 유저의 손동작을 받아옴.

            userHandImg.Image = getImageByNum(userHand); // 유저의 손동작에 맞게 오른쪽에 이미지를 띄움.

            if (userHand == computerHand) // 유저의 손동작과 문제의 손동작이 맞는 지 확인
            {
                showComment.Text = "맞았습니다. 계속 진행하세요!";
                computerHand += 1; // 다음 문제로 넘어감.
            }
            else
            {
                showComment.Text = "틀렸습니다. 다시 한 번 해 보세요!";
            }
        }

        // 3초마다 손동작을 받으므로, 이를 사용자에게 알려주기 위한 타이머
        private async Task runTimer()
        {
            counterLabel.Text = "3";
            await Task.Delay(1000);
            counterLabel.Text = "2";
            await Task.Delay(1000);
            counterLabel.Text = "1";
            await Task.Delay(1000);
            counterLabel.Text = "";
        }

        // 받은 손동작 데이터 배열에서 최빈값을 찾아 현재의 손동작으로 간주해 반환함.
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
