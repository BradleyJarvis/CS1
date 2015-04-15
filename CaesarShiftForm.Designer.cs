namespace Group_project
{
    partial class CaesarShiftForm
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
            this.UnshiftedTextBox = new System.Windows.Forms.TextBox();
            this.ShiftedTextBox = new System.Windows.Forms.TextBox();
            this.ShiftAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ShiftButton = new System.Windows.Forms.Button();
            this.Unshift = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.explainationText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ShiftAmountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // UnshiftedTextBox
            // 
            this.UnshiftedTextBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnshiftedTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UnshiftedTextBox.Location = new System.Drawing.Point(12, 313);
            this.UnshiftedTextBox.MaxLength = 200;
            this.UnshiftedTextBox.Multiline = true;
            this.UnshiftedTextBox.Name = "UnshiftedTextBox";
            this.UnshiftedTextBox.Size = new System.Drawing.Size(290, 212);
            this.UnshiftedTextBox.TabIndex = 1;
            // 
            // ShiftedTextBox
            // 
            this.ShiftedTextBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShiftedTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ShiftedTextBox.Location = new System.Drawing.Point(482, 313);
            this.ShiftedTextBox.MaxLength = 150;
            this.ShiftedTextBox.Multiline = true;
            this.ShiftedTextBox.Name = "ShiftedTextBox";
            this.ShiftedTextBox.Size = new System.Drawing.Size(290, 212);
            this.ShiftedTextBox.TabIndex = 4;
            // 
            // ShiftAmountNumericUpDown
            // 
            this.ShiftAmountNumericUpDown.BackColor = System.Drawing.Color.OrangeRed;
            this.ShiftAmountNumericUpDown.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShiftAmountNumericUpDown.ForeColor = System.Drawing.Color.Teal;
            this.ShiftAmountNumericUpDown.Location = new System.Drawing.Point(349, 393);
            this.ShiftAmountNumericUpDown.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.ShiftAmountNumericUpDown.Name = "ShiftAmountNumericUpDown";
            this.ShiftAmountNumericUpDown.Size = new System.Drawing.Size(90, 51);
            this.ShiftAmountNumericUpDown.TabIndex = 2;
            // 
            // ShiftButton
            // 
            this.ShiftButton.Image = global::Group_project.Properties.Resources.btnShift;
            this.ShiftButton.Location = new System.Drawing.Point(316, 315);
            this.ShiftButton.Name = "ShiftButton";
            this.ShiftButton.Size = new System.Drawing.Size(154, 56);
            this.ShiftButton.TabIndex = 3;
            this.ShiftButton.UseVisualStyleBackColor = true;
            this.ShiftButton.Click += new System.EventHandler(this.ShiftButton_Click);
            // 
            // Unshift
            // 
            this.Unshift.Image = global::Group_project.Properties.Resources.btnUnshift;
            this.Unshift.Location = new System.Drawing.Point(316, 469);
            this.Unshift.Name = "Unshift";
            this.Unshift.Size = new System.Drawing.Size(154, 56);
            this.Unshift.TabIndex = 5;
            this.Unshift.UseVisualStyleBackColor = true;
            this.Unshift.Click += new System.EventHandler(this.Unshift_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Image = global::Group_project.Properties.Resources.btnCryptPrevious;
            this.PreviousButton.Location = new System.Drawing.Point(17, 184);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(55, 45);
            this.PreviousButton.TabIndex = 57;
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Image = global::Group_project.Properties.Resources.btnCryptNext;
            this.NextButton.Location = new System.Drawing.Point(710, 194);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(55, 45);
            this.NextButton.TabIndex = 56;
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
            this.explainationText.Location = new System.Drawing.Point(72, 150);
            this.explainationText.Multiline = true;
            this.explainationText.Name = "explainationText";
            this.explainationText.ReadOnly = true;
            this.explainationText.Size = new System.Drawing.Size(632, 123);
            this.explainationText.TabIndex = 55;
            this.explainationText.TabStop = false;
            this.explainationText.Text = "A Caesar shift cypher is a method of encryption that is very simple but is very r" +
    "esilient to brute force attacks.";
            this.explainationText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CaesarShiftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackgroundImage = global::Group_project.Properties.Resources.CryptographyFormBackground;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.explainationText);
            this.Controls.Add(this.Unshift);
            this.Controls.Add(this.ShiftButton);
            this.Controls.Add(this.ShiftAmountNumericUpDown);
            this.Controls.Add(this.ShiftedTextBox);
            this.Controls.Add(this.UnshiftedTextBox);
            this.Name = "CaesarShiftForm";
            this.Text = "Caesar Shift";
            this.Controls.SetChildIndex(this.UnshiftedTextBox, 0);
            this.Controls.SetChildIndex(this.ShiftedTextBox, 0);
            this.Controls.SetChildIndex(this.ShiftAmountNumericUpDown, 0);
            this.Controls.SetChildIndex(this.ShiftButton, 0);
            this.Controls.SetChildIndex(this.Unshift, 0);
            this.Controls.SetChildIndex(this.explainationText, 0);
            this.Controls.SetChildIndex(this.NextButton, 0);
            this.Controls.SetChildIndex(this.PreviousButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ShiftAmountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UnshiftedTextBox;
        private System.Windows.Forms.TextBox ShiftedTextBox;
        private System.Windows.Forms.NumericUpDown ShiftAmountNumericUpDown;
        private System.Windows.Forms.Button ShiftButton;
        private System.Windows.Forms.Button Unshift;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.TextBox explainationText;
    }
}
