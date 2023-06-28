using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Framework_4
{
    class MoveWithKeyboard : Movement
    {
        Form1 form;
        PictureBox pictureBox;
        int gravity;
        public MoveWithKeyboard(Form1 form)
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
            if (e.KeyCode == Keys.Left)
            {
                this.pictureBox.Left -= gravity;
            }
            else if (e.KeyCode == Keys.Right)
            {
                this.pictureBox.Left += gravity;
            }
            else if (e.KeyCode == Keys.Up)
            {
                this.pictureBox.Top -= gravity;
            }
            else if (e.KeyCode == Keys.Down)
            {
                this.pictureBox.Top += gravity;
            }
        }
    }
}
