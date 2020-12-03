using System;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace BME_system_design_viewer
{
    public partial class Description : UserControl
    {
        public Description()
        {
            InitializeComponent();
        }

        private async void Description_Load(object sender, System.EventArgs e)
        {
            loadImages();
            await Task.Delay(2000);
            while (true)
            {
                await Task.Delay(500);
                chooseMenu(getUserHand(MainForm.handSign, 250));
            }
        }

        private void loadImages()
        {
            startBtn.Image = Properties.Resources.start_button;
            startBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            startImg.Image = Properties.Resources.hand_rock;
            startImg.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void chooseMenu(int hand)
        {
            switch (hand)
            {
                case 1:
                    MainForm.f.frame.Controls.Clear();
                    Tutorial tutorial = new Tutorial();
                    MainForm.f.frame.Controls.Add(tutorial);
                    break;
            }
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

        private void startBtn_Click(object sender, EventArgs e)
        {
            MainForm.f.frame.Controls.Clear();
            Tutorial tutorial = new Tutorial();
            MainForm.f.frame.Controls.Add(tutorial);
        }
    }
}
