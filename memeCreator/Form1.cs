using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memeCreator
{
    public partial class Form1 : Form
    {
        OpenFileDialog openImage; // Var.that opens image file. Idea: this finds an img file and stores its location inside
        // the image file str to be used later.
        string imageFile; // String that will name the image file.

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openImage = new OpenFileDialog(); // Creates open file dialog class to select a file from windows index.
            openImage.InitialDirectory = "C:\\"; // Sets directory to C (local harddrive) to navigate.
            openImage.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.gif; *.bmp";
            // Above line filters the files; showing ONLY image files.
            openImage.FilterIndex = 2; // Reps. index of filter currently selected in dialog box.
            openImage.RestoreDirectory = true; // When close FileDialog, original working directory is restored.

            if (openImage.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    preview.Image = Image.FromFile(openImage.FileName);
                    imageFile = openImage.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file. Original error " + ex.Message);
                }
            }
        }


        private void topText_TextChanged(object sender, EventArgs e)
        {
            // Want: topLabel to change with the topText box.
            topLabel.Text = topText.Text;
        }

        private void bottomLabel_Click(object sender, EventArgs e)
        {
            bottomLabel.Text = bottomText.Text; // Apply same from above.
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void topLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
