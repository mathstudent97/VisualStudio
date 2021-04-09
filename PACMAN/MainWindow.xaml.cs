using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Windows.Threading; // Allows for timer.

namespace PACmanGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    // Will set the variables for this game.
    {
        DispatcherTimer gameTimer = new DispatcherTimer();

        // Require 4 booleans to go up, down, left, right.
        // Another 4 bools to negate up, down, left, right.

        bool goLeft, goRight, goDown, goUp;
        bool noLeft, noRight, noDown, noUp;

        int speed = 8;

        Rect pacmanHitBox;

        int ghostSpeed = 10;
        int ghostMoveStep = 130;
        int currentGhostStep;
        int score = 0;




        public MainWindow()
        {
            InitializeComponent();

            GameSetUp();
        }

        // KeyDown Event; recall: from the form, right click > "go to definition".
        private void CanvasKeyDown(object sender, KeyEventArgs e)
        {
            // Ensures pacman moves in 1 direction.
            if (e.Key == Key.Left && noLeft == false) // if going left and hit a wall.
            {
                goRight = goUp = goDown = false;
                noRight = noUp = noDown = false;

                goLeft = true;

                pacman.RenderTransform = new RotateTransform(-180, pacman.Width / 2, pacman.Height / 2);
            }

            if (e.Key == Key.Right && noRight == false)
            {
                noLeft = noUp = noDown = false;
                goLeft = goUp = goDown = false;

                goRight = true;

                pacman.RenderTransform = new RotateTransform(0, pacman.Width / 2, pacman.Height / 2);
            }

            if (e.Key == Key.Up && noUp == false)
            {
                noRight = noDown = noLeft = false;
                goRight = goDown = goLeft = false;

                goUp = true;

                pacman.RenderTransform = new RotateTransform(-90, pacman.Width / 2, pacman.Height / 2); // 90deg b/c facing up.

            }

            if (e.Key == Key.Down && noDown == false)
            {
                noRight = noUp = noLeft = false;
                goRight = goUp = goLeft = false;

                goDown = true;

                pacman.RenderTransform = new RotateTransform(90, pacman.Width / 2, pacman.Height / 2);
            }

        }


        // Will make to custom functions.

        private void GameSetUp()
        {

            MyCanvas.Focus();

            gameTimer.Tick += GameLoop;
            gameTimer.Interval = TimeSpan.FromMilliseconds(20);
            gameTimer.Start();
            currentGhostStep = ghostMoveStep;

            // Import images.

            ImageBrush pacmanImage = new ImageBrush();
            pacmanImage.ImageSource = new BitmapImage(new Uri("pack://application:,,,/images/pacman.jpg"));
            pacman.Fill = pacmanImage;

            ImageBrush redGhost = new ImageBrush();
            redGhost.ImageSource = new BitmapImage(new Uri("pack://application:,,,/images/red.jpg"));
            redGuy.Fill = redGhost;

            ImageBrush pinkGhost = new ImageBrush();
            pinkGhost.ImageSource = new BitmapImage(new Uri("pack://application:,,,/images/pink.jpg"));
            pinkGuy.Fill = pinkGhost;

            ImageBrush orangeGhost = new ImageBrush();
            orangeGhost.ImageSource = new BitmapImage(new Uri("pack://application:,,,/images/orange.jpg"));
            orangeGuy.Fill = orangeGhost;

        }

        private void GameLoop(object sender, EventArgs e)
        {
            // Set up the score.
            txtScore.Content = "Score: " + score;

            if (goRight)
            {
                Canvas.SetLeft(pacman, Canvas.GetLeft(pacman) + speed); // If moving right, adding speed to the left position.
            }
            if(goLeft)
            {
                Canvas.SetLeft(pacman, Canvas.GetLeft(pacman) - speed); // If moving left, reduce speed in left pos'n.
            }
            if(goUp)
            {
                Canvas.SetTop(pacman, Canvas.GetTop(pacman) - speed); // If moving up, reduce speed in top pos'n.
            }
            if(goDown)
            {
                Canvas.SetTop(pacman, Canvas.GetTop(pacman) + speed); // If moving down, add speed in top pos'n.
            }


            // Don't want to pass the border of the game.

            if (goDown && Canvas.GetTop(pacman) + 90 > Application.Current.MainWindow.Height)
            {
                noDown = true;
                goDown = false;

            }
            if (goUp && Canvas.GetTop(pacman) < 1)
            {
                noUp = true;
                goUp = false;
            }
            if (goLeft && Canvas.GetLeft(pacman) < 1)
            {
                noLeft = true;
                goLeft = false;
            }
            if (goRight && Canvas.GetLeft(pacman) + 90 > Application.Current.MainWindow.Width)
            {
                noRight = true;
                goRight = false;
            }
            
        private void GameOver(string message)
        {
            gameTimer.Stop();
            MessageBox.Show(message, "The Pac Man Game");

            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location); // New app.
            Application.Current.Shutdown(); // Shutdown app running.
        }



    }

