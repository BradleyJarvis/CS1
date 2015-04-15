namespace Group_project
{
    partial class PasswordManagersForm
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
            this.passOutputBox = new System.Windows.Forms.TextBox();
            this.passLengthBox = new System.Windows.Forms.NumericUpDown();
            this.specalCheckBox = new System.Windows.Forms.CheckBox();
            this.lblLowerCase = new System.Windows.Forms.Label();
            this.GenPassButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.explainationText = new System.Windows.Forms.TextBox();
            this.imgTitle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.passLengthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // passOutputBox
            // 
            this.passOutputBox.BackColor = System.Drawing.Color.White;
            this.passOutputBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.passOutputBox.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passOutputBox.Location = new System.Drawing.Point(78, 384);
            this.passOutputBox.Name = "passOutputBox";
            this.passOutputBox.ReadOnly = true;
            this.passOutputBox.Size = new System.Drawing.Size(628, 36);
            this.passOutputBox.TabIndex = 4;
            this.passOutputBox.TabStop = false;
            this.passOutputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passLengthBox
            // 
            this.passLengthBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.passLengthBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passLengthBox.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLengthBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.passLengthBox.Location = new System.Drawing.Point(274, 274);
            this.passLengthBox.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.passLengthBox.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.passLengthBox.Name = "passLengthBox";
            this.passLengthBox.Size = new System.Drawing.Size(72, 64);
            this.passLengthBox.TabIndex = 1;
            this.passLengthBox.TabStop = false;
            this.passLengthBox.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // specalCheckBox
            // 
            this.specalCheckBox.AutoSize = true;
            this.specalCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.specalCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specalCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.specalCheckBox.Location = new System.Drawing.Point(381, 350);
            this.specalCheckBox.Name = "specalCheckBox";
            this.specalCheckBox.Size = new System.Drawing.Size(325, 28);
            this.specalCheckBox.TabIndex = 2;
            this.specalCheckBox.Text = "INCLUDE SPECIAL CHARACTERS";
            this.specalCheckBox.UseVisualStyleBackColor = false;
            // 
            // lblLowerCase
            // 
            this.lblLowerCase.AutoSize = true;
            this.lblLowerCase.BackColor = System.Drawing.Color.Transparent;
            this.lblLowerCase.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLowerCase.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowerCase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(1)))), ((int)(((byte)(163)))));
            this.lblLowerCase.Location = new System.Drawing.Point(74, 301);
            this.lblLowerCase.Name = "lblLowerCase";
            this.lblLowerCase.Size = new System.Drawing.Size(185, 24);
            this.lblLowerCase.TabIndex = 51;
            this.lblLowerCase.Text = "PASSWORD LENGTH";
            // 
            // GenPassButton
            // 
            this.GenPassButton.BackgroundImage = global::Group_project.Properties.Resources.btnGeneratePass;
            this.GenPassButton.Location = new System.Drawing.Point(252, 438);
            this.GenPassButton.Name = "GenPassButton";
            this.GenPassButton.Size = new System.Drawing.Size(275, 51);
            this.GenPassButton.TabIndex = 3;
            this.GenPassButton.UseVisualStyleBackColor = true;
            this.GenPassButton.Click += new System.EventHandler(this.genPassword);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Image = global::Group_project.Properties.Resources.btnDigitalPrevious;
            this.PreviousButton.Location = new System.Drawing.Point(21, 164);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(55, 45);
            this.PreviousButton.TabIndex = 54;
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Image = global::Group_project.Properties.Resources.btnDigitalNext;
            this.NextButton.Location = new System.Drawing.Point(717, 164);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(55, 45);
            this.NextButton.TabIndex = 53;
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
            this.explainationText.Location = new System.Drawing.Point(82, 125);
            this.explainationText.Multiline = true;
            this.explainationText.Name = "explainationText";
            this.explainationText.ReadOnly = true;
            this.explainationText.Size = new System.Drawing.Size(632, 123);
            this.explainationText.TabIndex = 52;
            this.explainationText.TabStop = false;
            this.explainationText.Text = "A good password is one that is difficult to guess. A simple way of creating one i" +
    "s to simply randomly generate one.";
            this.explainationText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // imgTitle
            // 
            this.imgTitle.BackColor = System.Drawing.Color.Transparent;
            this.imgTitle.Image = global::Group_project.Properties.Resources.titlePassManager;
            this.imgTitle.Location = new System.Drawing.Point(144, 47);
            this.imgTitle.Name = "imgTitle";
            this.imgTitle.Size = new System.Drawing.Size(492, 51);
            this.imgTitle.TabIndex = 62;
            this.imgTitle.TabStop = false;
            // 
            // PasswordManagersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackgroundImage = global::Group_project.Properties.Resources.DigitalSecurityFormBackground_jpg;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.imgTitle);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.explainationText);
            this.Controls.Add(this.lblLowerCase);
            this.Controls.Add(this.specalCheckBox);
            this.Controls.Add(this.GenPassButton);
            this.Controls.Add(this.passLengthBox);
            this.Controls.Add(this.passOutputBox);
            this.Name = "PasswordManagersForm";
            this.Text = "Password Manager";
            this.Controls.SetChildIndex(this.passOutputBox, 0);
            this.Controls.SetChildIndex(this.passLengthBox, 0);
            this.Controls.SetChildIndex(this.GenPassButton, 0);
            this.Controls.SetChildIndex(this.specalCheckBox, 0);
            this.Controls.SetChildIndex(this.lblLowerCase, 0);
            this.Controls.SetChildIndex(this.explainationText, 0);
            this.Controls.SetChildIndex(this.NextButton, 0);
            this.Controls.SetChildIndex(this.PreviousButton, 0);
            this.Controls.SetChildIndex(this.imgTitle, 0);
            ((System.ComponentModel.ISupportInitialize)(this.passLengthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passOutputBox;
        private System.Windows.Forms.NumericUpDown passLengthBox;
        private System.Windows.Forms.Button GenPassButton;
        private System.Windows.Forms.CheckBox specalCheckBox;
        private System.Windows.Forms.Label lblLowerCase;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.TextBox explainationText;
        private System.Windows.Forms.PictureBox imgTitle;
    }
}
