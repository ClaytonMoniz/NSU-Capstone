
namespace Shoot_Out_Game
{
    partial class Level4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.txtHealth = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtAmmo = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Player = new System.Windows.Forms.PictureBox();
            this.key = new System.Windows.Forms.PictureBox();
            this.door = new System.Windows.Forms.PictureBox();
            this.lblKeyCollected = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).BeginInit();
            this.SuspendLayout();
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(680, 18);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(232, 23);
            this.healthBar.TabIndex = 24;
            this.healthBar.Value = 100;
            // 
            // txtHealth
            // 
            this.txtHealth.AutoSize = true;
            this.txtHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHealth.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtHealth.Location = new System.Drawing.Point(605, 18);
            this.txtHealth.Name = "txtHealth";
            this.txtHealth.Size = new System.Drawing.Size(69, 24);
            this.txtHealth.TabIndex = 23;
            this.txtHealth.Text = "Health:";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtScore.Location = new System.Drawing.Point(326, 18);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(80, 24);
            this.txtScore.TabIndex = 22;
            this.txtScore.Text = "Score: 0";
            // 
            // txtAmmo
            // 
            this.txtAmmo.AutoSize = true;
            this.txtAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmmo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtAmmo.Location = new System.Drawing.Point(12, 18);
            this.txtAmmo.Name = "txtAmmo";
            this.txtAmmo.Size = new System.Drawing.Size(86, 24);
            this.txtAmmo.TabIndex = 21;
            this.txtAmmo.Text = "Ammo: 0";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // Player
            // 
            this.Player.Image = global::Shoot_Out_Game.Properties.Resources.up;
            this.Player.Location = new System.Drawing.Point(397, 542);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(71, 100);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player.TabIndex = 25;
            this.Player.TabStop = false;
            // 
            // key
            // 
            this.key.Image = global::Shoot_Out_Game.Properties.Resources.key;
            this.key.Location = new System.Drawing.Point(273, 609);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(54, 40);
            this.key.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.key.TabIndex = 27;
            this.key.TabStop = false;
            // 
            // door
            // 
            this.door.Image = global::Shoot_Out_Game.Properties.Resources.door;
            this.door.Location = new System.Drawing.Point(12, 205);
            this.door.Name = "door";
            this.door.Size = new System.Drawing.Size(122, 136);
            this.door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.door.TabIndex = 26;
            this.door.TabStop = false;
            // 
            // lblKeyCollected
            // 
            this.lblKeyCollected.AutoSize = true;
            this.lblKeyCollected.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyCollected.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKeyCollected.Location = new System.Drawing.Point(12, 42);
            this.lblKeyCollected.Name = "lblKeyCollected";
            this.lblKeyCollected.Size = new System.Drawing.Size(126, 24);
            this.lblKeyCollected.TabIndex = 28;
            this.lblKeyCollected.Text = "Key Collected";
            // 
            // Level4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(924, 661);
            this.Controls.Add(this.lblKeyCollected);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.txtHealth);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtAmmo);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.key);
            this.Controls.Add(this.door);
            this.Name = "Level4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level4";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.Label txtHealth;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtAmmo;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox key;
        private System.Windows.Forms.PictureBox door;
        private System.Windows.Forms.Label lblKeyCollected;
    }
}