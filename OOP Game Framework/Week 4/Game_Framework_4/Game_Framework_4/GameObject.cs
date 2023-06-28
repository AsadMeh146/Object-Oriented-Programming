using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Framework_4
{
    interface IGameObject
    {
        void update();
    }

    class GameObject : IGameObject
    {
        PictureBox pictureBox;
        int gravity;
        Movement real_movement;
        public GameObject(PictureBox gameObj, int g, Movement movement)
        {
            pictureBox = gameObj;
            gravity = g;
            this.real_movement = movement;
        }
        public void update()
        {
            real_movement.moveObject(pictureBox, gravity);
        }
    }
}
