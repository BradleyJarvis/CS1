namespace Group_project
{
    partial class TwoFactorAuthCode
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
            this.AuthCodeLabel = new System.Windows.Forms.Label();
            this.AuthCloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AuthCodeLabel
            // 
            this.AuthCodeLabel.AutoSize = true;
            this.AuthCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthCodeLabel.Location = new System.Drawing.Point(30, 81);
            this.AuthCodeLabel.Name = "AuthCodeLabel";
            this.AuthCodeLabel.Size = new System.Drawing.Size(123, 24);
            this.AuthCodeLabel.TabIndex = 0;
            this.AuthCodeLabel.Text = "No code sent";
            // 
            // AuthCloseButton
            // 
            this.AuthCloseButton.Location = new System.Drawing.Point(31, 182);
            this.AuthCloseButton.Name = "AuthCloseButton";
            this.AuthCloseButton.Size = new System.Drawing.Size(122, 23);
            this.AuthCloseButton.TabIndex = 1;
            this.AuthCloseButton.Text = "Close authenticator";
            this.AuthCloseButton.UseVisualStyleBackColor = true;
            this.AuthCloseButton.Click += new System.EventHandler(this.hideAuthenticator);
            // 
            // TwoFactorAuthCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Group_project.Properties.Resources.authenticationDevice;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(185, 257);
            this.ControlBox = false;
            this.Controls.Add(this.AuthCloseButton);
            this.Controls.Add(this.AuthCodeLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TwoFactorAuthCode";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Authenticator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AuthCloseButton;
        internal System.Windows.Forms.Label AuthCodeLabel;
    }
}