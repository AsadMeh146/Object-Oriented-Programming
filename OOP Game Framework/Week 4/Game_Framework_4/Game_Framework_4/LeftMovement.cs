﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Framework_4
{
    class LeftMovement : Movement
    {
        public void moveObject(PictureBox pictureBox, int gravity)
        {
            pictureBox.Left -= gravity;
        }
    }
}
