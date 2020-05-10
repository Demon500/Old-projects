using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Labirint_2D
{
    public partial class F_Level3 : Form
    {
        private static int box_counter = 8;
        private static int box_count = 0;
        private static bool key = false;

        public F_Level3()
        {
            InitializeComponent();
        }

        private void box_show()
        {
            box1.Visible = true;
            box2.Visible = true;
            box3.Visible = true;
            box4.Visible = true;
            box5.Visible = true;
            box6.Visible = true;
            box7.Visible = true;
            box8.Visible = true;
            Door_Lb.Visible = true;
        }

        private void Game_Start()
        {
            Point point = lb_Start.Location;
            point.Offset(lb_Start.Height / 2, lb_Start.Width / 2);
            Cursor.Position = PointToScreen(point);
            Sounds.PlaySound(1, Parameters.SoundEnabled);
            box_show();
            CountLb.Text = "";
            box_count = 0;
            Keylb.Visible = false;
        }

        private void Game_Finish()
        {
            Parameters.GameState = 1;
            Sounds.PlaySound(2, Parameters.SoundEnabled);
            MessageBox.Show("Вы прошли все уровни игры ","Поздравляем");
            //Parameters.Level_numb = 4;
            this.Close();
        }

        private void Game_Restart()
        {
            Sounds.PlaySound(3, Parameters.SoundEnabled);
            DialogResult Result = MessageBox.Show(" Играем ещо один раз ?", "Вы проиграли", MessageBoxButtons.YesNo);
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

        private void label26_MouseEnter(object sender, EventArgs e)
        {
            Game_Restart();
        }

        private void Keylb_MouseEnter(object sender, EventArgs e)
        {
            Keylb.Visible = false;
            key = true;
            Sounds.PlaySound(4,Parameters.SoundEnabled);
        }

        private void Check()
        {
            CountLb.Text = String.Format("Собрано:{0} Всего:{1}", box_count,box_counter);
        if (box_count == box_counter)
            Keylb.Visible = true;
        }

        private void box1_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).Visible = false;
            box_count++;
            Check();
        }

        private void Door_Lb_MouseEnter(object sender, EventArgs e)
        {
            if (key)
            {
                Door_Lb.Visible = false;
            }
            else MessageBox.Show("Нету ключа \n Возьмите ключ");
        }

        private void lb_Finish_MouseEnter(object sender, EventArgs e)
        {
            Game_Finish();
        }

        private void F_Level3_Shown(object sender, EventArgs e)
        {
            Game_Start();
        }

    }
}
