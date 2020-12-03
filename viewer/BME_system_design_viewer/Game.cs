using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BME_system_design_viewer
{
    public partial class Game : UserControl
    {
        const int ONE_BACK = 1, TWO_BACK = 2, THREE_BACK = 3;
        const int GAME_ENDS_AT = 12;

        public int stage = TWO_BACK;

        int[] pastAnswer = new int[3];
        int currentProblem = 0;

        int computerHand = 0;
        int correctAnswer = 0, wrongAnswer = 0, totalAnswer = 0;

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
            await firstProblems();
            computerHand = getNextComputerHand();
            while (true) await nextProblem();
        }

        private async Task firstProblems() // 처음 N개를 보여줄 땐, 입력을 받지 않으므로 이 함수로 처리
        {
            for (; currentProblem < stage; currentProblem++)
            {
                computerHand = rand.Next(1, 7);
                computerHandImg.Image = getImageByNum(computerHand);
                pastAnswer[currentProblem] = computerHand;
                await runTimer();
            }
            currentProblem = 0;
            userHandImg.Focus();
        }

        private int getNextComputerHand()
        {
            computerHand = rand.Next(1, 7);
            computerHandImg.Image = getImageByNum(computerHand);
            return computerHand;
        }

        private void levelUpImg_Click(object sender, EventArgs e)
        {
            if (stage < 3) {
                MainForm.f.frame.Controls.Clear();
                Game newGame = new Game();
                newGame.stage = stage + 1;
                MainForm.f.frame.Controls.Add(newGame);
            }
        }

        private void levelDownImage_Click(object sender, EventArgs e)
        {
            if (stage > 1)
            {
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

        private async Task nextProblem()
        {
            await runTimer();
            int userHand = getUserHand(MainForm.handSign, 250);

            userHandImg.Image = getImageByNum(userHand);

            if (userHand == pastAnswer[currentProblem]) correctAnswer++;
            else wrongAnswer++;

            pastAnswer[currentProblem++] = computerHand;
            computerHand = getNextComputerHand();
            if (currentProblem >= stage) currentProblem = 0;

            if (++totalAnswer == GAME_ENDS_AT)
            {
                MainForm.f.frame.Controls.Clear();
                Scoreboard scoreboard = new Scoreboard();
                scoreboard.correct = correctAnswer;
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
