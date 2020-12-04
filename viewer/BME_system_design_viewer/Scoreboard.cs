using System;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace BME_system_design_viewer
{
    public partial class Scoreboard : UserControl
    {
        public int correct = 0;
        public int wrong = 0;
        public Scoreboard()
        {
            InitializeComponent();
        }

        private async void initScoreBoard(object sender, EventArgs e)
        {
            loadTextImg();
            await Task.Delay(2000);
            while (true)
            {
                await Task.Delay(500);
                bool userResponse = chooseMenu(getUserHand(MainForm.handSign, 250));
                if (userResponse)
                {
                    break;
                }
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

        private bool chooseMenu(int hand)
        {
            switch (hand)
            {
                case 1:
                    MainForm.f.frame.Controls.Clear();
                    Game game = new Game();
                    MainForm.f.frame.Controls.Add(game);
                    return true;
                case 3:
                    MainForm.f.frame.Controls.Clear();
                    Main main = new Main();
                    MainForm.f.frame.Controls.Add(main);
                    return true;
            }
            return false;
        }

        private void retry_Click(object sender, EventArgs e)
        {
            MainForm.f.frame.Controls.Clear();
            Game game = new Game();
            MainForm.f.frame.Controls.Add(game);
        }

        private void returnHome_Click(object sender, EventArgs e)
        {
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
