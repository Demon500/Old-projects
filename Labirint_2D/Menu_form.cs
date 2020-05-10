using System;
using System.Windows.Forms;

namespace Labirint_2D
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void SoundSt_CheckedChanged(object sender, EventArgs e)
        {
            if (SoundSt.CheckState == CheckState.Checked)
            {
                SoundSt.Text = "Sound: Enabled";
            }
            else
            {
                SoundSt.Text = "Sound: Disabled";
                Parameters.SoundEnabled = false;
            }
        }


        private void Level(int Level_Numb)
        {
            switch (Level_Numb)
            {
                case 1: new F_Level1().ShowDialog();
                    break;

                case 2: new F_Level2().ShowDialog();
                    break;
                case 3: new F_Level3().ShowDialog();
                    break;
            }
        }

        private void Game_Start(int Indicator)
        {
            if (Indicator == 0)
            {
                Level(Parameters.Level_numb);
            }
            else 
            {
                Level(Parameters.Level_numb);
            }

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            Game_Start(Parameters.GameState);
        }
    }
}
