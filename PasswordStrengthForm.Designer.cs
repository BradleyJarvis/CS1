﻿namespace Group_project
{
    partial class PasswordStrengthForm
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
            this.timeTakenLabel = new System.Windows.Forms.Label();
            this.passInputBox = new System.Windows.Forms.TextBox();
            this.lowerCaseBox = new System.Windows.Forms.CheckBox();
            this.numberBox = new System.Windows.Forms.CheckBox();
            this.specialBox = new System.Windows.Forms.CheckBox();
            this.upperCaseBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.explainationText = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeTakenLabel
            // 
            this.timeTakenLabel.AutoSize = true;
            this.timeTakenLabel.Location = new System.Drawing.Point(158, 60);
            this.timeTakenLabel.Name = "timeTakenLabel";
            this.timeTakenLabel.Size = new System.Drawing.Size(188, 13);
            this.timeTakenLabel.TabIndex = 9;
            this.timeTakenLabel.Text = "Enter a password to check its strength";
            // 
            // passInputBox
            // 
            this.passInputBox.Location = new System.Drawing.Point(161, 37);
            this.passInputBox.Name = "passInputBox";
            this.passInputBox.Size = new System.Drawing.Size(178, 20);
            this.passInputBox.TabIndex = 1;
            this.passInputBox.TextChanged += new System.EventHandler(this.passInputBox_TextChanged);
            // 
            // lowerCaseBox
            // 
            this.lowerCaseBox.AutoCheck = false;
            this.lowerCaseBox.AutoSize = true;
            this.lowerCaseBox.Location = new System.Drawing.Point(21, 11);
            this.lowerCaseBox.Name = "lowerCaseBox";
            this.lowerCaseBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lowerCaseBox.Size = new System.Drawing.Size(107, 17);
            this.lowerCaseBox.TabIndex = 3;
            this.lowerCaseBox.TabStop = false;
            this.lowerCaseBox.Text = "Lower case letter";
            this.lowerCaseBox.UseVisualStyleBackColor = true;
            // 
            // numberBox
            // 
            this.numberBox.AutoCheck = false;
            this.numberBox.AutoSize = true;
            this.numberBox.Location = new System.Drawing.Point(65, 57);
            this.numberBox.Name = "numberBox";
            this.numberBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numberBox.Size = new System.Drawing.Size(63, 17);
            this.numberBox.TabIndex = 5;
            this.numberBox.TabStop = false;
            this.numberBox.Text = "Number";
            this.numberBox.UseVisualStyleBackColor = true;
            // 
            // specialBox
            // 
            this.specialBox.AutoCheck = false;
            this.specialBox.AutoSize = true;
            this.specialBox.Location = new System.Drawing.Point(18, 80);
            this.specialBox.Name = "specialBox";
            this.specialBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.specialBox.Size = new System.Drawing.Size(110, 17);
            this.specialBox.TabIndex = 6;
            this.specialBox.TabStop = false;
            this.specialBox.Text = "Special Character";
            this.specialBox.UseVisualStyleBackColor = true;
            // 
            // upperCaseBox
            // 
            this.upperCaseBox.AutoCheck = false;
            this.upperCaseBox.AutoSize = true;
            this.upperCaseBox.Location = new System.Drawing.Point(21, 34);
            this.upperCaseBox.Name = "upperCaseBox";
            this.upperCaseBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.upperCaseBox.Size = new System.Drawing.Size(107, 17);
            this.upperCaseBox.TabIndex = 4;
            this.upperCaseBox.TabStop = false;
            this.upperCaseBox.Text = "Upper case letter";
            this.upperCaseBox.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.upperCaseBox);
            this.panel1.Controls.Add(this.specialBox);
            this.panel1.Controls.Add(this.numberBox);
            this.panel1.Controls.Add(this.lowerCaseBox);
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 105);
            this.panel1.TabIndex = 16;
            // 
            // explainationText
            // 
            this.explainationText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.explainationText.Location = new System.Drawing.Point(162, 77);
            this.explainationText.Multiline = true;
            this.explainationText.Name = "explainationText";
            this.explainationText.ReadOnly = true;
            this.explainationText.Size = new System.Drawing.Size(364, 166);
            this.explainationText.TabIndex = 2;
            this.explainationText.TabStop = false;
            this.explainationText.Text = "Dexcription text should be shown here, generated when page is loaded";
            // 
            // PasswordStrengthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(538, 256);
            this.Controls.Add(this.explainationText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.passInputBox);
            this.Controls.Add(this.timeTakenLabel);
            this.Name = "PasswordStrengthForm";
            this.Controls.SetChildIndex(this.timeTakenLabel, 0);
            this.Controls.SetChildIndex(this.passInputBox, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.explainationText, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeTakenLabel;
        private System.Windows.Forms.TextBox passInputBox;
        private System.Windows.Forms.CheckBox lowerCaseBox;
        private System.Windows.Forms.CheckBox numberBox;
        private System.Windows.Forms.CheckBox specialBox;
        private System.Windows.Forms.CheckBox upperCaseBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox explainationText;
    }
}
