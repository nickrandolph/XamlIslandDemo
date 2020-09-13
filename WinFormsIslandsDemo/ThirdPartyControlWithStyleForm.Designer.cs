namespace WinFormsIslandsDemo
{
    partial class ThirdPartyControlWithStyleForm
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
            this.lblPickDateTitle = new System.Windows.Forms.Label();
            this.pnlXamlIsland = new System.Windows.Forms.Panel();
            this.dtpPickDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPickDateTitle
            // 
            this.lblPickDateTitle.AutoSize = true;
            this.lblPickDateTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPickDateTitle.Location = new System.Drawing.Point(0, 0);
            this.lblPickDateTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblPickDateTitle.Name = "lblPickDateTitle";
            this.lblPickDateTitle.Size = new System.Drawing.Size(134, 32);
            this.lblPickDateTitle.TabIndex = 0;
            this.lblPickDateTitle.Text = "Pick a date:";
            // 
            // pnlXamlIsland
            // 
            this.pnlXamlIsland.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlXamlIsland.Location = new System.Drawing.Point(0, 32);
            this.pnlXamlIsland.Name = "pnlXamlIsland";
            this.pnlXamlIsland.Size = new System.Drawing.Size(800, 322);
            this.pnlXamlIsland.TabIndex = 1;
            // 
            // dtpPickDate
            // 
            this.dtpPickDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpPickDate.Location = new System.Drawing.Point(0, 354);
            this.dtpPickDate.Name = "dtpPickDate";
            this.dtpPickDate.Size = new System.Drawing.Size(800, 39);
            this.dtpPickDate.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDate.Location = new System.Drawing.Point(0, 393);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(171, 32);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "<placeholder>";
            // 
            // ThirdPartyControlWithStyleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpPickDate);
            this.Controls.Add(this.pnlXamlIsland);
            this.Controls.Add(this.lblPickDateTitle);
            this.Name = "ThirdPartyControlWithStyleForm";
            this.Text = "Third Party Control With Style";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPickDateTitle;
        private System.Windows.Forms.Panel pnlXamlIsland;
        private System.Windows.Forms.DateTimePicker dtpPickDate;
        private System.Windows.Forms.Label lblDate;
    }
}