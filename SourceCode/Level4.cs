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
    public partial class Level4 : Form
    {
        bool goLeft, goRight, goUp, goDown;
        string facing = "up";
        int playerHealth = 100;
        int playerSpeed = 10;
        int playerAmmo = 10;
        int zombieSpeed = 3;
        int zombieHealth = 1;//health for level 1 enemy default value
        int zombieHealth2 = 2;//health for level 2 enemy default value
        int zombieHealth3 = 2;//health for level 3 enemy default value
        int zombieHealth4 = 2;//health for level 4 enemy default value
        Random randNum = new Random();
        int score;
        bool gotKey;
        int amountOfHealthPickups = 2;//number of health pickups that can spawn on this level

        public Level4()
        {
            InitializeComponent();
            SpawnZombies();
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {

            if (playerHealth > 1)
            {
                healthBar.Value = playerHealth;
            }
            else
            {
                GameTimer.Stop();
                GameOver over = new GameOver(); //shows game over screen when player dies
                this.Close();
                over.Show();
            }

            txtAmmo.Text = "Ammo: " + playerAmmo;//displays ammo
            txtScore.Text = "Score: " + score;//displays score

            if (goLeft == true && Player.Left > 0)//player movement
            {
                Player.Left -= playerSpeed;
            }
            if (goRight == true && Player.Left + Player.Width < this.ClientSize.Width)
            {
                Player.Left += playerSpeed;
            }
            if (goUp == true && Player.Top > 45)
            {
                Player.Top -= playerSpeed;
            }
            if (goDown == true && Player.Top + Player.Height < this.ClientSize.Height)
            {
                Player.Top += playerSpeed;
            }


            foreach (Control ammoPickup in this.Controls)//adds ammo when player intercescts with ammoPickup
            {
                if (ammoPickup is PictureBox && (string)ammoPickup.Tag == "ammo")
                {
                    if (Player.Bounds.IntersectsWith(ammoPickup.Bounds))
                    {
                        this.Controls.Remove(ammoPickup);
                        ((PictureBox)ammoPickup).Dispose();
                        playerAmmo += 5;//how much ammo is added
                    }
                }
            }

            foreach (Control theZombie in this.Controls)
            {
                if (theZombie is PictureBox && (string)theZombie.Tag == "zombie")
                {

                    if (Player.Bounds.IntersectsWith(theZombie.Bounds))
                    {
                        playerHealth -= 1;
                        if (playerHealth == 50 && amountOfHealthPickups > 0)//drops one health pickup when at 50 and enough health pickups;
                        {
                            DropHealth();
                        }


                    }

                    if (theZombie.Left > Player.Left)//enemy moves towards the player
                    {
                        theZombie.Left -= zombieSpeed;
                        ((PictureBox)theZombie).Image = Properties.Resources.zleft;
                    }
                    if (theZombie.Left < Player.Left)
                    {
                        theZombie.Left += zombieSpeed;
                        ((PictureBox)theZombie).Image = Properties.Resources.zright;
                    }
                    if (theZombie.Top > Player.Top)
                    {
                        theZombie.Top -= zombieSpeed;
                        ((PictureBox)theZombie).Image = Properties.Resources.zup;
                    }
                    if (theZombie.Top < Player.Top)
                    {
                        theZombie.Top += zombieSpeed;
                        ((PictureBox)theZombie).Image = Properties.Resources.zdown;
                    }

                }

                foreach (Control theBullet in this.Controls)
                {
                    if (theBullet is PictureBox && (string)theBullet.Tag == "bullet" && theZombie is PictureBox && (string)theZombie.Tag == "zombie")
                    {
                        if (theZombie.Bounds.IntersectsWith(theBullet.Bounds))
                        {
                            this.Controls.Remove(theBullet);
                            ((PictureBox)theBullet).Dispose();
                            zombieHealth--;//reduces enemy health by one for each shot that connects

                            if (theZombie.Bounds.IntersectsWith(theBullet.Bounds) && zombieHealth <= 0)//for when enemy health is zero
                            {
                                score++;//score goes up if enemy dies
                                this.Controls.Remove(theBullet);
                                ((PictureBox)theBullet).Dispose();
                                this.Controls.Remove(theZombie);
                                ((PictureBox)theZombie).Dispose();
                                MakeZombies();//adds another zombie when an enemy dies

                            }

                        }
                    }

                }
            }

            //start of level 2 enemy
            foreach (Control theZombie in this.Controls)
            {
                if (theZombie is PictureBox && (string)theZombie.Tag == "zombielvl2")
                {

                    if (Player.Bounds.IntersectsWith(theZombie.Bounds))
                    {
                        playerHealth -= 1;
                        if (playerHealth == 50 && amountOfHealthPickups > 0)//drops one health pickup when at 50 and enough health pickups;
                        {
                            DropHealth();
                        }

                    }

                    if (theZombie.Left > Player.Left)//enemy moves towards the player
                    {
                        theZombie.Left -= zombieSpeed;
                        ((PictureBox)theZombie).Image = Properties.Resources.zleft2;
                    }
                    if (theZombie.Left < Player.Left)
                    {
                        theZombie.Left += zombieSpeed;
                        ((PictureBox)theZombie).Image = Properties.Resources.zright2;
                    }
                    if (theZombie.Top > Player.Top)
                    {
                        theZombie.Top -= zombieSpeed;
                        ((PictureBox)theZombie).Image = Properties.Resources.zup2;
                    }
                    if (theZombie.Top < Player.Top)
                    {
                        theZombie.Top += zombieSpeed;
                        ((PictureBox)theZombie).Image = Properties.Resources.zdown2;
                    }

                }

                foreach (Control theBullet in this.Controls)
                {
                    if (theBullet is PictureBox && (string)theBullet.Tag == "bullet" && theZombie is PictureBox && (string)theZombie.Tag == "zombielvl2")
                    {
                        if (theZombie.Bounds.IntersectsWith(theBullet.Bounds))
                        {
                            this.Controls.Remove(theBullet);
                            ((PictureBox)theBullet).Dispose();
                            zombieHealth2--;//reduces enemy health by one for each shot that connects

                            if (theZombie.Bounds.IntersectsWith(theBullet.Bounds) && zombieHealth2 <= 0)//for when enemy health is zero
                            {
                                score++;//score goes up if enemy dies
                                this.Controls.Remove(theBullet);
                                ((PictureBox)theBullet).Dispose();
                                this.Controls.Remove(theZombie);
                                ((PictureBox)theZombie).Dispose();
                                MakeZombiesLvl2();//adds another zombie when an enemy dies

                            }

                        }
                    }

                }
            }

            //start of level 3 enemy
            foreach (Control theZombie in this.Controls)
            {
                if (theZombie is PictureBox && (string)theZombie.Tag == "zombielvl3")
                {

                    if (Player.Bounds.IntersectsWith(theZombie.Bounds))
                    {
                        playerHealth -= 1;
                        if (playerHealth == 50 && amountOfHealthPickups > 0)//drops one health pickup when at 50 and enough health pickups;
                        {
                            DropHealth();
                        }

                    }

                    if (theZombie.Left > Player.Left)//enemy moves towards the player
                    {
                        theZombie.Left -= zombieSpeed;
                        ((PictureBox)theZombie).Image = Properties.Resources.zleft2;
                    }
                    if (theZombie.Left < Player.Left)
                    {
                        theZombie.Left += zombieSpeed;
                        ((PictureBox)theZombie).Image = Properties.Resources.zright2;
                    }
                    if (theZombie.Top > Player.Top)
                    {
                        theZombie.Top -= zombieSpeed;
                        ((PictureBox)theZombie).Image = Properties.Resources.zup2;
                    }
                    if (theZombie.Top < Player.Top)
                    {
                        theZombie.Top += zombieSpeed;
                        ((PictureBox)theZombie).Image = Properties.Resources.zdown2;
                    }

                }

                foreach (Control theBullet in this.Controls)
                {
                    if (theBullet is PictureBox && (string)theBullet.Tag == "bullet" && theZombie is PictureBox && (string)theZombie.Tag == "zombielvl3")
                    {
                        if (theZombie.Bounds.IntersectsWith(theBullet.Bounds))
                        {
                            this.Controls.Remove(theBullet);
                            ((PictureBox)theBullet).Dispose();
                            zombieHealth3--;//reduces enemy health by one for each shot that connects

                            if (theZombie.Bounds.IntersectsWith(theBullet.Bounds) && zombieHealth3 <= 0)//for when enemy health is zero
                            {
                                score++;//score goes up if enemy dies
                                this.Controls.Remove(theBullet);
                                ((PictureBox)theBullet).Dispose();
                                this.Controls.Remove(theZombie);
                                ((PictureBox)theZombie).Dispose();
                                MakeZombiesLvl3();//adds another zombie when an enemy dies

                            }

                        }
                    }

                }
            }

            //start of level 4 enemy
            foreach (Control theZombie in this.Controls)
            {
                if (theZombie is PictureBox && (string)theZombie.Tag == "zombielvl4")
                {

                    if (Player.Bounds.IntersectsWith(theZombie.Bounds))
                    {
                        playerHealth -= 1;
                        if (playerHealth == 50 && amountOfHealthPickups > 0)//drops one health pickup when at 50 and enough health pickups;
                        {
                            DropHealth();
                        }

                    }

                    if (theZombie.Left > Player.Left)//enemy moves towards the player
                    {
                        theZombie.Left -= zombieSpeed;
                        ((PictureBox)theZombie).Image = Properties.Resources.zleft2;
                    }
                    if (theZombie.Left < Player.Left)
                    {
                        theZombie.Left += zombieSpeed;
                        ((PictureBox)theZombie).Image = Properties.Resources.zright2;
                    }
                    if (theZombie.Top > Player.Top)
                    {
                        theZombie.Top -= zombieSpeed;
                        ((PictureBox)theZombie).Image = Properties.Resources.zup2;
                    }
                    if (theZombie.Top < Player.Top)
                    {
                        theZombie.Top += zombieSpeed;
                        ((PictureBox)theZombie).Image = Properties.Resources.zdown2;
                    }

                }

                foreach (Control theBullet in this.Controls)
                {
                    if (theBullet is PictureBox && (string)theBullet.Tag == "bullet" && theZombie is PictureBox && (string)theZombie.Tag == "zombielvl4")
                    {
                        if (theZombie.Bounds.IntersectsWith(theBullet.Bounds))
                        {
                            this.Controls.Remove(theBullet);
                            ((PictureBox)theBullet).Dispose();
                            zombieHealth4--;//reduces enemy health by one for each shot that connects

                            if (theZombie.Bounds.IntersectsWith(theBullet.Bounds) && zombieHealth4 <= 0)//for when enemy health is zero
                            {
                                score++;//score goes up if enemy dies
                                this.Controls.Remove(theBullet);
                                ((PictureBox)theBullet).Dispose();
                                this.Controls.Remove(theZombie);
                                ((PictureBox)theZombie).Dispose();
                                MakeZombiesLvl4();//adds another zombie when an enemy dies

                            }

                        }
                    }

                }
            }

            foreach (Control healthPickup in this.Controls)//adds health back when player intersects with healthPickup
            {
                if (healthPickup is PictureBox && (string)healthPickup.Tag == "health")
                {
                    if (Player.Bounds.IntersectsWith(healthPickup.Bounds))
                    {
                        amountOfHealthPickups--;//reduces number of health pickups once health has been picked up
                        this.Controls.Remove(healthPickup);
                        ((PictureBox)healthPickup).Dispose();
                        playerHealth = 100;
                    }
                }
            }

            lblKeyCollected.Visible = false;//tells player if key is collected
            key.Visible = false;//key is hidden by default
            if (score >= 8)//once score is reached key becomes visible and can be collected
            {
                key.Visible = true;

            }
            if (key.Visible == true && key.Bounds.IntersectsWith(Player.Bounds))//removes key from from when picked up
            {
                gotKey = true;
                key.Dispose();

            }
            if (gotKey == true)//if have key then display message telling player
            {
                lblKeyCollected.Visible = true;
            }

            if (door.Bounds.IntersectsWith(Player.Bounds) && gotKey) //transitions to next level
            {
                BossLevel newLevel = new BossLevel();
                this.Hide();
                GameTimer.Stop();
                gotKey = false;
                newLevel.Show();


            }

        }
        private void KeyIsDown(object sender, KeyEventArgs e)//moves the character when the keys are pushed
        {

            if (e.KeyCode == Keys.A)
            {
                goLeft = true;
                facing = "left";
                Player.Image = Properties.Resources.left;
            }

            if (e.KeyCode == Keys.D)
            {
                goRight = true;
                facing = "right";
                Player.Image = Properties.Resources.right;
            }

            if (e.KeyCode == Keys.W)
            {
                goUp = true;
                facing = "up";
                Player.Image = Properties.Resources.up;
            }

            if (e.KeyCode == Keys.S)
            {
                goDown = true;
                facing = "down";
                Player.Image = Properties.Resources.down;
            }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)//when key is not pushed character does not move
        {
            if (e.KeyCode == Keys.A)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.D)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.W)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.S)
            {
                goDown = false;
            }

            if (e.KeyCode == Keys.Space && playerAmmo > 0)//shoots bullet and removes ammo
            {
                playerAmmo--;
                ShootBullet(facing);

                if (playerAmmo < 1)//drops ammo when the player has none
                {
                    DropAmmo();
                }
            }

            if (e.KeyCode == Keys.Escape)//pauses the game and displays message box
            {
                GameTimer.Stop();
                MessageBox.Show("Paused: press enter to continue");
            }
            if (e.KeyCode == Keys.Enter)//continues the game
            {
                GameTimer.Start();
            }
        }

        private void ShootBullet(string direction)
        {
            Bullet shootBullet = new Bullet();
            shootBullet.direction = direction;
            shootBullet.bulletLeft = Player.Left + (Player.Width / 2);
            shootBullet.bulletTop = Player.Top + (Player.Height / 2);
            shootBullet.MakeBullet(this);
        }

        private void MakeZombies()//level1 enemy spawn
        {
            PictureBox zombie = new PictureBox();
            zombieHealth = 1;
            zombie.Tag = "zombie";
            zombie.Image = Properties.Resources.zdown;
            zombie.Left = randNum.Next(0, 900);
            zombie.Top = randNum.Next(0, 800);
            zombie.SizeMode = PictureBoxSizeMode.AutoSize;
            this.Controls.Add(zombie);
            Player.BringToFront();
        }
        private void MakeZombiesLvl2()//level2 enemy spawn
        {
            PictureBox zombielvl2 = new PictureBox();
            zombieHealth2 = 2;
            zombielvl2.Tag = "zombielvl2";
            zombielvl2.Image = Properties.Resources.zdown2;
            zombielvl2.Left = randNum.Next(0, 900);
            zombielvl2.Top = randNum.Next(0, 800);
            zombielvl2.SizeMode = PictureBoxSizeMode.AutoSize;
            this.Controls.Add(zombielvl2);
            Player.BringToFront();
        }

        private void MakeZombiesLvl3()//level3 enemy spawn
        {
            PictureBox zombielvl3 = new PictureBox();
            zombieHealth3 = 2;
            zombielvl3.Tag = "zombielvl3";
            zombielvl3.Image = Properties.Resources.zdown2;
            zombielvl3.Left = randNum.Next(0, 900);//spawns enemy randomly within these ranges on the form
            zombielvl3.Top = randNum.Next(0, 800);
            zombielvl3.SizeMode = PictureBoxSizeMode.AutoSize;
            this.Controls.Add(zombielvl3);
            Player.BringToFront();
        }

        private void MakeZombiesLvl4()//level4 enemy spawn
        {
            PictureBox zombielvl4 = new PictureBox();
            zombieHealth4 = 2;
            zombielvl4.Tag = "zombielvl4";
            zombielvl4.Image = Properties.Resources.zdown2;
            zombielvl4.Left = randNum.Next(0, 900);
            zombielvl4.Top = randNum.Next(0, 800);
            zombielvl4.SizeMode = PictureBoxSizeMode.AutoSize;
            this.Controls.Add(zombielvl4);
            Player.BringToFront();
        }

        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammo_Image;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = randNum.Next(10, this.ClientSize.Width - ammo.Width);//spawns ammo within this range on the form so the player can see it
            ammo.Top = randNum.Next(60, this.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);
            ammo.BringToFront();
            Player.BringToFront();
        }

        private void DropHealth()
        {
            PictureBox health = new PictureBox();
            health.Image = Properties.Resources.HealthPickup;
            health.SizeMode = PictureBoxSizeMode.AutoSize;
            health.Left = randNum.Next(10, this.ClientSize.Width - health.Width);//spawns health within this range on the form so the player can see it
            health.Top = randNum.Next(60, this.ClientSize.Height - health.Height);
            health.Tag = "health";
            this.Controls.Add(health);
            health.BringToFront();
            Player.BringToFront();
        }

        private void SpawnZombies()
        {

            for (int i = 0; i < 3; i++)//controls how many of level1 enemies spawn
            {
                MakeZombies();
            }
            for (int i = 0; i < 1; i++)//controls how many of level2 enemies spawn
            {
                MakeZombiesLvl2();
            }
            for (int i = 0; i < 1; i++)//controls how many of level3 enemies spawn
            {
                MakeZombiesLvl3();
            }
            for (int i = 0; i < 1; i++)//controls how many of level4 enemies spawn
            {
                MakeZombiesLvl4();
            }
        }
    }
}
