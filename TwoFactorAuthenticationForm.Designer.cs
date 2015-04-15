namespace Group_project
{
    partial class TwoFactorAuthenticationForm
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
            this.GenCodeButton = new System.Windows.Forms.Button();
            this.OpenAuthButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.imgTitle = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.codeInputBox = new System.Windows.Forms.TextBox();
            this.lblCodeSent = new System.Windows.Forms.Label();
            this.loginResultLabel = new System.Windows.Forms.Label();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.explainationText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // GenCodeButton
            // 
            this.GenCodeButton.Image = global::Group_project.Properties.Resources.btn2FactorSendCode;
            this.GenCodeButton.Location = new System.Drawing.Point(17, 243);
            this.GenCodeButton.Name = "GenCodeButton";
            this.GenCodeButton.Size = new System.Drawing.Size(186, 57);
            this.GenCodeButton.TabIndex = 1;
            this.GenCodeButton.UseVisualStyleBackColor = true;
            this.GenCodeButton.Click += new System.EventHandler(this.genAuthCode);
            // 
            // OpenAuthButton
            // 
            this.OpenAuthButton.Image = global::Group_project.Properties.Resources.btn2FactorAuthenticator;
            this.OpenAuthButton.Location = new System.Drawing.Point(536, 245);
            this.OpenAuthButton.Name = "OpenAuthButton";
            this.OpenAuthButton.Size = new System.Drawing.Size(236, 55);
            this.OpenAuthButton.TabIndex = 2;
            this.OpenAuthButton.UseVisualStyleBackColor = true;
            this.OpenAuthButton.Click += new System.EventHandler(this.showAuth);
            // 
            // LoginButton
            // 
            this.LoginButton.Image = global::Group_project.Properties.Resources.btn2FactorLogin;
            this.LoginButton.Location = new System.Drawing.Point(314, 382);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(166, 53);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.attemptLogin);
            // 
            // imgTitle
            // 
            this.imgTitle.BackColor = System.Drawing.Color.Transparent;
            this.imgTitle.Image = global::Group_project.Properties.Resources.titleTwoFactor;
            this.imgTitle.Location = new System.Drawing.Point(118, 41);
            this.imgTitle.Name = "imgTitle";
            this.imgTitle.Size = new System.Drawing.Size(560, 51);
            this.imgTitle.TabIndex = 63;
            this.imgTitle.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(1)))), ((int)(((byte)(163)))));
            this.label2.Location = new System.Drawing.Point(290, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 40);
            this.label2.TabIndex = 64;
            this.label2.Text = "ENTER CODE";
            // 
            // codeInputBox
            // 
            this.codeInputBox.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeInputBox.Location = new System.Drawing.Point(274, 329);
            this.codeInputBox.MaxLength = 8;
            this.codeInputBox.Name = "codeInputBox";
            this.codeInputBox.Size = new System.Drawing.Size(244, 36);
            this.codeInputBox.TabIndex = 65;
            this.codeInputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCodeSent
            // 
            this.lblCodeSent.AutoSize = true;
            this.lblCodeSent.BackColor = System.Drawing.Color.Transparent;
            this.lblCodeSent.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeSent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(1)))), ((int)(((byte)(163)))));
            this.lblCodeSent.Location = new System.Drawing.Point(49, 303);
            this.lblCodeSent.Name = "lblCodeSent";
            this.lblCodeSent.Size = new System.Drawing.Size(119, 27);
            this.lblCodeSent.TabIndex = 66;
            this.lblCodeSent.Text = "Code Sent!";
            this.lblCodeSent.Visible = false;
            this.lblCodeSent.Click += new System.EventHandler(this.lblCodeSent_Click);
            // 
            // loginResultLabel
            // 
            this.loginResultLabel.AutoSize = true;
            this.loginResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginResultLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginResultLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(1)))), ((int)(((byte)(163)))));
            this.loginResultLabel.Location = new System.Drawing.Point(244, 459);
            this.loginResultLabel.Name = "loginResultLabel";
            this.loginResultLabel.Size = new System.Drawing.Size(71, 27);
            this.loginResultLabel.TabIndex = 67;
            this.loginResultLabel.Text = "result";
            this.loginResultLabel.Visible = false;
            // 
            // PreviousButton
            // 
            this.PreviousButton.Image = global::Group_project.Properties.Resources.btnDigitalPrevious;
            this.PreviousButton.Location = new System.Drawing.Point(17, 141);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(55, 45);
            this.PreviousButton.TabIndex = 70;
            this.PreviousButton.UseVisualStyleBackColor = true;
            // 
            // NextButton
            // 
            this.NextButton.Image = global::Group_project.Properties.Resources.btnDigitalNext;
            this.NextButton.Location = new System.Drawing.Point(717, 141);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(55, 45);
            this.NextButton.TabIndex = 69;
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // explainationText
            // 
            this.explainationText.BackColor = System.Drawing.Color.LavenderBlush;
            this.explainationText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.explainationText.Font = new System.Drawing.Font("Segoe WP SemiLight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explainationText.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.explainationText.Location = new System.Drawing.Point(78, 108);
            this.explainationText.Multiline = true;
            this.explainationText.Name = "explainationText";
            this.explainationText.ReadOnly = true;
            this.explainationText.Size = new System.Drawing.Size(632, 123);
            this.explainationText.TabIndex = 68;
            this.explainationText.Text = "Two factor authentication (2FA) is an excellent way of improving account security" +
    ", without adding inconvenience to using the account. ";
            this.explainationText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TwoFactorAuthenticationForm
            // 
            this.AcceptButton = this.LoginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackgroundImage = global::Group_project.Properties.Resources.DigitalSecurityFormBackground_jpg;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.explainationText);
            this.Controls.Add(this.loginResultLabel);
            this.Controls.Add(this.lblCodeSent);
            this.Controls.Add(this.codeInputBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imgTitle);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.OpenAuthButton);
            this.Controls.Add(this.GenCodeButton);
            this.Name = "TwoFactorAuthenticationForm";
            this.Text = "Two Factor Authentication";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closeAuth);
            this.Controls.SetChildIndex(this.GenCodeButton, 0);
            this.Controls.SetChildIndex(this.OpenAuthButton, 0);
            this.Controls.SetChildIndex(this.LoginButton, 0);
            this.Controls.SetChildIndex(this.imgTitle, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.codeInputBox, 0);
            this.Controls.SetChildIndex(this.lblCodeSent, 0);
            this.Controls.SetChildIndex(this.loginResultLabel, 0);
            this.Controls.SetChildIndex(this.explainationText, 0);
            this.Controls.SetChildIndex(this.NextButton, 0);
            this.Controls.SetChildIndex(this.PreviousButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenCodeButton;
        private System.Windows.Forms.Button OpenAuthButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.PictureBox imgTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codeInputBox;
        private System.Windows.Forms.Label lblCodeSent;
        private System.Windows.Forms.Label loginResultLabel;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.TextBox explainationText;
    }
}
