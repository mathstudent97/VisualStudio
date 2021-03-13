using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bouncingBall
{
    public partial class Form1 : Form
    {
        private int objWidth;
        private const int objHeight = 50;
        private int objX, objY; //Position.
        private int volX, volY; //Velocity.

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left = objX;
            label1.Top = objY;

            objX += volX;
            if (objX < 0)
            {
                volX = -volX;
                Random rnd = new Random();
                label1.ForeColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            }
            else if (objX + objWidth > ClientSize.Width)
            {
                volX = -volX;
                Random rnd = new Random();
                label1.ForeColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            }

            objY += volY;
            if (objY < 0)
            {
                volY = -volY;
                Random rnd = new Random();
                label1.ForeColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            }
            else if (objY + objHeight > ClientSize.Height)
            {
                volY = -volY;
                Random rnd = new Random();
                label1.ForeColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            }

            Refresh();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Pick a random start position & velocity.
            Random rnd = new Random();
            volX = rnd.Next(1, 4);
            volY = rnd.Next(1, 4);
            objX = label1.Left;
            objY = label1.Top;
            objWidth = label1.Width;

            objX = rnd.Next(0, ClientSize.Width - objWidth);
            objY = rnd.Next(0, ClientSize.Height - objHeight);

            // Use double buffering to reduce flicker.
            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true
                );
            this.UpdateStyles();

        }

    }
}
