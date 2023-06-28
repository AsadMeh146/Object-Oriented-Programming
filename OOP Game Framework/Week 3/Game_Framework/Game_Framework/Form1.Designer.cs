
namespace Game_Framework
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
            this.player3 = new System.Windows.Forms.PictureBox();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.mainGameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            this.SuspendLayout();
            // 
            // player3
            // 
            this.player3.BackColor = System.Drawing.Color.Green;
            this.player3.Location = new System.Drawing.Point(458, 29);
            this.player3.Name = "player3";
            this.player3.Size = new System.Drawing.Size(51, 50);
            this.player3.TabIndex = 1;
            this.player3.TabStop = false;
            this.player3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // player1
            // 
            this.player1.BackgroundImage = global::Game_Framework.Properties.Resources._6;
            this.player1.Location = new System.Drawing.Point(350, 114);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(49, 50);
            this.player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1.TabIndex = 1;
            this.player1.TabStop = false;
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.Color.Green;
            this.player2.Location = new System.Drawing.Point(592, 69);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(55, 50);
            this.player2.TabIndex = 1;
            this.player2.TabStop = false;
            // 
            // mainGameTimer
            // 
            this.mainGameTimer.Enabled = true;
            this.mainGameTimer.Interval = 20;
            this.mainGameTimer.Tick += new System.EventHandler(this.mainGameTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game_Framework.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(895, 519);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.player3);
            this.Name = "Form1";
            this.Text = "FrameWork";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox player3;
        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.Timer mainGameTimer;
    }
}

