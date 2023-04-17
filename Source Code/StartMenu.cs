using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoot_Out_Game
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)//starts the game
        {

            Level1 level1 = new Level1();
            level1.Show();
            this.Hide();
            //these comments are for when I need to start on a certain level for testing

            //Level2 level2 = new Level2();
            //level2.Show();
            //this.Hide();

            //Level3 level3 = new Level3();
            //level3.Show();
            //this.Hide();

            //Level4 level4 = new Level4();
            //level4.Show();
            //this.Hide();

            //BossLevel boss = new BossLevel();
            //boss.Show();
            //this.Hide();
        }

        private void btnInfo_Click(object sender, EventArgs e)//goes to info page
        {
            InfoPage info = new InfoPage();
            info.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)//exits application
        {
            Application.Exit();
        }
    }
}
