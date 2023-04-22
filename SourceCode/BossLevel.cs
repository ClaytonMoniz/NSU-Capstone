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
    public partial class BossLevel : Form
    {
        bool goLeft, goRight, goUp, goDown;
        string facing = "up";
        int playerHealth = 100;
        int playerSpeed = 10;
        int playerAmmo = 10;
        int zombieSpeed = 6;
        int zombieHealth = 1;
        Random randNum = new Random();
        int score;
        int amountOfHealthPickups = 1;//number of health pickups that can spawn on this level

        public BossLevel()
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
                        ((PictureBox)theZombie).Image = Properties.Resources.zleft3;
                    }
                    if (theZombie.Left < Player.Left)
                    {
                        theZombie.Left += zombieSpeed;
                        ((PictureBox)theZombie).Image = Properties.Resources.zright3;
                    }
                    if (theZombie.Top > Player.Top)
                    {
                        theZombie.Top -= zombieSpeed;
                        ((PictureBox)theZombie).Image = Properties.Resources.zup3;
                    }
                    if (theZombie.Top < Player.Top)
                    {
                        theZombie.Top += zombieSpeed;
                        ((PictureBox)theZombie).Image = Properties.Resources.zdown3;
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

            if (score == 1) //transitions to next level
            {
                Win WinMenu = new Win();
                this.Hide();
                GameTimer.Stop();
                WinMenu.Show();
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

        private void MakeZombies()
        {
            PictureBox zombie = new PictureBox();
            zombieHealth = 20;
            zombie.Tag = "zombie";
            zombie.Image = Properties.Resources.zdown3;
            zombie.Left = randNum.Next(0, 900);//spawns enemy randomly within these ranges on the form
            zombie.Top = randNum.Next(0, 800);
            zombie.SizeMode = PictureBoxSizeMode.AutoSize;
            this.Controls.Add(zombie);
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
            for (int i = 0; i < 1; i++)
            {
                MakeZombies();
            }
        }
    }
}
