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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TwoFactorAuthenticationForm));
            this.GenCodeButton = new System.Windows.Forms.Button();
            this.codeInputBox = new System.Windows.Forms.TextBox();
            this.OpenAuthButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loginResultLabel = new System.Windows.Forms.Label();
            this.explainationText = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GenCodeButton
            // 
            this.GenCodeButton.Location = new System.Drawing.Point(12, 76);
            this.GenCodeButton.Name = "GenCodeButton";
            this.GenCodeButton.Size = new System.Drawing.Size(75, 23);
            this.GenCodeButton.TabIndex = 1;
            this.GenCodeButton.Text = "Send code";
            this.GenCodeButton.UseVisualStyleBackColor = true;
            this.GenCodeButton.Click += new System.EventHandler(this.genAuthCode);
            // 
            // codeInputBox
            // 
            this.codeInputBox.Location = new System.Drawing.Point(12, 105);
            this.codeInputBox.Name = "codeInputBox";
            this.codeInputBox.Size = new System.Drawing.Size(100, 20);
            this.codeInputBox.TabIndex = 3;
            // 
            // OpenAuthButton
            // 
            this.OpenAuthButton.Location = new System.Drawing.Point(93, 75);
            this.OpenAuthButton.Name = "OpenAuthButton";
            this.OpenAuthButton.Size = new System.Drawing.Size(115, 23);
            this.OpenAuthButton.TabIndex = 2;
            this.OpenAuthButton.Text = "Open authenticator";
            this.OpenAuthButton.UseVisualStyleBackColor = true;
            this.OpenAuthButton.Click += new System.EventHandler(this.showAuth);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(214, 75);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.attemptLogin);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Authenticator code";
            // 
            // loginResultLabel
            // 
            this.loginResultLabel.AutoSize = true;
            this.loginResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginResultLabel.Location = new System.Drawing.Point(21, 128);
            this.loginResultLabel.Name = "loginResultLabel";
            this.loginResultLabel.Size = new System.Drawing.Size(45, 16);
            this.loginResultLabel.TabIndex = 13;
            this.loginResultLabel.Text = "label2";
            this.loginResultLabel.Visible = false;
            // 
            // explainationText
            // 
            this.explainationText.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.explainationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explainationText.Location = new System.Drawing.Point(12, 147);
            this.explainationText.Multiline = true;
            this.explainationText.Name = "explainationText";
            this.explainationText.ReadOnly = true;
            this.explainationText.Size = new System.Drawing.Size(698, 286);
            this.explainationText.TabIndex = 18;
            this.explainationText.TabStop = false;
            this.explainationText.Text = resources.GetString("explainationText.Text");
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TitleLabel.Location = new System.Drawing.Point(7, 24);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(290, 25);
            this.TitleLabel.TabIndex = 44;
            this.TitleLabel.Text = "Two Factor Authentication";
            // 
            // TwoFactorAuthenticationForm
            // 
            this.AcceptButton = this.LoginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(723, 445);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.explainationText);
            this.Controls.Add(this.loginResultLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.OpenAuthButton);
            this.Controls.Add(this.codeInputBox);
            this.Controls.Add(this.GenCodeButton);
            this.Name = "TwoFactorAuthenticationForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closeAuth);
            this.Controls.SetChildIndex(this.GenCodeButton, 0);
            this.Controls.SetChildIndex(this.codeInputBox, 0);
            this.Controls.SetChildIndex(this.OpenAuthButton, 0);
            this.Controls.SetChildIndex(this.LoginButton, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.loginResultLabel, 0);
            this.Controls.SetChildIndex(this.explainationText, 0);
            this.Controls.SetChildIndex(this.TitleLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenCodeButton;
        private System.Windows.Forms.TextBox codeInputBox;
        private System.Windows.Forms.Button OpenAuthButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label loginResultLabel;
        private System.Windows.Forms.TextBox explainationText;
        private System.Windows.Forms.Label TitleLabel;
    }
}
