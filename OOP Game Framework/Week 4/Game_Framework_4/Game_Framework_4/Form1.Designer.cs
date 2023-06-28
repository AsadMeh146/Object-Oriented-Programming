
namespace Game_Framework_4
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
            this.player2 = new System.Windows.Forms.PictureBox();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.player4 = new System.Windows.Forms.PictureBox();
            this.mainGameTimer = new System.Windows.Forms.Timer(this.components);
            this.player5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player5)).BeginInit();
            this.SuspendLayout();
            // 
            // player3
            // 
            this.player3.BackColor = System.Drawing.Color.Lime;
            this.player3.Location = new System.Drawing.Point(233, 12);
            this.player3.Name = "player3";
            this.player3.Size = new System.Drawing.Size(66, 50);
            this.player3.TabIndex = 0;
            this.player3.TabStop = false;
            this.player3.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.Color.Lime;
            this.player2.Location = new System.Drawing.Point(577, 12);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(66, 50);
            this.player2.TabIndex = 0;
            this.player2.TabStop = false;
            // 
            // player1
            // 
            this.player1.BackgroundImage = global::Game_Framework_4.Properties.Resources._6;
            this.player1.Location = new System.Drawing.Point(429, 59);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(66, 50);
            this.player1.TabIndex = 0;
            this.player1.TabStop = false;
            // 
            // player4
            // 
            this.player4.BackColor = System.Drawing.Color.Lime;
            this.player4.Location = new System.Drawing.Point(314, 268);
            this.player4.Name = "player4";
            this.player4.Size = new System.Drawing.Size(66, 50);
            this.player4.TabIndex = 0;
            this.player4.TabStop = false;
            this.player4.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mainGameTimer
            // 
            this.mainGameTimer.Enabled = true;
            this.mainGameTimer.Interval = 20;
            this.mainGameTimer.Tick += new System.EventHandler(this.mainGameTimer_Tick);
            // 
            // player5
            // 
            this.player5.BackColor = System.Drawing.Color.Lime;
            this.player5.Location = new System.Drawing.Point(100, 179);
            this.player5.Name = "player5";
            this.player5.Size = new System.Drawing.Size(66, 50);
            this.player5.TabIndex = 0;
            this.player5.TabStop = false;
            this.player5.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game_Framework_4.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(929, 548);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.player5);
            this.Controls.Add(this.player4);
            this.Controls.Add(this.player3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox player3;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox player4;
        private System.Windows.Forms.Timer mainGameTimer;
        private System.Windows.Forms.PictureBox player5;
    }
}

