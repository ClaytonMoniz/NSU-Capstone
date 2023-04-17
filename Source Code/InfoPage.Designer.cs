
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
            this.lbxGeneralInformation = new System.Windows.Forms.ListBox();
            this.lblGeneralInfo = new System.Windows.Forms.Label();
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
            this.lbxControls.Location = new System.Drawing.Point(63, 171);
            this.lbxControls.Name = "lbxControls";
            this.lbxControls.Size = new System.Drawing.Size(205, 154);
            this.lbxControls.TabIndex = 2;
            // 
            // lblControls
            // 
            this.lblControls.AutoSize = true;
            this.lblControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControls.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblControls.Location = new System.Drawing.Point(98, 122);
            this.lblControls.Name = "lblControls";
            this.lblControls.Size = new System.Drawing.Size(92, 25);
            this.lblControls.TabIndex = 3;
            this.lblControls.Text = "Controls";
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
            "Ammo",
            "Key",
            "Health",
            "",
            "When in posestion of key move over ",
            "door to transition to next level"});
            this.lbxGeneralInformation.Location = new System.Drawing.Point(288, 171);
            this.lbxGeneralInformation.Name = "lbxGeneralInformation";
            this.lbxGeneralInformation.Size = new System.Drawing.Size(383, 229);
            this.lbxGeneralInformation.TabIndex = 4;
            // 
            // lblGeneralInfo
            // 
            this.lblGeneralInfo.AutoSize = true;
            this.lblGeneralInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneralInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGeneralInfo.Location = new System.Drawing.Point(367, 122);
            this.lblGeneralInfo.Name = "lblGeneralInfo";
            this.lblGeneralInfo.Size = new System.Drawing.Size(200, 25);
            this.lblGeneralInfo.TabIndex = 5;
            this.lblGeneralInfo.Text = "General Information";
            // 
            // InfoPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(980, 613);
            this.Controls.Add(this.lblGeneralInfo);
            this.Controls.Add(this.lbxGeneralInformation);
            this.Controls.Add(this.lblControls);
            this.Controls.Add(this.lbxControls);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblInfo);
            this.Name = "InfoPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ListBox lbxControls;
        private System.Windows.Forms.Label lblControls;
        private System.Windows.Forms.ListBox lbxGeneralInformation;
        private System.Windows.Forms.Label lblGeneralInfo;
    }
}