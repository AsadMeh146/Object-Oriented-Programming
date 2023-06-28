using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Gravity_Framework
{
    class GameObject
    {
        private PictureBox real_pictureBox;
      
        public GameObject(PictureBox pB)
        {
            this.real_pictureBox = pB;
        }
        public void updateObjects(int gravity,PictureBox ground)
        { 
            if(this.real_pictureBox.Bounds.IntersectsWith(ground.Bounds))
            {
                this.real_pictureBox.Left += gravity;
            }
            else
            {
                this.real_pictureBox.Top += gravity;
            }
            
        }
    }
}
