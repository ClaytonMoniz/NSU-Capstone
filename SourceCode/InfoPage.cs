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
    public partial class InfoPage : Form
    {
        public InfoPage()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)//returns to start menu
        {
            StartMenu menu = new StartMenu();
            menu.Show();
            this.Hide();
        }

        private void lbxGeneralInformation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
