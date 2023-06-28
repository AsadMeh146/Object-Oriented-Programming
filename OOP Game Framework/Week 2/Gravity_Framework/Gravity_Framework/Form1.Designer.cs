
namespace Gravity_Framework
{
    partial class Gravity
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
            this.ground = new System.Windows.Forms.PictureBox();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.gameMainTimer = new System.Windows.Forms.Timer(this.components);
            this.enemy3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.Maroon;
            this.ground.Location = new System.Drawing.Point(112, 376);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(705, 30);
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            this.ground.Click += new System.EventHandler(this.ground_Click);
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackgroundImage = global::Gravity_Framework.Properties.Resources._6;
            this.pbPlayer.Location = new System.Drawing.Point(407, 90);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(50, 88);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer.TabIndex = 1;
            this.pbPlayer.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.Purple;
            this.enemy1.Location = new System.Drawing.Point(222, 58);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(39, 50);
            this.enemy1.TabIndex = 2;
            this.enemy1.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.Color.Purple;
            this.enemy2.Location = new System.Drawing.Point(606, 41);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(34, 50);
            this.enemy2.TabIndex = 3;
            this.enemy2.TabStop = false;
            // 
            // gameMainTimer
            // 
            this.gameMainTimer.Enabled = true;
            this.gameMainTimer.Interval = 20;
            this.gameMainTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // enemy3
            // 
            this.enemy3.BackColor = System.Drawing.Color.Purple;
            this.enemy3.Location = new System.Drawing.Point(166, 143);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(25, 50);
            this.enemy3.TabIndex = 4;
            this.enemy3.TabStop = false;
            // 
            // Gravity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gravity_Framework.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(930, 499);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.ground);
            this.Name = "Gravity";
            this.Text = "Gravity";
            this.Load += new System.EventHandler(this.Gravity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.Timer gameMainTimer;
        private System.Windows.Forms.PictureBox enemy3;
    }
}

