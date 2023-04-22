
namespace Shoot_Out_Game
{
    partial class InfoPage
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lbxControls = new System.Windows.Forms.ListBox();
            this.lblControls = new System.Windows.Forms.Label();
            this.lblGeneralInfo = new System.Windows.Forms.Label();
            this.lbxGeneralInformation = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInfo.Location = new System.Drawing.Point(378, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(178, 37);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Information";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(399, 557);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(134, 44);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lbxControls
            // 
            this.lbxControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxControls.FormattingEnabled = true;
            this.lbxControls.ItemHeight = 25;
            this.lbxControls.Items.AddRange(new object[] {
            "W = Up\t",
            "A = Left",
            "S = Down",
            "D = Right",
            "Spacebar = Shoot",
            "Esc = pause game"});
            this.lbxControls.Location = new System.Drawing.Point(67, 145);
            this.lbxControls.Name = "lbxControls";
            this.lbxControls.Size = new System.Drawing.Size(205, 154);
            this.lbxControls.TabIndex = 2;
            // 
            // lblControls
            // 
            this.lblControls.AutoSize = true;
            this.lblControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControls.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblControls.Location = new System.Drawing.Point(102, 96);
            this.lblControls.Name = "lblControls";
            this.lblControls.Size = new System.Drawing.Size(92, 25);
            this.lblControls.TabIndex = 3;
            this.lblControls.Text = "Controls";
            // 
            // lblGeneralInfo
            // 
            this.lblGeneralInfo.AutoSize = true;
            this.lblGeneralInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneralInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGeneralInfo.Location = new System.Drawing.Point(494, 96);
            this.lblGeneralInfo.Name = "lblGeneralInfo";
            this.lblGeneralInfo.Size = new System.Drawing.Size(200, 25);
            this.lblGeneralInfo.TabIndex = 5;
            this.lblGeneralInfo.Text = "General Information";
            // 
            // lbxGeneralInformation
            // 
            this.lbxGeneralInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxGeneralInformation.FormattingEnabled = true;
            this.lbxGeneralInformation.ItemHeight = 25;
            this.lbxGeneralInformation.Items.AddRange(new object[] {
            "Move over items to pick them up",
            "",
            "Items include:",
            "               ",
            "          Ammo - Gives player five ammo",
            "               ",
            "          ",
            "          Key - Used to unlock the door leading to next level",
            "               ",
            "          ",
            "          Health - Gives player full health",
            "",
            "",
            "When in possession of key move over the",
            "door to transition to the next level"});
            this.lbxGeneralInformation.Location = new System.Drawing.Point(311, 145);
            this.lbxGeneralInformation.Name = "lbxGeneralInformation";
            this.lbxGeneralInformation.Size = new System.Drawing.Size(574, 404);
            this.lbxGeneralInformation.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Shoot_Out_Game.Properties.Resources.HealthPickup;
            this.pictureBox1.Location = new System.Drawing.Point(321, 385);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::Shoot_Out_Game.Properties.Resources.ammo_Image;
            this.pictureBox2.Location = new System.Drawing.Point(321, 234);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::Shoot_Out_Game.Properties.Resources.key;
            this.pictureBox3.Location = new System.Drawing.Point(321, 309);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // InfoPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(980, 613);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbxGeneralInformation);
            this.Controls.Add(this.lblGeneralInfo);
            this.Controls.Add(this.lblControls);
            this.Controls.Add(this.lbxControls);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblInfo);
            this.Name = "InfoPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ListBox lbxControls;
        private System.Windows.Forms.Label lblControls;
        private System.Windows.Forms.Label lblGeneralInfo;
        private System.Windows.Forms.ListBox lbxGeneralInformation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}