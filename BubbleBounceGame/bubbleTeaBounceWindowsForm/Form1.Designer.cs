
namespace FlappyBirdWindowsForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.scoreText = new System.Windows.Forms.Label();
            this.ground = new System.Windows.Forms.PictureBox();
            this.bottomPipe = new System.Windows.Forms.PictureBox();
            this.FlappyBird = new System.Windows.Forms.PictureBox();
            this.topPipe = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPipe)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Haettenschweiler", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.scoreText.Location = new System.Drawing.Point(12, 9);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(152, 50);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score: 0";
            // 
            // ground
            // 
            this.ground.Image = global::FlappyBirdWindowsForm.Properties.Resources.ground_removebg_preview;
            this.ground.Location = new System.Drawing.Point(-132, 534);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(794, 113);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // bottomPipe
            // 
            this.bottomPipe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bottomPipe.Image = global::FlappyBirdWindowsForm.Properties.Resources.pipeBottom_removebg_preview1;
            this.bottomPipe.Location = new System.Drawing.Point(278, 370);
            this.bottomPipe.Name = "bottomPipe";
            this.bottomPipe.Size = new System.Drawing.Size(146, 169);
            this.bottomPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bottomPipe.TabIndex = 2;
            this.bottomPipe.TabStop = false;
            // 
            // FlappyBird
            // 
            this.FlappyBird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FlappyBird.Image = global::FlappyBirdWindowsForm.Properties.Resources.tapioca_removebg_preview__1_2;
            this.FlappyBird.Location = new System.Drawing.Point(46, 186);
            this.FlappyBird.Name = "FlappyBird";
            this.FlappyBird.Size = new System.Drawing.Size(101, 60);
            this.FlappyBird.TabIndex = 1;
            this.FlappyBird.TabStop = false;
            // 
            // topPipe
            // 
            this.topPipe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.topPipe.Image = global::FlappyBirdWindowsForm.Properties.Resources.pipeTop_removebg_preview1;
            this.topPipe.Location = new System.Drawing.Point(381, -6);
            this.topPipe.Name = "topPipe";
            this.topPipe.Size = new System.Drawing.Size(146, 199);
            this.topPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topPipe.TabIndex = 0;
            this.topPipe.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(556, 618);
            this.Controls.Add(this.FlappyBird);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.bottomPipe);
            this.Controls.Add(this.topPipe);
            this.Name = "Form1";
            this.Text = "Flappy Bird Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox topPipe;
        private System.Windows.Forms.PictureBox FlappyBird;
        private System.Windows.Forms.PictureBox bottomPipe;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}

