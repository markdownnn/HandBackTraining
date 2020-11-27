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
    public partial class Main : UserControl
    {
        public Main()
        {
            InitializeComponent();
            loadImages();
        }

        private void startClicked(object sender, EventArgs e)
        {
            MainForm.f.frame.Controls.Clear();
            Tutorial tutorial = new Tutorial();
            MainForm.f.frame.Controls.Add(tutorial);
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
            pictureBox1.Image = Properties.Resources.start_button;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Properties.Resources.description_button;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Image = Properties.Resources.quit_button;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Image = Properties.Resources.lion;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void gameStart_Load(object sender, EventArgs e)
        {
            
        }
    }
}
