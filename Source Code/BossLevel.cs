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
    public partial class BossLevel : Form
    {
        bool goLeft, goRight, goUp, goDown, gameOver;
        string facing = "up";
        int playerHealth = 100;
        int speed = 10;
        int ammo = 10;
        int zombieSpeed = 5;
        int zombieHealth = 1;
        Random randNum = new Random();
        int score;
        int amountOfHealthPickups = 1;//number of health pickups that can spawn on this level

        List<PictureBox> zombiesList = new List<PictureBox>();
        List<PictureBox> ammodrop = new List<PictureBox>();

        public BossLevel()
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
                        ((PictureBox)x).Image = Properties.Resources.zleft3;
                    }
                    if (x.Left < Player.Left)
                    {
                        x.Left += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zright3;
                    }
                    if (x.Top > Player.Top)
                    {
                        x.Top -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zup3;
                    }
                    if (x.Top < Player.Top)
                    {
                        x.Top += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zdown3;
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

            

            if (score == 1) //transitions to next level
            {
                Win WinMenu = new Win();
                this.Hide();
                GameTimer.Stop();
                WinMenu.Show();


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

        private void MakeZombies()
        {
            PictureBox zombie = new PictureBox();
            zombieHealth = 10;
            zombie.Tag = "zombie";
            zombie.Image = Properties.Resources.zdown3;
            zombie.Left = randNum.Next(0, 900);
            zombie.Top = randNum.Next(0, 800);
            zombie.SizeMode = PictureBoxSizeMode.AutoSize;
            zombiesList.Add(zombie);
            this.Controls.Add(zombie);
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


            for (int i = 0; i < 1; i++)
            {
                MakeZombies();
            }

            
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