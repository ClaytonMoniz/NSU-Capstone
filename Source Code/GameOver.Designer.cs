
namespace Shoot_Out_Game
{
    partial class GameOver
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
            this.gbxGameOver = new System.Windows.Forms.GroupBox();
            this.chbxExit = new System.Windows.Forms.CheckBox();
            this.chbxRestart = new System.Windows.Forms.CheckBox();
            this.chbxMainMenu = new System.Windows.Forms.CheckBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblPickOne = new System.Windows.Forms.Label();
            this.gbxGameOver.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxGameOver
            // 
            this.gbxGameOver.Controls.Add(this.chbxExit);
            this.gbxGameOver.Controls.Add(this.chbxRestart);
            this.gbxGameOver.Controls.Add(this.chbxMainMenu);
            this.gbxGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxGameOver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbxGameOver.Location = new System.Drawing.Point(154, 54);
            this.gbxGameOver.Name = "gbxGameOver";
            this.gbxGameOver.Size = new System.Drawing.Size(213, 150);
            this.gbxGameOver.TabIndex = 0;
            this.gbxGameOver.TabStop = false;
            this.gbxGameOver.Text = "Game Over";
            // 
            // chbxExit
            // 
            this.chbxExit.AutoSize = true;
            this.chbxExit.Location = new System.Drawing.Point(6, 103);
            this.chbxExit.Name = "chbxExit";
            this.chbxExit.Size = new System.Drawing.Size(102, 24);
            this.chbxExit.TabIndex = 2;
            this.chbxExit.Text = "Exit Game";
            this.chbxExit.UseVisualStyleBackColor = true;
            // 
            // chbxRestart
            // 
            this.chbxRestart.AutoSize = true;
            this.chbxRestart.Location = new System.Drawing.Point(6, 67);
            this.chbxRestart.Name = "chbxRestart";
            this.chbxRestart.Size = new System.Drawing.Size(165, 24);
            this.chbxRestart.TabIndex = 1;
            this.chbxRestart.Text = "Restart from level 1";
            this.chbxRestart.UseVisualStyleBackColor = true;
            // 
            // chbxMainMenu
            // 
            this.chbxMainMenu.AutoSize = true;
            this.chbxMainMenu.Location = new System.Drawing.Point(6, 32);
            this.chbxMainMenu.Name = "chbxMainMenu";
            this.chbxMainMenu.Size = new System.Drawing.Size(177, 24);
            this.chbxMainMenu.TabIndex = 0;
            this.chbxMainMenu.Text = "Return to Main Menu";
            this.chbxMainMenu.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(178, 230);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(147, 35);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblPickOne
            // 
            this.lblPickOne.AutoSize = true;
            this.lblPickOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPickOne.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPickOne.Location = new System.Drawing.Point(165, 289);
            this.lblPickOne.Name = "lblPickOne";
            this.lblPickOne.Size = new System.Drawing.Size(187, 20);
            this.lblPickOne.TabIndex = 2;
            this.lblPickOne.Text = "Must pick only one option";
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(551, 334);
            this.Controls.Add(this.lblPickOne);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.gbxGameOver);
            this.Name = "GameOver";
            this.Text = "GameOver";
            this.gbxGameOver.ResumeLayout(false);
            this.gbxGameOver.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxGameOver;
        private System.Windows.Forms.CheckBox chbxExit;
        private System.Windows.Forms.CheckBox chbxRestart;
        private System.Windows.Forms.CheckBox chbxMainMenu;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblPickOne;
    }
}