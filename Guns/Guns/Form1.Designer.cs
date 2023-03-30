namespace Guns
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.ammoText = new System.Windows.Forms.TextBox();
            this.magText = new System.Windows.Forms.TextBox();
            this.firebtn = new System.Windows.Forms.Button();
            this.reloadbtn = new System.Windows.Forms.Button();
            this.gunBox = new System.Windows.Forms.ComboBox();
            this.gunImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunImg)).BeginInit();
            this.SuspendLayout();
            // 
            // ammoText
            // 
            this.ammoText.Location = new System.Drawing.Point(471, 87);
            this.ammoText.Name = "ammoText";
            this.ammoText.ReadOnly = true;
            this.ammoText.Size = new System.Drawing.Size(207, 20);
            this.ammoText.TabIndex = 1;
            this.ammoText.Text = "Ammo left:";
            // 
            // magText
            // 
            this.magText.Location = new System.Drawing.Point(471, 114);
            this.magText.Name = "magText";
            this.magText.ReadOnly = true;
            this.magText.Size = new System.Drawing.Size(207, 20);
            this.magText.TabIndex = 2;
            this.magText.Text = "Mags left:";
            // 
            // firebtn
            // 
            this.firebtn.Location = new System.Drawing.Point(471, 161);
            this.firebtn.Name = "firebtn";
            this.firebtn.Size = new System.Drawing.Size(207, 52);
            this.firebtn.TabIndex = 3;
            this.firebtn.Text = "Fire";
            this.firebtn.UseVisualStyleBackColor = true;
            this.firebtn.Click += new System.EventHandler(this.firebtn_Click);
            // 
            // reloadbtn
            // 
            this.reloadbtn.Location = new System.Drawing.Point(471, 232);
            this.reloadbtn.Name = "reloadbtn";
            this.reloadbtn.Size = new System.Drawing.Size(207, 52);
            this.reloadbtn.TabIndex = 4;
            this.reloadbtn.Text = "Reload";
            this.reloadbtn.UseVisualStyleBackColor = true;
            this.reloadbtn.Click += new System.EventHandler(this.reloadbtn_Click);
            // 
            // gunBox
            // 
            this.gunBox.FormattingEnabled = true;
            this.gunBox.Items.AddRange(new object[] {
            "AK47",
            "MP5",
            "Glock"});
            this.gunBox.Location = new System.Drawing.Point(58, 418);
            this.gunBox.Name = "gunBox";
            this.gunBox.Size = new System.Drawing.Size(312, 21);
            this.gunBox.TabIndex = 5;
            this.gunBox.SelectedIndexChanged += new System.EventHandler(this.gunBox_SelectedIndexChanged);
            // 
            // gunImg
            // 
            this.gunImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gunImg.Location = new System.Drawing.Point(39, 87);
            this.gunImg.Name = "gunImg";
            this.gunImg.Size = new System.Drawing.Size(376, 247);
            this.gunImg.TabIndex = 0;
            this.gunImg.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.gunBox);
            this.Controls.Add(this.reloadbtn);
            this.Controls.Add(this.firebtn);
            this.Controls.Add(this.magText);
            this.Controls.Add(this.ammoText);
            this.Controls.Add(this.gunImg);
            this.MaximumSize = new System.Drawing.Size(800, 800);
            this.MinimumSize = new System.Drawing.Size(800, 800);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gunImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gunImg;
        private System.Windows.Forms.TextBox ammoText;
        private System.Windows.Forms.TextBox magText;
        private System.Windows.Forms.Button firebtn;
        private System.Windows.Forms.Button reloadbtn;
        private System.Windows.Forms.ComboBox gunBox;
    }
}

