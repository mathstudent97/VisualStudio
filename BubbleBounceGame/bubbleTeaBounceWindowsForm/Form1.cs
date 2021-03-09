using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdWindowsForm
{
    public partial class Form1 : Form

    {
        // Variables begin.

        int pipeSpeed = 8; // Default pipe speed defined with an integer.
        int gravity = 5; // Default gravity speed defined with an integer.
        int score = 0; // Default score integer set to 0.
        // Variables end.

        public Form1()
        {
            InitializeComponent();
        }




        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            // This is the GameKeyIsDown event that is linked to the main form.
            if (e.KeyCode == Keys.Space)
            {
                // If the space key is pressed then the gravity will be set to -15.
                gravity = -5;
            }

        }

        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            // This is the GameKeyIsUp event that iis linked to the main form.
            if (e.KeyCode == Keys.Space)
            {
                // If the space key is released then the gravity will be set to 15.
                gravity = 5;
            }
        }


        private void endGame()
        {
            // This is the game end function. It will be called when the bird touches the ground or the pipes.
            gameTimer.Stop(); // Stop the main timer.
            scoreText.Text += " Game Over!!!"; // Shows game Over text.
        }


        private void gameTimerEvent(object sender, EventArgs e)
        {
            FlappyBird.Top += gravity;
            bottomPipe.Left -= pipeSpeed;
            topPipe.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score;

            if (bottomPipe.Left < -150)
            {
                // If the bottom pipe location is -150 then we will reset it back to 800 and add 1 to the score.
                bottomPipe.Left = 800;
                score++;
            }
            if (topPipe.Left < -180)
            {
                // If the top pipe location is -180 then we will reset the pipe back to the 950 and add 1 to the score.
                topPipe.Left = 950;
                score++;
            }

            if (FlappyBird.Bounds.IntersectsWith(bottomPipe.Bounds) ||
                FlappyBird.Bounds.IntersectsWith(topPipe.Bounds) ||
                FlappyBird.Bounds.IntersectsWith(ground.Bounds) || FlappyBird.Top < -25
                )
            {
                // if any of the conditions are met from above then we will run the end game function
                endGame();
            }

            if (score > 5)
            {
                pipeSpeed = 15;
            }

            if (score > 10)
            {
                pipeSpeed = 17;
            }


            if(FlappyBird.Top < -25)
            {
                endGame();
            }

        }
    }

}



    
