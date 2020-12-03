using System;
using System.Windows.Forms;

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

        private void initScoreBoard(object sender, EventArgs e)
        {
            correctLabel.Text = Convert.ToString(correct);
            wrongLabel.Text = Convert.ToString(wrong);
        }
    }
}
