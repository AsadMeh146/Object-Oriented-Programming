using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Framework_4
{
    class Jumping : Movement
    {
        Form1 form;
        PictureBox pictureBox;
        int gravity;
        int getJumping;
        public Jumping(Form1 form)
        {
            this.form = form;
            form.KeyDown += new KeyEventHandler(keyholder);
        }
        public void moveObject(PictureBox pictureBox, int gravity)
        {
            this.pictureBox = pictureBox;
            this.gravity = gravity;
        }
        private void keyholder(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                getJumping = this.pictureBox.Top;
                this.pictureBox.Top = this.pictureBox.Top - 40;
            }
            this.pictureBox.Top = getJumping;
        }
    }
}
