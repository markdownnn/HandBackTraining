using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;

namespace BME_system_design_viewer
{
    public partial class Description : UserControl
    {
        bool isOn = true;

        public Description()
        {
            InitializeComponent();
        }

        private async void Description_Load(object sender, System.EventArgs e)
        {
            loadImages();
            loadVideo();

            await Task.Delay(2000); // 이전 화면에서의 '주먹'이 입력되지 않도록 2초 딜레이

            while (isOn)
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

        private void loadVideo()
        {
            // 비디오 파일의 경로를 상대 경로로 설정하는 과정
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\description_video_cut.mp4", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));

            // 비디오 파일 불러오기, 재생
            axWindowsMediaPlayer1.URL = FileName;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void chooseMenu(int hand)
        {
            switch (hand)
            {
                case 1: // 손동작 1번일 때, 튜토리얼 화면으로 넘어간다.
                    isOn = false;
                    MainForm.f.frame.Controls.Clear();
                    Tutorial tutorial = new Tutorial();
                    MainForm.f.frame.Controls.Add(tutorial);
                    break;
            }
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

        private void startBtn_Click(object sender, EventArgs e)
        {
            isOn = false;
            MainForm.f.frame.Controls.Clear();
            Tutorial tutorial = new Tutorial();
            MainForm.f.frame.Controls.Add(tutorial);
        }
    }
}
