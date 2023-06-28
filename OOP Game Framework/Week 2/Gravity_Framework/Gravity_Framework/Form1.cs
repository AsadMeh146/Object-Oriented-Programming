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
    public partial class Gravity : Form
    {
        Game game = new Game(3);
        public Gravity()
        {
            InitializeComponent();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            game.update(ground);
        }

        private void Gravity_Load(object sender, EventArgs e)
        {
            GameObject playerObj = new GameObject(pbPlayer);
            GameObject enemyObj1 = new GameObject(enemy1);
            GameObject enemyObj2 = new GameObject(enemy2);
            GameObject enemyObj3 = new GameObject(enemy3);

            game.addGameobjects(playerObj);
            game.addGameobjects(enemyObj1);
            game.addGameobjects(enemyObj2);
            game.addGameobjects(enemyObj3);
        }

        private void ground_Click(object sender, EventArgs e)
        {

        }
    }
}
