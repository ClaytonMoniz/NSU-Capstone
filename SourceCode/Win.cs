﻿using System;
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
    public partial class Win : Form
    {
        public Win()
        {
            InitializeComponent();
            lblPickOne.Hide();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //returns to main menu, restarts from level 1, and exits game -- also prevents multiple check boxes from being selected
            if (chbxMainMenu.Checked == true && chbxRestart.Checked == false && chbxExit.Checked == false)//returns to main menu
            {
                StartMenu menu = new StartMenu();
                menu.Show();
                this.Close();
            }
            else if (chbxRestart.Checked == true && chbxMainMenu.Checked == false && chbxExit.Checked == false)//restarts from level 1
            {
                Level1 level1 = new Level1();
                level1.Show();
                this.Close();
            }
            else if (chbxExit.Checked == true && chbxMainMenu.Checked == false && chbxRestart.Checked == false)//exits game
            {
                Application.Exit();

            }
            else//label appears if more than one box is checked
            {
                lblPickOne.Show();
            }
        }
    }
}
