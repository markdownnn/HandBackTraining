using System;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace BME_system_design_viewer
{
    // 메인 화면에 대한 코드

    public partial class Main : UserControl
    {
        bool isOn = true; // 현재 화면에서 이동하면 false로 바꿔 더 이상 동작을 받지 않는다

        public Main()
        {
            InitializeComponent();
            loadImages();
        }

        // 화면이 처음 로딩될 때 실행되는 Load 함수이지만 비동기 작업을 수행해야 하므로 async 키워드를 사용.
        private async void mainLoad(object sender, EventArgs e)
        {
            // 2초 동안 Delay를 주어 이전 화면에서의 손동작이 넘어오지 않도록 한다.
            // await 키워드는 이 동작이 끝날 때까지 다음 동작을 수행하지 않는 비동기 작업 시 사용한다.
            await Task.Delay(2000);
            while (isOn)
            {
                await Task.Delay(500); // 0.5초마다 손동작을 받음.
                chooseMenu(getUserHand(MainForm.handSign, 250)); // 손동작을 받아 해당 화면으로 넘어가게 함.
            }
        }

        // 아래 3개의 Clicked 함수는 버튼을 마우스로 눌렀을 때 화면이 이동함.
        // 실제 사용자 기능이라기보다는 테스트 기능

        private void startClicked(object sender, EventArgs e)
        {
            isOn = false; // 현재 화면의 손동작을 더 이상 받지 않음
            MainForm.f.frame.Controls.Clear();
            Game game = new Game();
            MainForm.f.frame.Controls.Add(game); // Game 화면 객체를 새로 만들어 frame이라는 Panel에 추가한다. 즉, 화면 이동.
        }

        private void descriptionClicked(object sender, EventArgs e)
        {
            isOn = false;
            MainForm.f.frame.Controls.Clear();
            Description description = new Description();
            MainForm.f.frame.Controls.Add(description);
        }
        private void quitClicked(object sender, EventArgs e)
        {
            isOn = false;
            Application.Exit(); // 창이 닫힘.
        }
        private void loadImages()
        {
            startBtn.Image = Properties.Resources.start_button;
            startBtn.SizeMode = PictureBoxSizeMode.StretchImage; // 이미지의 사이즈를 PictureBox에 맞춤.
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

        // 1번, 3번, 5번 손동작을 받았을 때 화면을 이동시키는 함수

        private void chooseMenu(int hand)
        {
            switch (hand)
            {
                case 1:
                    isOn = false; // 현재 스크린의 손동작을 더 이상 받지 않음.
                    MainForm.f.frame.Controls.Clear();
                    Game game = new Game();
                    MainForm.f.frame.Controls.Add(game);
                    break;
                case 3:
                    isOn = false;
                    MainForm.f.frame.Controls.Clear();
                    Description description = new Description();
                    MainForm.f.frame.Controls.Add(description);
                    break;
                case 5:
                    isOn = false;
                    Application.Exit();
                    break;
            }
        }

        // 받은 손동작 데이터 배열에서 최빈값을 찾아 현재의 손동작으로 간주해 반환함.
        private int getUserHand(int[] array, int arraySize)
        {
            int[] action = new int[7]; // 손동작의 빈도를 저장할 배열
            int frequency = 0, maxValue = 0;

            for (int i = 0; i < arraySize; i++)
            {
                switch (array[i]) // 배열을 처음부터 끝까지 돌면서 각 손동작의 빈도를 체크한다
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

            for (int j = 0; j < 7; j++) // 손동작 빈도 배열을 체크해 최빈값을 찾아낸다.
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
