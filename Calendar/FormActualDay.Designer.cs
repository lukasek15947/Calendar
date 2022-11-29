namespace Calendar
{
    partial class FormActualDay
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
            this.LBDATE = new System.Windows.Forms.Label();
            this.LBDAY = new System.Windows.Forms.Label();
            this.hourscontainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // LBDATE
            // 
            this.LBDATE.AutoSize = true;
            this.LBDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBDATE.Location = new System.Drawing.Point(434, 9);
            this.LBDATE.Name = "LBDATE";
            this.LBDATE.Size = new System.Drawing.Size(201, 32);
            this.LBDATE.TabIndex = 0;
            this.LBDATE.Text = "MONTH YEAR";
            // 
            // LBDAY
            // 
            this.LBDAY.AutoSize = true;
            this.LBDAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBDAY.Location = new System.Drawing.Point(12, 43);
            this.LBDAY.Name = "LBDAY";
            this.LBDAY.Size = new System.Drawing.Size(61, 29);
            this.LBDAY.TabIndex = 1;
            this.LBDAY.Text = "DAY";
            // 
            // hourscontainer
            // 
            this.hourscontainer.Location = new System.Drawing.Point(12, 75);
            this.hourscontainer.Name = "hourscontainer";
            this.hourscontainer.Size = new System.Drawing.Size(1115, 843);
            this.hourscontainer.TabIndex = 2;
            this.hourscontainer.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // FormActualDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 930);
            this.Controls.Add(this.hourscontainer);
            this.Controls.Add(this.LBDAY);
            this.Controls.Add(this.LBDATE);
            this.Name = "FormActualDay";
            this.Text = "FormActualDay";
            this.Load += new System.EventHandler(this.FormActualDay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBDATE;
        private System.Windows.Forms.Label LBDAY;
        private System.Windows.Forms.FlowLayoutPanel hourscontainer;
    }
}