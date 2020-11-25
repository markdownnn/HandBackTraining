using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace BME_system_design_viewer
{
    public partial class gameStart : UserControl
    {
        public gameStart()
        {
            InitializeComponent();
            loadImages();
            startMusic();
        }

        private void startClicked(object sender, EventArgs e)
        {
            Form1.f.frame.Controls.Clear();
            zeroBackTrain screen2 = new zeroBackTrain();
            Form1.f.frame.Controls.Add(screen2);
        }

        private void descriptionClicked(object sender, EventArgs e)
        {
            Form1.f.frame.Controls.Clear();
            descriptionPage screen3 = new descriptionPage();
            Form1.f.frame.Controls.Add(screen3);
        }
        private void quitClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void loadImages()
        {
            pictureBox1.Image = Properties.Resources.startButton;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Properties.Resources.descriptionButton;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Image = Properties.Resources.quitButton;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Image = Properties.Resources.lion1;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void startMusic()
        {
            SoundPlayer _player = new SoundPlayer(Properties.Resources.babyShark);
            // _player.Play();
        }

        private void gameStart_Load(object sender, EventArgs e)
        {
            
        }
    }
}
