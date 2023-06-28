using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Framework_4
{
    class PetrolMovement : Movement 
    {
        int verticalSpeed = 3;
        public void moveObject(PictureBox pictureBox, int gravity)
        {
            pictureBox.Top += verticalSpeed;
            if (pictureBox.Top < 81 || pictureBox.Top > 380)
            {
                verticalSpeed = -verticalSpeed;
            }

        }
    }
}
