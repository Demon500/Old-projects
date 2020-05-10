using System.Windows.Forms;
using System.Drawing;

namespace Labirint_2D
{
    public partial class F_Level1 : Form
    {
        public F_Level1()
        {
            InitializeComponent();
        }

        private void F_Level1_Shown(object sender, System.EventArgs e)
        {
            Game_Start();
        }

        private void Game_Start()
        {
            Point point = lb_Start.Location;
            point.Offset(lb_Start.Height / 4, lb_Start.Width / 4);
            Cursor.Position = PointToScreen(point);
            Sounds.PlaySound(1, Parameters.SoundEnabled);
        }

        private void Game_Finish()
        {
            Parameters.GameState = 1;
            Parameters.Level_numb = 2;
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
      
        private void label4_MouseEnter(object sender, System.EventArgs e)
        {
            Game_Restart();
        }

        private void lb_Finish_MouseEnter(object sender, System.EventArgs e)
        {
            Game_Finish();
        }

    }
}
