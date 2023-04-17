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
        bool goLeft, goRight, goUp, goDown, gameOver;
        string facing = "up";
        int playerHealth = 100;
        int speed = 10;
        int ammo = 10;
        int zombieSpeed = 3;
        int zombieHealth = 1;//health for level 1 enemy
        int zombieHealth2 = 2;//health for level 2 enemy
        int zombieHealth3 = 2;//health for level 3 enemy
        int zombieHealth4 = 2;//health for level 4 enemy
        Random randNum = new Random();
        int score;
        bool gotKey;
        int amountOfHealthPickups = 2;//number of health pickups that can spawn on this level

        List<PictureBox> zombiesList = new List<PictureBox>();
        List<PictureBox> ammodrop = new List<PictureBox>();
        public Level4()
        {
            InitializeComponent();
            RestartGame();
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {

            if (playerHealth > 1)
            {
                healthBar.Value = playerHealth;
            }
            else
            {
                gameOver = true;
                Player.Image = Properties.Resources.dead;
                GameTimer.Stop();
                GameOver over = new GameOver(); //shows game over screen when player dies
                this.Close();
                over.Show();
            }

            txtAmmo.Text = "Ammo: " + ammo;
            txtScore.Text = "Score: " + score;

            if (goLeft == true && Player.Left > 0)
            {
                Player.Left -= speed;
            }
            if (goRight == true && Player.Left + Player.Width < this.ClientSize.Width)
            {
                Player.Left += speed;
            }
            if (goUp == true && Player.Top > 45)
            {
                Player.Top -= speed;
            }
            if (goDown == true && Player.Top + Player.Height < this.ClientSize.Height)
            {
                Player.Top += speed;
            }


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "ammo")
                {
                    if (Player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        ammo += 5;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "zombie")
                {
                    if (Player.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHealth -= 1;
                        if (playerHealth == 50 && amountOfHealthPickups > 0)//drops one health pickup when at 50 and enough health pickups;
                        {
                            DropHealth();
                        }

                    }

                    if (x.Left > Player.Left)
                    {
                        x.Left -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zleft;
                    }
                    if (x.Left < Player.Left)
                    {
                        x.Left += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zright;
                    }
                    if (x.Top > Player.Top)
                    {
                        x.Top -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zup;
                    }
                    if (x.Top < Player.Top)
                    {
                        x.Top += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zdown;
                    }
                }


                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "zombie")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            zombieHealth--;//reduces enemy health by one for each shot that connects

                            if (x.Bounds.IntersectsWith(j.Bounds) && zombieHealth <= 0)//for when enemy health is zero
                            {
                                score++;
                                this.Controls.Remove(j);
                                ((PictureBox)j).Dispose();
                                this.Controls.Remove(x);
                                ((PictureBox)x).Dispose();
                                zombiesList.Remove(((PictureBox)x));
                                MakeZombies();
                            }
                        }
                    }

                }

                //start of level2 enemy controls
                if (x is PictureBox && (string)x.Tag == "zombielvl2")
                {
                    if (Player.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHealth -= 1;
                        if (playerHealth == 50 && amountOfHealthPickups > 0)//drops one health pickup when at 50 and enough health pickups code repeats for level2 enemy;
                        {
                            DropHealth();
                        }

                    }

                    if (x.Left > Player.Left)
                    {
                        x.Left -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zleft2;
                    }
                    if (x.Left < Player.Left)
                    {
                        x.Left += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zright2;
                    }
                    if (x.Top > Player.Top)
                    {
                        x.Top -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zup2;
                    }
                    if (x.Top < Player.Top)
                    {
                        x.Top += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zdown2;
                    }
                }

                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "zombielvl2")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            zombieHealth2--;//reduces enemy health by one for each shot that connects

                            if (x.Bounds.IntersectsWith(j.Bounds) && zombieHealth2 <= 0)//for when enemy health is zero
                            {
                                score++;
                                this.Controls.Remove(j);
                                ((PictureBox)j).Dispose();
                                this.Controls.Remove(x);
                                ((PictureBox)x).Dispose();
                                zombiesList.Remove(((PictureBox)x));
                                MakeZombiesLvl2();
                            }
                        }
                    }
                }

                //start of level 3 ememy controls
                if (x is PictureBox && (string)x.Tag == "zombielvl3")
                {
                    if (Player.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHealth -= 1;
                        if (playerHealth == 50 && amountOfHealthPickups > 0)//drops one health pickup when at 50 and enough health pickups code repeats for level3 enemy;
                        {
                            DropHealth();
                        }

                    }

                    if (x.Left > Player.Left)
                    {
                        x.Left -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zleft2;
                    }
                    if (x.Left < Player.Left)
                    {
                        x.Left += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zright2;
                    }
                    if (x.Top > Player.Top)
                    {
                        x.Top -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zup2;
                    }
                    if (x.Top < Player.Top)
                    {
                        x.Top += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zdown2;
                    }
                }

                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "zombielvl3")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            zombieHealth3--;//reduces enemy health by one for each shot that connects

                            if (x.Bounds.IntersectsWith(j.Bounds) && zombieHealth3 <= 0)//for when enemy health is zero
                            {
                                score++;
                                this.Controls.Remove(j);
                                ((PictureBox)j).Dispose();
                                this.Controls.Remove(x);
                                ((PictureBox)x).Dispose();
                                zombiesList.Remove(((PictureBox)x));
                                MakeZombiesLvl3();
                            }
                        }
                    }
                }

                //start of level 4 ememy controls
                if (x is PictureBox && (string)x.Tag == "zombielvl4")
                {
                    if (Player.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHealth -= 1;
                        if (playerHealth == 50 && amountOfHealthPickups > 0)//drops one health pickup when at 50 and enough health pickups code repeats for level3 enemy;
                        {
                            DropHealth();
                        }

                    }

                    if (x.Left > Player.Left)
                    {
                        x.Left -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zleft2;
                    }
                    if (x.Left < Player.Left)
                    {
                        x.Left += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zright2;
                    }
                    if (x.Top > Player.Top)
                    {
                        x.Top -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zup2;
                    }
                    if (x.Top < Player.Top)
                    {
                        x.Top += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zdown2;
                    }
                }

                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "zombielvl4")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            zombieHealth4--;//reduces enemy health by one for each shot that connects

                            if (x.Bounds.IntersectsWith(j.Bounds) && zombieHealth4 <= 0)//for when enemy health is zero
                            {
                                score++;
                                this.Controls.Remove(j);
                                ((PictureBox)j).Dispose();
                                this.Controls.Remove(x);
                                ((PictureBox)x).Dispose();
                                zombiesList.Remove(((PictureBox)x));
                                MakeZombiesLvl3();
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
            }

            lblKeyCollected.Visible = false;//message telling if have key is hidden
            key.Visible = false;
            if (score >= 8)
            {
                key.Visible = true;
            }
            if (key.Visible == true && key.Bounds.IntersectsWith(Player.Bounds))
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
                BossLevel bosslvl = new BossLevel();
                this.Hide();
                GameTimer.Stop();
                gotKey = false;
                bosslvl.Show();
            }

        }
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (gameOver == true)
            {
                return;
            }

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

        private void KeyIsUp(object sender, KeyEventArgs e)
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

            if (e.KeyCode == Keys.Space && ammo > 0 && gameOver == false)
            {
                ammo--;
                ShootBullet(facing);

                if (ammo < 1)
                {
                    DropAmmo();
                }
            }

            if (gameOver == true)//shows game over screen
            {
                MainMenu();
            }

            //these if statements pause and continue the game
            if (e.KeyCode == Keys.Escape)
            {
                GameTimer.Stop();
                MessageBox.Show("Paused: press enter to continue");
            }
            if (e.KeyCode == Keys.Enter)
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
            zombiesList.Add(zombie);
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
            zombiesList.Add(zombielvl2);
            this.Controls.Add(zombielvl2);
            Player.BringToFront();
        }

        private void MakeZombiesLvl3()//level3 enemy spawn
        {
            PictureBox zombielvl3 = new PictureBox();
            zombieHealth3 = 2;
            zombielvl3.Tag = "zombielvl3";
            zombielvl3.Image = Properties.Resources.zdown2;
            zombielvl3.Left = randNum.Next(0, 900);
            zombielvl3.Top = randNum.Next(0, 800);
            zombielvl3.SizeMode = PictureBoxSizeMode.AutoSize;
            zombiesList.Add(zombielvl3);
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
            zombiesList.Add(zombielvl4);
            this.Controls.Add(zombielvl4);
            Player.BringToFront();
        }

        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammo_Image;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = randNum.Next(10, this.ClientSize.Width - ammo.Width);
            ammo.Top = randNum.Next(60, this.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";
            ammodrop.Add(ammo);
            this.Controls.Add(ammo);

            ammo.BringToFront();
            Player.BringToFront();

        }

        private void DropHealth()
        {
            PictureBox health = new PictureBox();
            health.Image = Properties.Resources.HealthPickup;
            health.SizeMode = PictureBoxSizeMode.AutoSize;
            health.Left = randNum.Next(10, this.ClientSize.Width - health.Width);
            health.Top = randNum.Next(60, this.ClientSize.Height - health.Height);
            health.Tag = "health";
            this.Controls.Add(health);

            health.BringToFront();
            Player.BringToFront();
        }

        private void RestartGame()
        {
            Player.Image = Properties.Resources.up;

            foreach (PictureBox i in zombiesList)
            {
                this.Controls.Remove(i);
            }

            foreach (PictureBox i in ammodrop)
            {
                this.Controls.Remove(i);
            }
            ammodrop.Clear();
            zombiesList.Clear();


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


            key.Visible = true;
            gotKey = false;
            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;
            gameOver = false;

            playerHealth = 100;
            score = 0;
            ammo = 10;

            GameTimer.Start();

        }

        private void MainMenu()
        {
            StartMenu menu = new StartMenu();
            menu.Show();
            this.Hide();
        }
    }
}
