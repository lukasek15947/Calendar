namespace Calendar
{
    partial class UserControlHours
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

        #region Kód vygenerovaný pomocí Návrháře komponent

        /// <summary> 
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbhours = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbhours
            // 
            this.lbhours.AutoSize = true;
            this.lbhours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbhours.Location = new System.Drawing.Point(0, 0);
            this.lbhours.Name = "lbhours";
            this.lbhours.Size = new System.Drawing.Size(23, 25);
            this.lbhours.TabIndex = 0;
            this.lbhours.Text = "0";
            // 
            // UserControlHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Controls.Add(this.lbhours);
            this.Name = "UserControlHours";
            this.Size = new System.Drawing.Size(1117, 24);
            this.Load += new System.EventHandler(this.UserControlHours_Load);
            this.Click += new System.EventHandler(this.UserControlHours_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbhours;
    }
}
