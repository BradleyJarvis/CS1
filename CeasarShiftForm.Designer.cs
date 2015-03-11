namespace Group_project
{
    partial class CeasarShiftForm
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
            this.ExplanationOfCeasarShiftLabel = new System.Windows.Forms.Label();
            this.Unshift = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ShiftAmountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // UnshiftedTextBox
            // 
            this.UnshiftedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnshiftedTextBox.Location = new System.Drawing.Point(12, 27);
            this.UnshiftedTextBox.MaxLength = 255;
            this.UnshiftedTextBox.Multiline = true;
            this.UnshiftedTextBox.Name = "UnshiftedTextBox";
            this.UnshiftedTextBox.Size = new System.Drawing.Size(331, 277);
            this.UnshiftedTextBox.TabIndex = 8;
            // 
            // ShiftedTextBox
            // 
            this.ShiftedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShiftedTextBox.Location = new System.Drawing.Point(475, 28);
            this.ShiftedTextBox.MaxLength = 255;
            this.ShiftedTextBox.Multiline = true;
            this.ShiftedTextBox.Name = "ShiftedTextBox";
            this.ShiftedTextBox.Size = new System.Drawing.Size(331, 276);
            this.ShiftedTextBox.TabIndex = 9;
            // 
            // ShiftAmountNumericUpDown
            // 
            this.ShiftAmountNumericUpDown.Location = new System.Drawing.Point(349, 28);
            this.ShiftAmountNumericUpDown.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.ShiftAmountNumericUpDown.Name = "ShiftAmountNumericUpDown";
            this.ShiftAmountNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.ShiftAmountNumericUpDown.TabIndex = 10;
            // 
            // ShiftButton
            // 
            this.ShiftButton.Location = new System.Drawing.Point(349, 54);
            this.ShiftButton.Name = "ShiftButton";
            this.ShiftButton.Size = new System.Drawing.Size(120, 23);
            this.ShiftButton.TabIndex = 11;
            this.ShiftButton.Text = "Shift";
            this.ShiftButton.UseVisualStyleBackColor = true;
            this.ShiftButton.Click += new System.EventHandler(this.ShiftButton_Click);
            // 
            // ExplanationOfCeasarShiftLabel
            // 
            this.ExplanationOfCeasarShiftLabel.AutoSize = true;
            this.ExplanationOfCeasarShiftLabel.Location = new System.Drawing.Point(12, 307);
            this.ExplanationOfCeasarShiftLabel.Name = "ExplanationOfCeasarShiftLabel";
            this.ExplanationOfCeasarShiftLabel.Size = new System.Drawing.Size(136, 13);
            this.ExplanationOfCeasarShiftLabel.TabIndex = 12;
            this.ExplanationOfCeasarShiftLabel.Text = "Explanation Of Ceasar Shift";
            // 
            // Unshift
            // 
            this.Unshift.Location = new System.Drawing.Point(349, 83);
            this.Unshift.Name = "Unshift";
            this.Unshift.Size = new System.Drawing.Size(120, 23);
            this.Unshift.TabIndex = 13;
            this.Unshift.Text = "Unshift";
            this.Unshift.UseVisualStyleBackColor = true;
            this.Unshift.Click += new System.EventHandler(this.Unshift_Click);
            // 
            // CeasarShiftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(832, 535);
            this.Controls.Add(this.Unshift);
            this.Controls.Add(this.ExplanationOfCeasarShiftLabel);
            this.Controls.Add(this.ShiftButton);
            this.Controls.Add(this.ShiftAmountNumericUpDown);
            this.Controls.Add(this.ShiftedTextBox);
            this.Controls.Add(this.UnshiftedTextBox);
            this.Name = "CeasarShiftForm";
            this.Controls.SetChildIndex(this.UnshiftedTextBox, 0);
            this.Controls.SetChildIndex(this.ShiftedTextBox, 0);
            this.Controls.SetChildIndex(this.ShiftAmountNumericUpDown, 0);
            this.Controls.SetChildIndex(this.ShiftButton, 0);
            this.Controls.SetChildIndex(this.ExplanationOfCeasarShiftLabel, 0);
            this.Controls.SetChildIndex(this.Unshift, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ShiftAmountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UnshiftedTextBox;
        private System.Windows.Forms.TextBox ShiftedTextBox;
        private System.Windows.Forms.NumericUpDown ShiftAmountNumericUpDown;
        private System.Windows.Forms.Button ShiftButton;
        private System.Windows.Forms.Label ExplanationOfCeasarShiftLabel;
        private System.Windows.Forms.Button Unshift;
    }
}
