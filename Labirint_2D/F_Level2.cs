using System;
using System.Drawing;
using System.Windows.Forms;

namespace Labirint_2D
{
    public partial class F_Level2 : Form
    {
        private static bool key = false;
        
        public F_Level2()
        {
            InitializeComponent();
        }
       
        private void Game_Start()
        {
            Point point = lb_Start.Location;
            point.Offset(lb_Start.Height / 2, lb_Start.Width / 2);
            Cursor.Position = PointToScreen(point);
            Sounds.PlaySound(1, Parameters.SoundEnabled);
            Keylb.Visible = true;
            Door_Lb.Visible = true;
        }

        private void Game_Finish()
        {
            Parameters.GameState = 1;
            Parameters.Level_numb = 3;
            this.Close();
        }

        private void Game_Restart()
        {
            Sounds.PlaySound(3, Parameters.SoundEnabled);
            DialogResult Result = MessageBox.Show("Летать через стены запрещено! \n Играем ещо один раз ?", "Вы проиграли", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                Game_Start();
            }
            else
            {
                Parameters.GameState = 0;
                this.Close();
            }
        }

        private void label62_MouseEnter(object sender, EventArgs e)
        {
            Game_Restart();
        }

        private void lb_Finish_MouseEnter(object sender, EventArgs e)
        {
            Game_Finish();
        }

        private void F_Level2_Shown(object sender, EventArgs e)
        {
            Game_Start();
        }

        private void Keylb_MouseEnter(object sender, EventArgs e)
        {
            Sounds.PlaySound(4, Parameters.SoundEnabled);
            Keylb.Visible = false;
            key = true;

        }

        private void Door_Lb_MouseEnter(object sender, EventArgs e)
        {
            if (key)
            {
                Door_Lb.Visible = false;
            }
            else MessageBox.Show("Нету ключа \n Возьмите ключ");
        }
    
    }
}
