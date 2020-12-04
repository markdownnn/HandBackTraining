using System;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace BME_system_design_viewer
{
    public partial class Main : UserControl
    {
        public Main()
        {
            InitializeComponent();
            loadImages();
        }

        private async void mainLoad(object sender, EventArgs e)
        {
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

        private void startClicked(object sender, EventArgs e)
        {
            MainForm.f.frame.Controls.Clear();
            Game game = new Game();
            MainForm.f.frame.Controls.Add(game);
        }

        private void descriptionClicked(object sender, EventArgs e)
        {
            MainForm.f.frame.Controls.Clear();
            Description description = new Description();
            MainForm.f.frame.Controls.Add(description);
        }
        private void quitClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void loadImages()
        {
            startBtn.Image = Properties.Resources.start_button;
            startBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            descriptionBtn.Image = Properties.Resources.description_button;
            descriptionBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            exitBtn.Image = Properties.Resources.quit_button;
            exitBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            lionImg.Image = Properties.Resources.lion;
            lionImg.SizeMode = PictureBoxSizeMode.StretchImage;
            startImg.Image = Properties.Resources.hand_rock;
            startImg.SizeMode = PictureBoxSizeMode.StretchImage;
            descriptionImg.Image = Properties.Resources.hand_scissors;
            descriptionImg.SizeMode = PictureBoxSizeMode.StretchImage;
            exitImg.Image = Properties.Resources.hand_phone;
            exitImg.SizeMode = PictureBoxSizeMode.StretchImage;
            titleImg.Image = Properties.Resources.titleImage;
            titleImg.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private bool chooseMenu(int hand)
        {
            switch (hand)
            {
                case 1:
                    MainForm.f.frame.Controls.Clear();
                    Tutorial tutorial = new Tutorial();
                    MainForm.f.frame.Controls.Add(tutorial);
                    return true;
                case 3:
                    MainForm.f.frame.Controls.Clear();
                    Description description = new Description();
                    MainForm.f.frame.Controls.Add(description);
                    return true;
                case 5:
                    Application.Exit();
                    return true;
            }
            return false;
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
