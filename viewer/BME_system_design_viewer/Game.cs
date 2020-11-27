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
        const int DELAY = 3000;

        int stage = TWO_BACK;

        int[] pastAnswer = new int[3];
        int currentProblem = 0;

        int computerHand = 0;
        int correctAnswer = 0, wrongAnswer = 0, totalAnswer = 0;

        Random rand = new Random();

        public Game()
        {
            InitializeComponent();
        }

        private void initSetup()
        {
            computerHandImg.SizeMode = PictureBoxSizeMode.StretchImage;
            userHandImg.SizeMode = PictureBoxSizeMode.StretchImage;
            displayStage.Text = Convert.ToString(stage);
        }

        private async void initGame(object sender, EventArgs e)
        {
            initSetup();
            await firstProblems();
            computerHand = getNextProblem();
            while (true) await nextProblem();
        }

        private async Task firstProblems()
        {
            for (; currentProblem < stage; currentProblem++)
            {
                computerHand = rand.Next(1, 7);
                computerHandImg.Image = getImageByNum(computerHand);
                pastAnswer[currentProblem] = computerHand;
                showCurrentProblem();
                await Task.Delay(DELAY);
            }
            currentProblem = 0;
            userHandImg.Focus();
            showCurrentProblem();
        }

        private int getNextProblem()
        {
            computerHand = rand.Next(1, 7);
            computerHandImg.Image = getImageByNum(computerHand);
            return computerHand;
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
            computerHand = getNextProblem();
            if (currentProblem >= stage) currentProblem = 0;

            showCurrentProblem();

            if (++totalAnswer == GAME_ENDS_AT)
            {
                MainForm.f.frame.Controls.Clear();
                Scoreboard scoreboard = new Scoreboard();
                scoreboard.correct = correctAnswer;
                scoreboard.wrong = wrongAnswer;
                MainForm.f.frame.Controls.Add(scoreboard);
            }
        }

        private void showCurrentProblem()
        {
            displayCurrentProblem.Text = Convert.ToString(currentProblem);
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
