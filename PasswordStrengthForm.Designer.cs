namespace Group_project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordStrengthForm));
            this.explainationText = new System.Windows.Forms.TextBox();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.lblUpperCase = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblLowerCase = new System.Windows.Forms.Label();
            this.lblSpecialChar = new System.Windows.Forms.Label();
            this.timeTakenLabel = new System.Windows.Forms.Label();
            this.passInputBox = new System.Windows.Forms.TextBox();
            this.imgPadlock = new System.Windows.Forms.PictureBox();
            this.imgUpperCase = new System.Windows.Forms.PictureBox();
            this.imgLowerCase = new System.Windows.Forms.PictureBox();
            this.imgSpecialChar = new System.Windows.Forms.PictureBox();
            this.imgNumberPresent = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgPadlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUpperCase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLowerCase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSpecialChar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNumberPresent)).BeginInit();
            this.SuspendLayout();
            // 
            // explainationText
            // 
            this.explainationText.BackColor = System.Drawing.Color.LavenderBlush;
            this.explainationText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.explainationText.Cursor = System.Windows.Forms.Cursors.Default;
            this.explainationText.Font = new System.Drawing.Font("Segoe WP SemiLight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explainationText.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.explainationText.Location = new System.Drawing.Point(76, 114);
            this.explainationText.Multiline = true;
            this.explainationText.Name = "explainationText";
            this.explainationText.ReadOnly = true;
            this.explainationText.Size = new System.Drawing.Size(632, 123);
            this.explainationText.TabIndex = 1;
            this.explainationText.TabStop = false;
            this.explainationText.Text = "A simple way of accessing an account is to use brute force guessing to try every " +
    "possible combination of characters until the correct password is found.";
            this.explainationText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PreviousButton
            // 
            this.PreviousButton.Image = global::Group_project.Properties.Resources.btnDigitalPrevious;
            this.PreviousButton.Location = new System.Drawing.Point(9, 168);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(55, 45);
            this.PreviousButton.TabIndex = 47;
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Image = global::Group_project.Properties.Resources.btnDigitalNext;
            this.NextButton.Location = new System.Drawing.Point(717, 168);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(55, 45);
            this.NextButton.TabIndex = 46;
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // lblUpperCase
            // 
            this.lblUpperCase.AutoSize = true;
            this.lblUpperCase.BackColor = System.Drawing.Color.Transparent;
            this.lblUpperCase.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblUpperCase.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpperCase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(1)))), ((int)(((byte)(163)))));
            this.lblUpperCase.Location = new System.Drawing.Point(78, 266);
            this.lblUpperCase.Name = "lblUpperCase";
            this.lblUpperCase.Size = new System.Drawing.Size(194, 24);
            this.lblUpperCase.TabIndex = 48;
            this.lblUpperCase.Text = "UPPER CASE LETTER";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblNumber.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNumber.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(1)))), ((int)(((byte)(163)))));
            this.lblNumber.Location = new System.Drawing.Point(530, 320);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(84, 24);
            this.lblNumber.TabIndex = 49;
            this.lblNumber.Text = "NUMBER";
            // 
            // lblLowerCase
            // 
            this.lblLowerCase.AutoSize = true;
            this.lblLowerCase.BackColor = System.Drawing.Color.Transparent;
            this.lblLowerCase.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLowerCase.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowerCase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(1)))), ((int)(((byte)(163)))));
            this.lblLowerCase.Location = new System.Drawing.Point(72, 320);
            this.lblLowerCase.Name = "lblLowerCase";
            this.lblLowerCase.Size = new System.Drawing.Size(200, 24);
            this.lblLowerCase.TabIndex = 50;
            this.lblLowerCase.Text = "LOWER CASE LETTER";
            // 
            // lblSpecialChar
            // 
            this.lblSpecialChar.AutoSize = true;
            this.lblSpecialChar.BackColor = System.Drawing.Color.Transparent;
            this.lblSpecialChar.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSpecialChar.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialChar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(1)))), ((int)(((byte)(163)))));
            this.lblSpecialChar.Location = new System.Drawing.Point(419, 256);
            this.lblSpecialChar.Name = "lblSpecialChar";
            this.lblSpecialChar.Size = new System.Drawing.Size(195, 24);
            this.lblSpecialChar.TabIndex = 51;
            this.lblSpecialChar.Text = "SPECIAL CHARACTER";
            // 
            // timeTakenLabel
            // 
            this.timeTakenLabel.AutoSize = true;
            this.timeTakenLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeTakenLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.timeTakenLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTakenLabel.ForeColor = System.Drawing.Color.Green;
            this.timeTakenLabel.Location = new System.Drawing.Point(99, 414);
            this.timeTakenLabel.Name = "timeTakenLabel";
            this.timeTakenLabel.Size = new System.Drawing.Size(369, 24);
            this.timeTakenLabel.TabIndex = 52;
            this.timeTakenLabel.Text = "ENTER PASSWORD TO CHECK STRENGTH";
            this.timeTakenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passInputBox
            // 
            this.passInputBox.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passInputBox.Location = new System.Drawing.Point(157, 364);
            this.passInputBox.MaxLength = 999;
            this.passInputBox.Name = "passInputBox";
            this.passInputBox.Size = new System.Drawing.Size(485, 36);
            this.passInputBox.TabIndex = 53;
            this.passInputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passInputBox.TextChanged += new System.EventHandler(this.passInputBox_TextChanged);
            // 
            // imgPadlock
            // 
            this.imgPadlock.BackColor = System.Drawing.Color.Transparent;
            this.imgPadlock.Image = global::Group_project.Properties.Resources._lock;
            this.imgPadlock.Location = new System.Drawing.Point(330, 441);
            this.imgPadlock.Name = "imgPadlock";
            this.imgPadlock.Size = new System.Drawing.Size(105, 118);
            this.imgPadlock.TabIndex = 54;
            this.imgPadlock.TabStop = false;
            this.imgPadlock.Visible = false;
            // 
            // imgUpperCase
            // 
            this.imgUpperCase.BackColor = System.Drawing.Color.Transparent;
            this.imgUpperCase.Image = ((System.Drawing.Image)(resources.GetObject("imgUpperCase.Image")));
            this.imgUpperCase.Location = new System.Drawing.Point(292, 243);
            this.imgUpperCase.Name = "imgUpperCase";
            this.imgUpperCase.Size = new System.Drawing.Size(49, 47);
            this.imgUpperCase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUpperCase.TabIndex = 55;
            this.imgUpperCase.TabStop = false;
            // 
            // imgLowerCase
            // 
            this.imgLowerCase.BackColor = System.Drawing.Color.Transparent;
            this.imgLowerCase.Image = ((System.Drawing.Image)(resources.GetObject("imgLowerCase.Image")));
            this.imgLowerCase.Location = new System.Drawing.Point(292, 297);
            this.imgLowerCase.Name = "imgLowerCase";
            this.imgLowerCase.Size = new System.Drawing.Size(49, 47);
            this.imgLowerCase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLowerCase.TabIndex = 56;
            this.imgLowerCase.TabStop = false;
            // 
            // imgSpecialChar
            // 
            this.imgSpecialChar.BackColor = System.Drawing.Color.Transparent;
            this.imgSpecialChar.Image = ((System.Drawing.Image)(resources.GetObject("imgSpecialChar.Image")));
            this.imgSpecialChar.Location = new System.Drawing.Point(629, 243);
            this.imgSpecialChar.Name = "imgSpecialChar";
            this.imgSpecialChar.Size = new System.Drawing.Size(49, 47);
            this.imgSpecialChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSpecialChar.TabIndex = 57;
            this.imgSpecialChar.TabStop = false;
            // 
            // imgNumberPresent
            // 
            this.imgNumberPresent.BackColor = System.Drawing.Color.Transparent;
            this.imgNumberPresent.Image = ((System.Drawing.Image)(resources.GetObject("imgNumberPresent.Image")));
            this.imgNumberPresent.Location = new System.Drawing.Point(629, 297);
            this.imgNumberPresent.Name = "imgNumberPresent";
            this.imgNumberPresent.Size = new System.Drawing.Size(49, 47);
            this.imgNumberPresent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgNumberPresent.TabIndex = 58;
            this.imgNumberPresent.TabStop = false;
            // 
            // PasswordStrengthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackgroundImage = global::Group_project.Properties.Resources.DigitalSecurityFormBackground_jpg;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.imgNumberPresent);
            this.Controls.Add(this.imgSpecialChar);
            this.Controls.Add(this.imgLowerCase);
            this.Controls.Add(this.imgUpperCase);
            this.Controls.Add(this.imgPadlock);
            this.Controls.Add(this.passInputBox);
            this.Controls.Add(this.timeTakenLabel);
            this.Controls.Add(this.lblSpecialChar);
            this.Controls.Add(this.lblLowerCase);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblUpperCase);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.explainationText);
            this.Name = "PasswordStrengthForm";
            this.Text = "Password Strength";
            this.Controls.SetChildIndex(this.explainationText, 0);
            this.Controls.SetChildIndex(this.NextButton, 0);
            this.Controls.SetChildIndex(this.PreviousButton, 0);
            this.Controls.SetChildIndex(this.lblUpperCase, 0);
            this.Controls.SetChildIndex(this.lblNumber, 0);
            this.Controls.SetChildIndex(this.lblLowerCase, 0);
            this.Controls.SetChildIndex(this.lblSpecialChar, 0);
            this.Controls.SetChildIndex(this.timeTakenLabel, 0);
            this.Controls.SetChildIndex(this.passInputBox, 0);
            this.Controls.SetChildIndex(this.imgPadlock, 0);
            this.Controls.SetChildIndex(this.imgUpperCase, 0);
            this.Controls.SetChildIndex(this.imgLowerCase, 0);
            this.Controls.SetChildIndex(this.imgSpecialChar, 0);
            this.Controls.SetChildIndex(this.imgNumberPresent, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgPadlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUpperCase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLowerCase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSpecialChar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNumberPresent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox explainationText;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label lblUpperCase;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblLowerCase;
        private System.Windows.Forms.Label lblSpecialChar;
        private System.Windows.Forms.Label timeTakenLabel;
        private System.Windows.Forms.TextBox passInputBox;
        private System.Windows.Forms.PictureBox imgPadlock;
        private System.Windows.Forms.PictureBox imgUpperCase;
        private System.Windows.Forms.PictureBox imgLowerCase;
        private System.Windows.Forms.PictureBox imgSpecialChar;
        private System.Windows.Forms.PictureBox imgNumberPresent;
    }
}
