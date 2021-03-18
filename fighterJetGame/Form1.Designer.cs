
namespace fighterJetGame
{
    partial class JetFighterGame
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
            this.playTimer = new System.Windows.Forms.Timer(this.components);
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.bullet = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.scoreText.Location = new System.Drawing.Point(267, 161);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(99, 108);
            this.scoreText.TabIndex = 5;
            this.scoreText.Text = "0";
            this.scoreText.Click += new System.EventHandler(this.scoreText_Click);
            // 
            // playTimer
            // 
            this.playTimer.Enabled = true;
            this.playTimer.Interval = 10;
            this.playTimer.Tick += new System.EventHandler(this.playTimer_Tick);
            // 
            // enemy1
            // 
            this.enemy1.Image = global::fighterJetGame.Properties.Resources.enemy;
            this.enemy1.Location = new System.Drawing.Point(66, 44);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(102, 90);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 6;
            this.enemy1.TabStop = false;
            // 
            // player
            // 
            this.player.Image = global::fighterJetGame.Properties.Resources.player;
            this.player.Location = new System.Drawing.Point(264, 521);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(111, 97);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            // 
            // enemy3
            // 
            this.enemy3.Image = global::fighterJetGame.Properties.Resources.enemy;
            this.enemy3.Location = new System.Drawing.Point(468, 44);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(102, 90);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy3.TabIndex = 3;
            this.enemy3.TabStop = false;
            // 
            // bullet
            // 
            this.bullet.Image = global::fighterJetGame.Properties.Resources.shell2;
            this.bullet.Location = new System.Drawing.Point(301, 294);
            this.bullet.Name = "bullet";
            this.bullet.Size = new System.Drawing.Size(40, 70);
            this.bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet.TabIndex = 2;
            this.bullet.TabStop = false;
            this.bullet.Click += new System.EventHandler(this.bullet_Click);
            // 
            // enemy2
            // 
            this.enemy2.Image = global::fighterJetGame.Properties.Resources.enemy;
            this.enemy2.Location = new System.Drawing.Point(264, 44);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(102, 90);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 1;
            this.enemy2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::fighterJetGame.Properties.Resources.enemy;
            this.pictureBox1.Location = new System.Drawing.Point(66, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 0);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // JetFighterGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(624, 667);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.player);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.bullet);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "JetFighterGame";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.onKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox bullet;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer playTimer;
        private System.Windows.Forms.PictureBox enemy1;
    }
}

