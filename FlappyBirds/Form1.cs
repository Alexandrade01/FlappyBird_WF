using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirds
{
    public partial class Form1 : Form
    {

        int PipeSpeed = 8;
        int Gravity = 5;
        int Score = 0;
        public Form1()
        {
            InitializeComponent();
          
        }

        private void _gamerTimerEvent(object sender, EventArgs e)
        {
            label1.Text = "Score: " + Score.ToString();
            bird.Top += Gravity;
            pipeDown.Left -= PipeSpeed;
            pipeTop.Left -= PipeSpeed;
            if (pipeTop.Left < -80) { pipeTop.Left = 800; }
            if (pipeDown.Left < -50) { pipeDown.Left = 950; }
            Score++;
            if(Score % 100 == 0) { PipeSpeed += 3; }
            if (bird.Top < -25) { EndGame(Score); }
            if(bird.Bounds.IntersectsWith(pipeTop.Bounds) || bird.Bounds.IntersectsWith(pipeDown.Bounds) || ground.Bounds.IntersectsWith(bird.Bounds))
            {
                EndGame(Score);
            }

        }

        private void _gameKeyIsDown(object sender, KeyEventArgs e)
        {// if  space pressed the bird fly 
            if (e.KeyCode == Keys.Space) { Gravity = -5; }

        }

        private void _gameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) { Gravity = 5; }

        }
        private void EndGame(int score)
        {
            gamerTimer.Stop();
            MessageBox.Show($"Game Over! You finished with {score} points ","End !",MessageBoxButtons.OK);
            Close();
            
            

        }
    }
}
