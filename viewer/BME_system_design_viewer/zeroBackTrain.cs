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
    public partial class zeroBackTrain : UserControl
    {
        int currentImage = 1;
        public zeroBackTrain()
        {
            InitializeComponent();
        }

        private void zeroBackTrain_Load(object sender, EventArgs e)
        {
            zeroBackImage.SizeMode = PictureBoxSizeMode.StretchImage;
            zeroBackImage.Image = Properties.Resources.hand_rock;
            zeroBackImage.Focus(); // 키보드 입력을 받기 위함
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) // 키보드 입력을 받는 함수
        {
            if (keyData == Keys.Q && currentImage == 1) // 주먹 이미지일 때 Q를 누르면 진행
            {
                currentImage += 1;
                zeroBackImage.Image = Properties.Resources.hand_paper;
            }
            else if (keyData == Keys.W && currentImage == 2)
            {
                currentImage += 1;
                zeroBackImage.Image = Properties.Resources.hand_scissors;
            }
            else if (keyData == Keys.E && currentImage == 3)
            {
                currentImage += 1;
                zeroBackImage.Image = Properties.Resources.hand_okay;
            }
            else if (keyData == Keys.R && currentImage == 4)
            {
                currentImage += 1;
                zeroBackImage.Image = Properties.Resources.hand_thumbup;
            }
            else if (keyData == Keys.T && currentImage == 5)
            {
                currentImage += 1;
                zeroBackImage.Image = Properties.Resources.hand_phone;
            }
            else if (keyData == Keys.Y && currentImage == 6)
            {
                currentImage += 1;
                Form1.f.frame.Controls.Clear();
                nBackTraining screen4 = new nBackTraining();
                Form1.f.frame.Controls.Add(screen4);
            }
            return true;
        }
    }
}
