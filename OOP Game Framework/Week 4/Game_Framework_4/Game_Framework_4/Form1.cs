using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Framework_4
{
    public partial class Form1 : Form
    {
        List<GameObject> gameObjectList = new List<GameObject>();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GameObject player1Object = new GameObject(player1, 5, new LeftMovement());
            GameObject player2Object = new GameObject(player2, 6, new RightMovement());
            GameObject player3Object = new GameObject(player3, 6, new MoveWithKeyboard(this));
            GameObject player4Object = new GameObject(player4, 6, new PetrolMovement());
            GameObject player5Object = new GameObject(player5, 6, new Jumping(this));
            addObjects(player1Object);
            addObjects(player2Object);
            addObjects(player3Object);
            addObjects(player4Object);
            addObjects(player5Object);
        }
        private void addObjects(GameObject obj)
        {
            gameObjectList.Add(obj);
        }
        private void mainGameTimer_Tick(object sender, EventArgs e)
        {
            foreach (GameObject obj in gameObjectList)
            {
                obj.update();
            }
        }
    }
}
