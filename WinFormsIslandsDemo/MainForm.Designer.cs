namespace WinFormsIslandsDemo
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSimpleButton = new System.Windows.Forms.Button();
            this.btnCustomControl = new System.Windows.Forms.Button();
            this.btnThirdPartyControl = new System.Windows.Forms.Button();
            this.btnThirdPartyControlWithStyle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSimpleButton
            // 
            this.btnSimpleButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSimpleButton.Location = new System.Drawing.Point(0, 0);
            this.btnSimpleButton.Name = "btnSimpleButton";
            this.btnSimpleButton.Size = new System.Drawing.Size(571, 46);
            this.btnSimpleButton.TabIndex = 0;
            this.btnSimpleButton.Text = "Simple UWP Button";
            this.btnSimpleButton.UseVisualStyleBackColor = true;
            this.btnSimpleButton.Click += new System.EventHandler(this.btnSimpleButton_Click);
            // 
            // btnCustomControl
            // 
            this.btnCustomControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomControl.Location = new System.Drawing.Point(0, 46);
            this.btnCustomControl.Name = "btnCustomControl";
            this.btnCustomControl.Size = new System.Drawing.Size(571, 46);
            this.btnCustomControl.TabIndex = 1;
            this.btnCustomControl.Text = "Custom Control";
            this.btnCustomControl.UseVisualStyleBackColor = true;
            this.btnCustomControl.Click += new System.EventHandler(this.btnCustomControl_Click);
            // 
            // btnThirdPartyControl
            // 
            this.btnThirdPartyControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThirdPartyControl.Location = new System.Drawing.Point(0, 92);
            this.btnThirdPartyControl.Name = "btnThirdPartyControl";
            this.btnThirdPartyControl.Size = new System.Drawing.Size(571, 46);
            this.btnThirdPartyControl.TabIndex = 2;
            this.btnThirdPartyControl.Text = "Third Party Control";
            this.btnThirdPartyControl.UseVisualStyleBackColor = true;
            this.btnThirdPartyControl.Click += new System.EventHandler(this.btnThirdPartyControl_Click);
            // 
            // btnThirdPartyControlWithStyle
            // 
            this.btnThirdPartyControlWithStyle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThirdPartyControlWithStyle.Location = new System.Drawing.Point(0, 138);
            this.btnThirdPartyControlWithStyle.Name = "btnThirdPartyControlWithStyle";
            this.btnThirdPartyControlWithStyle.Size = new System.Drawing.Size(571, 46);
            this.btnThirdPartyControlWithStyle.TabIndex = 3;
            this.btnThirdPartyControlWithStyle.Text = "Third Party Control With Style";
            this.btnThirdPartyControlWithStyle.UseVisualStyleBackColor = true;
            this.btnThirdPartyControlWithStyle.Click += new System.EventHandler(this.btnThirdPartyControlWithStyle_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 214);
            this.Controls.Add(this.btnThirdPartyControlWithStyle);
            this.Controls.Add(this.btnThirdPartyControl);
            this.Controls.Add(this.btnCustomControl);
            this.Controls.Add(this.btnSimpleButton);
            this.Name = "MainForm";
            this.Text = "Xaml Islands";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSimpleButton;
        private System.Windows.Forms.Button btnCustomControl;
        private System.Windows.Forms.Button btnThirdPartyControl;
        private System.Windows.Forms.Button btnThirdPartyControlWithStyle;
    }
}

