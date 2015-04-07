namespace Group_project
{
    partial class PublicKeysForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PublicKeysForm));
            this.IntroductionTextBox = new System.Windows.Forms.TextBox();
            this.OutlineTextBox = new System.Windows.Forms.TextBox();
            this.FacorisingIntroductionTextBox = new System.Windows.Forms.TextBox();
            this.StartingTextBox = new System.Windows.Forms.TextBox();
            this.Back1Button = new System.Windows.Forms.Button();
            this.GenerateAndMultiplyButton = new System.Windows.Forms.Button();
            this.FirstPrimeNumberTextLabel = new System.Windows.Forms.Label();
            this.SecondPrimeNumberTextLabel = new System.Windows.Forms.Label();
            this.FirstPrimeNumberLabel = new System.Windows.Forms.Label();
            this.SecondPrimeNumberLabel = new System.Windows.Forms.Label();
            this.FirstPrimeNumberTimesSecondPrimeNumberTextLabel = new System.Windows.Forms.Label();
            this.FirstPrimeNumberTimesSecondPrimeNumberLabel = new System.Windows.Forms.Label();
            this.PhiTextBox = new System.Windows.Forms.TextBox();
            this.FindPhiButton = new System.Windows.Forms.Button();
            this.Back2Button = new System.Windows.Forms.Button();
            this.DTextBox = new System.Windows.Forms.TextBox();
            this.PhiPrivateTextLabel = new System.Windows.Forms.Label();
            this.PhiPublicLabel = new System.Windows.Forms.Label();
            this.FindDButton = new System.Windows.Forms.Button();
            this.DTextLabel = new System.Windows.Forms.Label();
            this.DLabel = new System.Windows.Forms.Label();
            this.ExponentTextLabel = new System.Windows.Forms.Label();
            this.ExponentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IntroductionTextBox
            // 
            this.IntroductionTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.IntroductionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntroductionTextBox.Location = new System.Drawing.Point(12, 27);
            this.IntroductionTextBox.Multiline = true;
            this.IntroductionTextBox.Name = "IntroductionTextBox";
            this.IntroductionTextBox.ReadOnly = true;
            this.IntroductionTextBox.Size = new System.Drawing.Size(1283, 72);
            this.IntroductionTextBox.TabIndex = 161;
            this.IntroductionTextBox.TabStop = false;
            this.IntroductionTextBox.Text = resources.GetString("IntroductionTextBox.Text");
            // 
            // OutlineTextBox
            // 
            this.OutlineTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.OutlineTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutlineTextBox.Location = new System.Drawing.Point(12, 105);
            this.OutlineTextBox.Multiline = true;
            this.OutlineTextBox.Name = "OutlineTextBox";
            this.OutlineTextBox.ReadOnly = true;
            this.OutlineTextBox.Size = new System.Drawing.Size(1283, 213);
            this.OutlineTextBox.TabIndex = 144;
            this.OutlineTextBox.TabStop = false;
            this.OutlineTextBox.Text = resources.GetString("OutlineTextBox.Text");
            // 
            // FacorisingIntroductionTextBox
            // 
            this.FacorisingIntroductionTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.FacorisingIntroductionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacorisingIntroductionTextBox.Location = new System.Drawing.Point(12, 324);
            this.FacorisingIntroductionTextBox.Multiline = true;
            this.FacorisingIntroductionTextBox.Name = "FacorisingIntroductionTextBox";
            this.FacorisingIntroductionTextBox.ReadOnly = true;
            this.FacorisingIntroductionTextBox.Size = new System.Drawing.Size(1283, 72);
            this.FacorisingIntroductionTextBox.TabIndex = 145;
            this.FacorisingIntroductionTextBox.TabStop = false;
            this.FacorisingIntroductionTextBox.Text = resources.GetString("FacorisingIntroductionTextBox.Text");
            // 
            // StartingTextBox
            // 
            this.StartingTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.StartingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartingTextBox.Location = new System.Drawing.Point(12, 402);
            this.StartingTextBox.Multiline = true;
            this.StartingTextBox.Name = "StartingTextBox";
            this.StartingTextBox.ReadOnly = true;
            this.StartingTextBox.Size = new System.Drawing.Size(747, 155);
            this.StartingTextBox.TabIndex = 146;
            this.StartingTextBox.TabStop = false;
            this.StartingTextBox.Text = resources.GetString("StartingTextBox.Text");
            // 
            // Back1Button
            // 
            this.Back1Button.Location = new System.Drawing.Point(12, 680);
            this.Back1Button.Name = "Back1Button";
            this.Back1Button.Size = new System.Drawing.Size(75, 23);
            this.Back1Button.TabIndex = 147;
            this.Back1Button.Text = "Back";
            this.Back1Button.UseVisualStyleBackColor = true;
            this.Back1Button.Visible = false;
            this.Back1Button.Click += new System.EventHandler(this.Back1Button_Click);
            // 
            // GenerateAndMultiplyButton
            // 
            this.GenerateAndMultiplyButton.Location = new System.Drawing.Point(284, 563);
            this.GenerateAndMultiplyButton.Name = "GenerateAndMultiplyButton";
            this.GenerateAndMultiplyButton.Size = new System.Drawing.Size(123, 23);
            this.GenerateAndMultiplyButton.TabIndex = 141;
            this.GenerateAndMultiplyButton.Text = "Generate And Multiply";
            this.GenerateAndMultiplyButton.UseVisualStyleBackColor = true;
            this.GenerateAndMultiplyButton.Click += new System.EventHandler(this.GenerateAndMultiplyButton_Click);
            // 
            // FirstPrimeNumberTextLabel
            // 
            this.FirstPrimeNumberTextLabel.AutoSize = true;
            this.FirstPrimeNumberTextLabel.Location = new System.Drawing.Point(797, 402);
            this.FirstPrimeNumberTextLabel.Name = "FirstPrimeNumberTextLabel";
            this.FirstPrimeNumberTextLabel.Size = new System.Drawing.Size(95, 13);
            this.FirstPrimeNumberTextLabel.TabIndex = 149;
            this.FirstPrimeNumberTextLabel.Text = "First Prime Number";
            // 
            // SecondPrimeNumberTextLabel
            // 
            this.SecondPrimeNumberTextLabel.AutoSize = true;
            this.SecondPrimeNumberTextLabel.Location = new System.Drawing.Point(797, 415);
            this.SecondPrimeNumberTextLabel.Name = "SecondPrimeNumberTextLabel";
            this.SecondPrimeNumberTextLabel.Size = new System.Drawing.Size(113, 13);
            this.SecondPrimeNumberTextLabel.TabIndex = 150;
            this.SecondPrimeNumberTextLabel.Text = "Second Prime Number";
            // 
            // FirstPrimeNumberLabel
            // 
            this.FirstPrimeNumberLabel.AutoSize = true;
            this.FirstPrimeNumberLabel.Location = new System.Drawing.Point(916, 402);
            this.FirstPrimeNumberLabel.Name = "FirstPrimeNumberLabel";
            this.FirstPrimeNumberLabel.Size = new System.Drawing.Size(13, 13);
            this.FirstPrimeNumberLabel.TabIndex = 151;
            this.FirstPrimeNumberLabel.Text = "_";
            // 
            // SecondPrimeNumberLabel
            // 
            this.SecondPrimeNumberLabel.AutoSize = true;
            this.SecondPrimeNumberLabel.Location = new System.Drawing.Point(916, 415);
            this.SecondPrimeNumberLabel.Name = "SecondPrimeNumberLabel";
            this.SecondPrimeNumberLabel.Size = new System.Drawing.Size(13, 13);
            this.SecondPrimeNumberLabel.TabIndex = 152;
            this.SecondPrimeNumberLabel.Text = "_";
            // 
            // FirstPrimeNumberTimesSecondPrimeNumberTextLabel
            // 
            this.FirstPrimeNumberTimesSecondPrimeNumberTextLabel.AutoSize = true;
            this.FirstPrimeNumberTimesSecondPrimeNumberTextLabel.Location = new System.Drawing.Point(797, 448);
            this.FirstPrimeNumberTimesSecondPrimeNumberTextLabel.Name = "FirstPrimeNumberTimesSecondPrimeNumberTextLabel";
            this.FirstPrimeNumberTimesSecondPrimeNumberTextLabel.Size = new System.Drawing.Size(232, 13);
            this.FirstPrimeNumberTimesSecondPrimeNumberTextLabel.TabIndex = 153;
            this.FirstPrimeNumberTimesSecondPrimeNumberTextLabel.Text = "FirstPrime Number Times Second Prime Number";
            // 
            // FirstPrimeNumberTimesSecondPrimeNumberLabel
            // 
            this.FirstPrimeNumberTimesSecondPrimeNumberLabel.AutoSize = true;
            this.FirstPrimeNumberTimesSecondPrimeNumberLabel.Location = new System.Drawing.Point(797, 461);
            this.FirstPrimeNumberTimesSecondPrimeNumberLabel.Name = "FirstPrimeNumberTimesSecondPrimeNumberLabel";
            this.FirstPrimeNumberTimesSecondPrimeNumberLabel.Size = new System.Drawing.Size(13, 13);
            this.FirstPrimeNumberTimesSecondPrimeNumberLabel.TabIndex = 154;
            this.FirstPrimeNumberTimesSecondPrimeNumberLabel.Text = "_";
            // 
            // PhiTextBox
            // 
            this.PhiTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PhiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhiTextBox.Location = new System.Drawing.Point(12, 402);
            this.PhiTextBox.Multiline = true;
            this.PhiTextBox.Name = "PhiTextBox";
            this.PhiTextBox.ReadOnly = true;
            this.PhiTextBox.Size = new System.Drawing.Size(747, 272);
            this.PhiTextBox.TabIndex = 155;
            this.PhiTextBox.TabStop = false;
            this.PhiTextBox.Text = resources.GetString("PhiTextBox.Text");
            this.PhiTextBox.Visible = false;
            // 
            // FindPhiButton
            // 
            this.FindPhiButton.Location = new System.Drawing.Point(311, 680);
            this.FindPhiButton.Name = "FindPhiButton";
            this.FindPhiButton.Size = new System.Drawing.Size(75, 23);
            this.FindPhiButton.TabIndex = 156;
            this.FindPhiButton.Text = "Find Փ";
            this.FindPhiButton.UseVisualStyleBackColor = true;
            this.FindPhiButton.Visible = false;
            this.FindPhiButton.Click += new System.EventHandler(this.FindPhiButton_Click);
            // 
            // Back2Button
            // 
            this.Back2Button.Location = new System.Drawing.Point(12, 637);
            this.Back2Button.Name = "Back2Button";
            this.Back2Button.Size = new System.Drawing.Size(75, 23);
            this.Back2Button.TabIndex = 157;
            this.Back2Button.Text = "Back";
            this.Back2Button.UseVisualStyleBackColor = true;
            this.Back2Button.Visible = false;
            this.Back2Button.Click += new System.EventHandler(this.Back2Button_Click);
            // 
            // DTextBox
            // 
            this.DTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTextBox.Location = new System.Drawing.Point(12, 402);
            this.DTextBox.Multiline = true;
            this.DTextBox.Name = "DTextBox";
            this.DTextBox.ReadOnly = true;
            this.DTextBox.Size = new System.Drawing.Size(747, 229);
            this.DTextBox.TabIndex = 158;
            this.DTextBox.TabStop = false;
            this.DTextBox.Text = resources.GetString("DTextBox.Text");
            this.DTextBox.Visible = false;
            // 
            // PhiPrivateTextLabel
            // 
            this.PhiPrivateTextLabel.AutoSize = true;
            this.PhiPrivateTextLabel.Location = new System.Drawing.Point(797, 488);
            this.PhiPrivateTextLabel.Name = "PhiPrivateTextLabel";
            this.PhiPrivateTextLabel.Size = new System.Drawing.Size(56, 13);
            this.PhiPrivateTextLabel.TabIndex = 159;
            this.PhiPrivateTextLabel.Text = "Phi Secret";
            this.PhiPrivateTextLabel.Visible = false;
            // 
            // PhiPublicLabel
            // 
            this.PhiPublicLabel.AutoSize = true;
            this.PhiPublicLabel.Location = new System.Drawing.Point(797, 501);
            this.PhiPublicLabel.Name = "PhiPublicLabel";
            this.PhiPublicLabel.Size = new System.Drawing.Size(13, 13);
            this.PhiPublicLabel.TabIndex = 160;
            this.PhiPublicLabel.Text = "_";
            this.PhiPublicLabel.Visible = false;
            // 
            // FindDButton
            // 
            this.FindDButton.Location = new System.Drawing.Point(311, 637);
            this.FindDButton.Name = "FindDButton";
            this.FindDButton.Size = new System.Drawing.Size(75, 23);
            this.FindDButton.TabIndex = 161;
            this.FindDButton.Text = "Find D";
            this.FindDButton.UseVisualStyleBackColor = true;
            this.FindDButton.Visible = false;
            this.FindDButton.Click += new System.EventHandler(this.FindDButton_Click);
            // 
            // DTextLabel
            // 
            this.DTextLabel.AutoSize = true;
            this.DTextLabel.Location = new System.Drawing.Point(797, 563);
            this.DTextLabel.Name = "DTextLabel";
            this.DTextLabel.Size = new System.Drawing.Size(15, 13);
            this.DTextLabel.TabIndex = 162;
            this.DTextLabel.Text = "D";
            this.DTextLabel.Visible = false;
            // 
            // DLabel
            // 
            this.DLabel.AutoSize = true;
            this.DLabel.Location = new System.Drawing.Point(797, 576);
            this.DLabel.Name = "DLabel";
            this.DLabel.Size = new System.Drawing.Size(13, 13);
            this.DLabel.TabIndex = 163;
            this.DLabel.Text = "_";
            this.DLabel.Visible = false;
            // 
            // ExponentTextLabel
            // 
            this.ExponentTextLabel.AutoSize = true;
            this.ExponentTextLabel.Location = new System.Drawing.Point(797, 524);
            this.ExponentTextLabel.Name = "ExponentTextLabel";
            this.ExponentTextLabel.Size = new System.Drawing.Size(52, 13);
            this.ExponentTextLabel.TabIndex = 164;
            this.ExponentTextLabel.Text = "Exponent";
            this.ExponentTextLabel.Visible = false;
            // 
            // ExponentLabel
            // 
            this.ExponentLabel.AutoSize = true;
            this.ExponentLabel.Location = new System.Drawing.Point(797, 537);
            this.ExponentLabel.Name = "ExponentLabel";
            this.ExponentLabel.Size = new System.Drawing.Size(13, 13);
            this.ExponentLabel.TabIndex = 165;
            this.ExponentLabel.Text = "_";
            this.ExponentLabel.Visible = false;
            // 
            // PublicKeysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1311, 971);
            this.Controls.Add(this.ExponentLabel);
            this.Controls.Add(this.ExponentTextLabel);
            this.Controls.Add(this.DLabel);
            this.Controls.Add(this.DTextLabel);
            this.Controls.Add(this.FindDButton);
            this.Controls.Add(this.PhiPublicLabel);
            this.Controls.Add(this.PhiPrivateTextLabel);
            this.Controls.Add(this.DTextBox);
            this.Controls.Add(this.Back2Button);
            this.Controls.Add(this.FindPhiButton);
            this.Controls.Add(this.PhiTextBox);
            this.Controls.Add(this.FirstPrimeNumberTimesSecondPrimeNumberLabel);
            this.Controls.Add(this.FirstPrimeNumberTimesSecondPrimeNumberTextLabel);
            this.Controls.Add(this.SecondPrimeNumberLabel);
            this.Controls.Add(this.FirstPrimeNumberLabel);
            this.Controls.Add(this.SecondPrimeNumberTextLabel);
            this.Controls.Add(this.FirstPrimeNumberTextLabel);
            this.Controls.Add(this.GenerateAndMultiplyButton);
            this.Controls.Add(this.Back1Button);
            this.Controls.Add(this.StartingTextBox);
            this.Controls.Add(this.FacorisingIntroductionTextBox);
            this.Controls.Add(this.OutlineTextBox);
            this.Controls.Add(this.IntroductionTextBox);
            this.Name = "PublicKeysForm";
            this.Controls.SetChildIndex(this.IntroductionTextBox, 0);
            this.Controls.SetChildIndex(this.OutlineTextBox, 0);
            this.Controls.SetChildIndex(this.FacorisingIntroductionTextBox, 0);
            this.Controls.SetChildIndex(this.StartingTextBox, 0);
            this.Controls.SetChildIndex(this.Back1Button, 0);
            this.Controls.SetChildIndex(this.GenerateAndMultiplyButton, 0);
            this.Controls.SetChildIndex(this.FirstPrimeNumberTextLabel, 0);
            this.Controls.SetChildIndex(this.SecondPrimeNumberTextLabel, 0);
            this.Controls.SetChildIndex(this.FirstPrimeNumberLabel, 0);
            this.Controls.SetChildIndex(this.SecondPrimeNumberLabel, 0);
            this.Controls.SetChildIndex(this.FirstPrimeNumberTimesSecondPrimeNumberTextLabel, 0);
            this.Controls.SetChildIndex(this.FirstPrimeNumberTimesSecondPrimeNumberLabel, 0);
            this.Controls.SetChildIndex(this.PhiTextBox, 0);
            this.Controls.SetChildIndex(this.FindPhiButton, 0);
            this.Controls.SetChildIndex(this.Back2Button, 0);
            this.Controls.SetChildIndex(this.DTextBox, 0);
            this.Controls.SetChildIndex(this.PhiPrivateTextLabel, 0);
            this.Controls.SetChildIndex(this.PhiPublicLabel, 0);
            this.Controls.SetChildIndex(this.FindDButton, 0);
            this.Controls.SetChildIndex(this.DTextLabel, 0);
            this.Controls.SetChildIndex(this.DLabel, 0);
            this.Controls.SetChildIndex(this.ExponentTextLabel, 0);
            this.Controls.SetChildIndex(this.ExponentLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IntroductionTextBox;
        private System.Windows.Forms.TextBox OutlineTextBox;
        private System.Windows.Forms.TextBox FacorisingIntroductionTextBox;
        private System.Windows.Forms.TextBox StartingTextBox;
        private System.Windows.Forms.Button Back1Button;
        private System.Windows.Forms.Button GenerateAndMultiplyButton;
        private System.Windows.Forms.Label FirstPrimeNumberTextLabel;
        private System.Windows.Forms.Label SecondPrimeNumberTextLabel;
        private System.Windows.Forms.Label FirstPrimeNumberLabel;
        private System.Windows.Forms.Label SecondPrimeNumberLabel;
        private System.Windows.Forms.Label FirstPrimeNumberTimesSecondPrimeNumberTextLabel;
        private System.Windows.Forms.Label FirstPrimeNumberTimesSecondPrimeNumberLabel;
        private System.Windows.Forms.TextBox PhiTextBox;
        private System.Windows.Forms.Button FindPhiButton;
        private System.Windows.Forms.Button Back2Button;
        private System.Windows.Forms.TextBox DTextBox;
        private System.Windows.Forms.Label PhiPrivateTextLabel;
        private System.Windows.Forms.Label PhiPublicLabel;
        private System.Windows.Forms.Button FindDButton;
        private System.Windows.Forms.Label DTextLabel;
        private System.Windows.Forms.Label DLabel;
        private System.Windows.Forms.Label ExponentTextLabel;
        private System.Windows.Forms.Label ExponentLabel;

    }
}
