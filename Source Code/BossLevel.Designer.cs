
namespace Shoot_Out_Game
{
    partial class BossLevel
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
            this.door = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(680, 18);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(232, 23);
            this.healthBar.TabIndex = 10;
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
            this.txtHealth.TabIndex = 9;
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
            this.txtScore.TabIndex = 8;
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
            this.txtAmmo.TabIndex = 7;
            this.txtAmmo.Text = "Ammo: 0";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // door
            // 
            this.door.Image = global::Shoot_Out_Game.Properties.Resources.door;
            this.door.Location = new System.Drawing.Point(760, 495);
            this.door.Name = "door";
            this.door.Size = new System.Drawing.Size(122, 136);
            this.door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.door.TabIndex = 12;
            this.door.TabStop = false;
            // 
            // Player
            // 
            this.Player.Image = global::Shoot_Out_Game.Properties.Resources.up;
            this.Player.Location = new System.Drawing.Point(397, 542);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(71, 100);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player.TabIndex = 11;
            this.Player.TabStop = false;
            // 
            // BossLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(924, 661);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.txtHealth);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtAmmo);
            this.Controls.Add(this.door);
            this.Controls.Add(this.Player);
            this.Name = "BossLevel";
            this.Text = "BossLevel";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.Label txtHealth;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtAmmo;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox door;
        private System.Windows.Forms.PictureBox Player;
    }
}