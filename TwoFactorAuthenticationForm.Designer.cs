﻿namespace Group_project
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
            this.lblCodeSent = new System.Windows.Forms.Label();
            this.loginResultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.OpenAuthButton = new System.Windows.Forms.Button();
            this.codeInputBox = new System.Windows.Forms.TextBox();
            this.GenCodeButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.explainationText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodeSent
            // 
            this.lblCodeSent.AutoSize = true;
            this.lblCodeSent.BackColor = System.Drawing.Color.Transparent;
            this.lblCodeSent.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeSent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(1)))), ((int)(((byte)(163)))));
            this.lblCodeSent.Location = new System.Drawing.Point(66, 342);
            this.lblCodeSent.Name = "lblCodeSent";
            this.lblCodeSent.Size = new System.Drawing.Size(119, 27);
            this.lblCodeSent.TabIndex = 28;
            this.lblCodeSent.Text = "Code Sent!";
            this.lblCodeSent.Visible = false;
            // 
            // loginResultLabel
            // 
            this.loginResultLabel.AutoSize = true;
            this.loginResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginResultLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginResultLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(1)))), ((int)(((byte)(163)))));
            this.loginResultLabel.Location = new System.Drawing.Point(229, 489);
            this.loginResultLabel.Name = "loginResultLabel";
            this.loginResultLabel.Size = new System.Drawing.Size(71, 27);
            this.loginResultLabel.TabIndex = 27;
            this.loginResultLabel.Text = "result";
            this.loginResultLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(1)))), ((int)(((byte)(163)))));
            this.label1.Location = new System.Drawing.Point(270, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 40);
            this.label1.TabIndex = 26;
            this.label1.Text = "ENTER CODE";
            // 
            // LoginButton
            // 
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LoginButton.Image = global::Group_project.Properties.Resources.btn2FactorLogin;
            this.LoginButton.Location = new System.Drawing.Point(292, 421);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(171, 50);
            this.LoginButton.TabIndex = 25;
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // OpenAuthButton
            // 
            this.OpenAuthButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OpenAuthButton.Image = global::Group_project.Properties.Resources.btn2FactorAuthenticator;
            this.OpenAuthButton.Location = new System.Drawing.Point(517, 284);
            this.OpenAuthButton.Name = "OpenAuthButton";
            this.OpenAuthButton.Size = new System.Drawing.Size(233, 56);
            this.OpenAuthButton.TabIndex = 23;
            this.OpenAuthButton.UseVisualStyleBackColor = true;
            // 
            // codeInputBox
            // 
            this.codeInputBox.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeInputBox.Location = new System.Drawing.Point(254, 366);
            this.codeInputBox.MaxLength = 8;
            this.codeInputBox.Name = "codeInputBox";
            this.codeInputBox.Size = new System.Drawing.Size(244, 36);
            this.codeInputBox.TabIndex = 24;
            this.codeInputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GenCodeButton
            // 
            this.GenCodeButton.Image = global::Group_project.Properties.Resources.btn2FactorSendCode;
            this.GenCodeButton.Location = new System.Drawing.Point(27, 284);
            this.GenCodeButton.Name = "GenCodeButton";
            this.GenCodeButton.Size = new System.Drawing.Size(198, 55);
            this.GenCodeButton.TabIndex = 22;
            this.GenCodeButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Group_project.Properties.Resources.titleTwoFactor;
            this.pictureBox2.Location = new System.Drawing.Point(106, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(564, 62);
            this.pictureBox2.TabIndex = 68;
            this.pictureBox2.TabStop = false;
            // 
            // PreviousButton
            // 
            this.PreviousButton.Image = global::Group_project.Properties.Resources.btnDigitalPrevious;
            this.PreviousButton.Location = new System.Drawing.Point(9, 184);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(55, 45);
            this.PreviousButton.TabIndex = 67;
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Image = global::Group_project.Properties.Resources.btnDigitalNext;
            this.NextButton.Location = new System.Drawing.Point(717, 184);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(55, 45);
            this.NextButton.TabIndex = 66;
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // explainationText
            // 
            this.explainationText.BackColor = System.Drawing.Color.LavenderBlush;
            this.explainationText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.explainationText.Cursor = System.Windows.Forms.Cursors.Default;
            this.explainationText.Font = new System.Drawing.Font("Segoe WP SemiLight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explainationText.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.explainationText.Location = new System.Drawing.Point(76, 130);
            this.explainationText.Multiline = true;
            this.explainationText.Name = "explainationText";
            this.explainationText.ReadOnly = true;
            this.explainationText.Size = new System.Drawing.Size(632, 123);
            this.explainationText.TabIndex = 65;
            this.explainationText.TabStop = false;
            this.explainationText.Text = "Two factor authentication (2FA) is an excellent way of improving account security" +
    ", without adding inconvenience to using the account.";
            this.explainationText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TwoFactorAuthenticationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackgroundImage = global::Group_project.Properties.Resources.DigitalSecurityFormBackground_jpg;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.explainationText);
            this.Controls.Add(this.lblCodeSent);
            this.Controls.Add(this.loginResultLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.OpenAuthButton);
            this.Controls.Add(this.codeInputBox);
            this.Controls.Add(this.GenCodeButton);
            this.Name = "TwoFactorAuthenticationForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closeAuth);
            this.Load += new System.EventHandler(this.TwoFactorAuthenticationForm_Load);
            this.Controls.SetChildIndex(this.GenCodeButton, 0);
            this.Controls.SetChildIndex(this.codeInputBox, 0);
            this.Controls.SetChildIndex(this.OpenAuthButton, 0);
            this.Controls.SetChildIndex(this.LoginButton, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.loginResultLabel, 0);
            this.Controls.SetChildIndex(this.lblCodeSent, 0);
            this.Controls.SetChildIndex(this.explainationText, 0);
            this.Controls.SetChildIndex(this.NextButton, 0);
            this.Controls.SetChildIndex(this.PreviousButton, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodeSent;
        private System.Windows.Forms.Label loginResultLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button OpenAuthButton;
        private System.Windows.Forms.TextBox codeInputBox;
        private System.Windows.Forms.Button GenCodeButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.TextBox explainationText;

    }
}
