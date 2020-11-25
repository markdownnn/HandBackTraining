using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BME_system_design_viewer
{
    public partial class nBackTraining : UserControl
    {
        int stage = 2; // N-Back Training에서 N의 값

        int[] pastAnswer = new int[3]; // 과거에 제시된 손동작이 저장되는 배열
        int index = 0; // pastAnswer 배열에 저장된 데이터 중 몇 번째 데이터를 맞춰야 하는지
        
        int currentImage = 0; // 현재 컴퓨터가 보여주는 이미지
        int total = 0, correctAnswer = 0, wrongAnswer = 0; // 점수를 저장

        const int gameEnd = 12; // 12개의 그림을 보여주면 게임 끝
        const int firstNBackDelay = 3000; // 3초마다 새로운 그림을 보여줌

        Random rand = new Random();

        public nBackTraining()
        {
            InitializeComponent();
        }

        private async void nBackTraining_Load(object sender, EventArgs e)
        {
            initSetup();
            await firstNBack(stage);
            currentImage = nextNBack();
            while (true)
            {
                await processHandSign();
            }
        }

        private void initSetup()
        {
            computerHand.SizeMode = PictureBoxSizeMode.StretchImage;
            userHand.SizeMode = PictureBoxSizeMode.StretchImage;
            stageDisplay.Text = Convert.ToString(stage);
        }

        private void updateIndexDisplay() // 화면에 index 변수를 출력함. 3-Back의 경우 0, 1, 2가 반복됨
        {
            indexDisplay.Text = Convert.ToString(index);
        }

        private async Task firstNBack(int stage) // 처음 N개를 3초에 하나씩 보여주는 함수
        {
            for (; index < stage; index++)
            {
                int imageNum = rand.Next(1, 7);
                computerHand.Image = returnImageByNum(imageNum); // 랜덤으로 결정된 이미지를 보여준다.
                pastAnswer[index] = imageNum; // 위에서 보여준 이미지를 정답 배열에 저장함
                updateIndexDisplay();
                await Task.Delay(firstNBackDelay);
            }
            index = 0; // 처음 N개를 보여줬으므로 인덱스를 다시 0으로 만든다.
            userHand.Focus(); // 키보드 입력을 받기 위해 Focus가 필요
            updateIndexDisplay();
        }

        private int nextNBack() // 처음 N개 이후 이미지를 하나씩 랜덤으로 보여주는 함수 
        {
            int imageNum = rand.Next(1, 7);
            computerHand.Image = returnImageByNum(imageNum);
            return imageNum;
        }

        private Keys convertNumToKeys(int num) // 1부터 6까지를 해당 손동작의 키 Q~Y로 반환하는 함수
        {
            switch (num)
            {
                case 1:
                    return Keys.Q;
                case 2:
                    return Keys.W;
                case 3:
                    return Keys.E;
                case 4:
                    return Keys.R;
                case 5:
                    return Keys.T;
                case 6:
                    return Keys.Y;
                default:
                    return Keys.Z;
            }
        }

        private Image returnImageByKey(Keys keyData) // Q부터 Y까지를 받고 해당 손동작의 이미지로 반환하는 함수
        {
            switch (keyData)
            {
                case Keys.Q:
                    return returnImageByNum(1);
                case Keys.W:
                    return returnImageByNum(2);
                case Keys.E:
                    return returnImageByNum(3);
                case Keys.R:
                    return returnImageByNum(4);
                case Keys.T:
                    return returnImageByNum(5);
                case Keys.Y:
                    return returnImageByNum(6);
                default:
                    return returnImageByNum(0);
            }
        }

        private Image returnImageByNum(int num) // 1부터 6까지를 받아 해당 손동작의 이미지로 반환하는 함수
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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) // 키보드 입력을 받는 함수
        {
            userHand.Image = returnImageByKey(keyData); // 사용자의 손동작을 화면에 보여줌
            // 키보드를 눌렀을 때, 현재 누른 키와 정답 배열에 저장된 숫자에 해당하는 키가 같은 경우
            if (keyData == convertNumToKeys(pastAnswer[index])) correctAnswer++;
            else wrongAnswer++;

            pastAnswer[index++] = currentImage; // 현재 보여준 손동작에 해당하는 숫자를 배열에 저장하고 인덱스를 1 증가시킴
            currentImage = nextNBack(); // 다음 손동작을 보여주면서 currentImage 변수에 그 손동작에 해당하는 숫자를 저장
            if (index >= stage) index = 0;

            updateIndexDisplay();
            // MessageBox.Show(string.Format("{0} {1} {2}", pastAnswer[0], pastAnswer[1], pastAnswer[2]));

            if (++total == gameEnd) {
                Form1.f.frame.Controls.Clear();
                gameResult screen5 = new gameResult();
                screen5.correct = correctAnswer; // 변수 전달
                screen5.wrong = wrongAnswer; // 변수 전달
                Form1.f.frame.Controls.Add(screen5);
            }

            return true;
        }

        private async Task processHandSign()
        {
            await activateTimer();
            int handSign = checkHandSign(Form1.handSign, 250);

            userHand.Image = returnImageByNum(handSign);

            if (handSign == pastAnswer[index]) correctAnswer++;
            else wrongAnswer++;

            pastAnswer[index++] = currentImage;
            currentImage = nextNBack();
            if (index >= stage) index = 0;

            updateIndexDisplay();
            if (++total == gameEnd)
            {
                Form1.f.frame.Controls.Clear();
                gameResult screen5 = new gameResult();
                screen5.correct = correctAnswer; // 변수 전달
                screen5.wrong = wrongAnswer; // 변수 전달
                Form1.f.frame.Controls.Add(screen5);
            }
        }

        private async Task activateTimer()
        {
            counter.Text = "3";
            await Task.Delay(1000);
            counter.Text = "2";
            await Task.Delay(1000);
            counter.Text = "1";
            await Task.Delay(1000);
            counter.Text = "";
        }

        private int checkHandSign(int[] array, int arraySize)
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
