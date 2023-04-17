
namespace Shoot_Out_Game
{
    partial class Win
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbxYouWin = new System.Windows.Forms.GroupBox();
            this.chbxExit = new System.Windows.Forms.CheckBox();
            this.chbxRestart = new System.Windows.Forms.CheckBox();
            this.chbxMainMenu = new System.Windows.Forms.CheckBox();
            this.lblPickOne = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.gbxYouWin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(155, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "You Win";
            // 
            // gbxYouWin
            // 
            this.gbxYouWin.Controls.Add(this.chbxExit);
            this.gbxYouWin.Controls.Add(this.chbxRestart);
            this.gbxYouWin.Controls.Add(this.chbxMainMenu);
            this.gbxYouWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxYouWin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbxYouWin.Location = new System.Drawing.Point(127, 105);
            this.gbxYouWin.Name = "gbxYouWin";
            this.gbxYouWin.Size = new System.Drawing.Size(213, 150);
            this.gbxYouWin.TabIndex = 1;
            this.gbxYouWin.TabStop = false;
            this.gbxYouWin.Text = "What would you like to do";
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
            this.chbxRestart.Size = new System.Drawing.Size(102, 24);
            this.chbxRestart.TabIndex = 1;
            this.chbxRestart.Text = "Play Again";
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
            // lblPickOne
            // 
            this.lblPickOne.AutoSize = true;
            this.lblPickOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPickOne.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPickOne.Location = new System.Drawing.Point(153, 339);
            this.lblPickOne.Name = "lblPickOne";
            this.lblPickOne.Size = new System.Drawing.Size(187, 20);
            this.lblPickOne.TabIndex = 4;
            this.lblPickOne.Text = "Must pick only one option";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(167, 279);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(147, 35);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // Win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(480, 391);
            this.Controls.Add(this.lblPickOne);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.gbxYouWin);
            this.Controls.Add(this.label1);
            this.Name = "Win";
            this.Text = "Win";
            this.gbxYouWin.ResumeLayout(false);
            this.gbxYouWin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxYouWin;
        private System.Windows.Forms.CheckBox chbxExit;
        private System.Windows.Forms.CheckBox chbxRestart;
        private System.Windows.Forms.CheckBox chbxMainMenu;
        private System.Windows.Forms.Label lblPickOne;
        private System.Windows.Forms.Button btnConfirm;
    }
}