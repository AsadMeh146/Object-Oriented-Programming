using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Gravity_Framework
{
    class Game
    {
        public int gravity;
        List<GameObject> addobjects = new List<GameObject>();
        public Game(int g)
        {
            this.gravity = g;
        }
        public void addGameobjects(GameObject gameobj)
        {
            addobjects.Add(gameobj);
        }
        public void update(PictureBox ground)
        {
            foreach (object get_object in addobjects)
            {
                GameObject obj = (GameObject)get_object;
                obj.updateObjects(gravity,ground);
            }
        }
    }
}
