using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BME_system_design_viewer
{
    public partial class Game : UserControl
    {
        const int GAME_ENDS_AT = 12; // 12개의 이미지를 맞춘 후, 게임이 종료됨.

        int stage = 1; // 1-Back-Training으로 시작, stage의 값을 바꾸면 2단계, 3단계도 가능

        int[] pastAnswer = new int[3]; // 과거 문제를 담는 배열. 현재는 3단계까지 구현하였으므로 최대 길이를 3으로 함.

        // pastAnswer에 담긴 과거 문제 중, 몇 번째 문제를 현재 맞추면 되는지에 해당하는 인덱스.
        // 예를 들어, 1단계에서는 0, 2단계에서는 0, 1, 3단계에서는 0, 1, 2의 값을 가진다.
        int currentProblem = 0;

        // 컴퓨터가 현재 보여주는 손동작. 보여준 이후에는 pastAnswer에 저장된다.
        int computerHand = 0;

        // 점수 화면에 사용할 변수들. totalAnswer가 12가 되면 게임이 종료된다.
        int correctAnswer = 0, wrongAnswer = 0, totalAnswer = 0;

        bool isOn = true;

        // 랜덤한 문제를 내야 하므로, random 객체를 선언.
        Random rand = new Random();

        public Game()
        {
            InitializeComponent();
        }

        private void initLabelAndImage()
        {
            computerHandImg.SizeMode = PictureBoxSizeMode.StretchImage;
            userHandImg.SizeMode = PictureBoxSizeMode.StretchImage;
            stageLabel.Text = Convert.ToString(stage);
            gameImg.SizeMode = PictureBoxSizeMode.StretchImage;
            gameImg.Image = Properties.Resources.game;
            levelUpImg.SizeMode = PictureBoxSizeMode.StretchImage;
            levelUpImg.Image = Properties.Resources.level_up;
            levelDownImage.SizeMode = PictureBoxSizeMode.StretchImage;
            levelDownImage.Image = Properties.Resources.level_down;
        }

        private async void initGame(object sender, EventArgs e)
        {
            initLabelAndImage();
            await firstProblems(); // 처음 N개는 손동작을 받지 않고 먼저 보여준다.
            computerHand = getNextComputerHand(); // firstProblems가 끝난 이후, 다음 손동작을 랜덤으로 하나 보여준다.
            while (isOn) await nextProblem(); // 12개를 맞출 때까지 계속되는 다음 문제들
        }

        // 처음 N개를 보여줄 땐, 입력을 받지 않으므로 이 함수로 처리
        private async Task firstProblems()
        {
            // N번 반복
            for (; currentProblem < stage; currentProblem++)
            {
                computerHand = rand.Next(1, 7); // 랜덤으로 1번부터 6번 사이의 손동작 문제를 냄.
                computerHandImg.Image = getImageByNum(computerHand); // 왼쪽에 손동작을 보여줌.
                
                // 손동작을 currentProblem 인덱스에 저장함.
                // currentProblem은 새로운 문제가 나올때마다 계속해서 0에서 N-1까지 반복하는데
                // 유저는 pastAnswer에 저장된(즉, 이전에 나온 문제) 손동작을 맞춰야 한다.
                pastAnswer[currentProblem] = computerHand;

                // 다음 문제가 나오기 전, 3초 대기 시간
                await runTimer();
            }
            currentProblem = 0; // pastAnswer의 0부터 N-1까지 인덱스가 채워졌다면 다시 0으로 돌아감.
            userHandImg.Focus(); // 키보드 입력을 받기 위한 함수, 현재는 사용하지 않음.
        }

        // 컴퓨터의 손동작을 랜덤으로 정하고, 이미지를 왼쪽에 띄우는 함수
        private int getNextComputerHand()
        {
            computerHand = rand.Next(1, 7);
            computerHandImg.Image = getImageByNum(computerHand);
            return computerHand;
        }

        // 난이도를 높이는 함수
        private void levelUpImg_Click(object sender, EventArgs e)
        {
            if (stage < 3) { // 난이도는 3이 최대
                isOn = false; // 새로운 화면을 띄우므로 현재 화면의 손동작 입력은 받지 않는다.
                MainForm.f.frame.Controls.Clear();
                Game newGame = new Game();
                newGame.stage = stage + 1;
                MainForm.f.frame.Controls.Add(newGame);
            }
        }

        // 난이도를 낮추는 함수
        private void levelDownImage_Click(object sender, EventArgs e)
        {
            if (stage > 1) // 난이도는 1이 가장 낮음.
            {
                isOn = false;
                MainForm.f.frame.Controls.Clear();
                Game newGame = new Game();
                newGame.stage = stage - 1;
                MainForm.f.frame.Controls.Add(newGame);
            }
        }

        private Image getImageByNum(int num)
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

        // 다음 문제를 생성하고, 저장하고, 유저의 손동작을 받아 pastAnswer에 저장된 예전 손동작과 비교해
        // 점수를 계산하는 종합적인 함수
        private async Task nextProblem()
        {
            await runTimer(); // 유저의 입력 3초 대기
            int userHand = getUserHand(MainForm.handSign, 250); // 유저의 손동작 가져옴

            userHandImg.Image = getImageByNum(userHand); // 유저의 손동작 오른쪽에 띄움.

            // 유저의 손동작이 N개 전, 과거의 손동작과 같다면 정답 틀리다면 오답
            if (userHand == pastAnswer[currentProblem]) correctAnswer++;
            else wrongAnswer++;

            pastAnswer[currentProblem++] = computerHand; // 현재 currentProblem 인덱스에 문제의 손동작을 저장하고 currentProblem + 1
            computerHand = getNextComputerHand(); // 다음 문제의 손동작을 가져옴.
            if (currentProblem >= stage) currentProblem = 0; // 만약 N개의 손동작을 저장했다면 다시 인덱스를 0으로 만들어 줌.

            if (++totalAnswer == GAME_ENDS_AT) // 손동작 맞추기 12개 시도 이후
            {
                isOn = false;
                MainForm.f.frame.Controls.Clear();
                Scoreboard scoreboard = new Scoreboard(); // 점수판 화면으로 넘어감
                scoreboard.correct = correctAnswer; // 점수판 화면에서 쓰기 위해 변수를 넘김.
                scoreboard.wrong = wrongAnswer;
                MainForm.f.frame.Controls.Add(scoreboard);
            }
        }

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
