using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_goat
{
    public partial class Flappy_goat : Form
    {
        int pipeSpeed = 13;
        int gravity = 15;
        int score = 0;
        public Flappy_goat()
        {
            

            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            flappyGoat.Top += gravity;
            pipe_up.Left -= pipeSpeed;
            pipe_down.Left -= pipeSpeed;
            lb_score.Text = "Score: " + score;


            if(pipe_up.Left <-150)
            {
                pipe_up.Left = 525;
                score++;
            }

            if (pipe_down.Left <-180)
            {
                pipe_down.Left = 425;
                score++;
            }

            if (flappyGoat.Bounds.IntersectsWith(pipe_up.Bounds) ||
                flappyGoat.Bounds.IntersectsWith(pipe_down.Bounds) ||
                flappyGoat.Bounds.IntersectsWith(ground.Bounds))
            {
                EndGame();
            }

            if (score > 5)
                pipeSpeed = 21;

            if (flappyGoat.Top < -25)
                EndGame();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = -15;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = 15;
        }


        private void EndGame()
        {
            timer1.Stop();
            lb_score.Text += "Game over!!!";
        }
    }
}
