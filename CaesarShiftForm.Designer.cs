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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaesarShiftForm));
            this.UnshiftedTextBox = new System.Windows.Forms.TextBox();
            this.ShiftedTextBox = new System.Windows.Forms.TextBox();
            this.ShiftAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ShiftButton = new System.Windows.Forms.Button();
            this.Unshift = new System.Windows.Forms.Button();
            this.CaesarShiftExplanationTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ShiftAmountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // UnshiftedTextBox
            // 
            this.UnshiftedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnshiftedTextBox.Location = new System.Drawing.Point(503, 56);
            this.UnshiftedTextBox.MaxLength = 200;
            this.UnshiftedTextBox.Multiline = true;
            this.UnshiftedTextBox.Name = "UnshiftedTextBox";
            this.UnshiftedTextBox.Size = new System.Drawing.Size(392, 203);
            this.UnshiftedTextBox.TabIndex = 1;
            // 
            // ShiftedTextBox
            // 
            this.ShiftedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShiftedTextBox.Location = new System.Drawing.Point(12, 56);
            this.ShiftedTextBox.MaxLength = 150;
            this.ShiftedTextBox.Multiline = true;
            this.ShiftedTextBox.Name = "ShiftedTextBox";
            this.ShiftedTextBox.Size = new System.Drawing.Size(392, 203);
            this.ShiftedTextBox.TabIndex = 4;
            // 
            // ShiftAmountNumericUpDown
            // 
            this.ShiftAmountNumericUpDown.Location = new System.Drawing.Point(410, 181);
            this.ShiftAmountNumericUpDown.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.ShiftAmountNumericUpDown.Name = "ShiftAmountNumericUpDown";
            this.ShiftAmountNumericUpDown.Size = new System.Drawing.Size(90, 20);
            this.ShiftAmountNumericUpDown.TabIndex = 2;
            // 
            // ShiftButton
            // 
            this.ShiftButton.Location = new System.Drawing.Point(410, 207);
            this.ShiftButton.Name = "ShiftButton";
            this.ShiftButton.Size = new System.Drawing.Size(90, 23);
            this.ShiftButton.TabIndex = 3;
            this.ShiftButton.Text = "Shift";
            this.ShiftButton.UseVisualStyleBackColor = true;
            this.ShiftButton.Click += new System.EventHandler(this.ShiftButton_Click);
            // 
            // Unshift
            // 
            this.Unshift.Location = new System.Drawing.Point(410, 236);
            this.Unshift.Name = "Unshift";
            this.Unshift.Size = new System.Drawing.Size(90, 23);
            this.Unshift.TabIndex = 5;
            this.Unshift.Text = "Unshift";
            this.Unshift.UseVisualStyleBackColor = true;
            this.Unshift.Click += new System.EventHandler(this.Unshift_Click);
            // 
            // CaesarShiftExplanationTextBox
            // 
            this.CaesarShiftExplanationTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CaesarShiftExplanationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaesarShiftExplanationTextBox.Location = new System.Drawing.Point(12, 268);
            this.CaesarShiftExplanationTextBox.Multiline = true;
            this.CaesarShiftExplanationTextBox.Name = "CaesarShiftExplanationTextBox";
            this.CaesarShiftExplanationTextBox.ReadOnly = true;
            this.CaesarShiftExplanationTextBox.Size = new System.Drawing.Size(883, 271);
            this.CaesarShiftExplanationTextBox.TabIndex = 14;
            this.CaesarShiftExplanationTextBox.TabStop = false;
            this.CaesarShiftExplanationTextBox.Text = resources.GetString("CaesarShiftExplanationTextBox.Text");
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(12, 24);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(139, 25);
            this.TitleLabel.TabIndex = 15;
            this.TitleLabel.Text = "Caesar Shift";
            // 
            // CaesarShiftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(909, 544);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.CaesarShiftExplanationTextBox);
            this.Controls.Add(this.Unshift);
            this.Controls.Add(this.ShiftButton);
            this.Controls.Add(this.ShiftAmountNumericUpDown);
            this.Controls.Add(this.ShiftedTextBox);
            this.Controls.Add(this.UnshiftedTextBox);
            this.Name = "CaesarShiftForm";
            this.Controls.SetChildIndex(this.UnshiftedTextBox, 0);
            this.Controls.SetChildIndex(this.ShiftedTextBox, 0);
            this.Controls.SetChildIndex(this.ShiftAmountNumericUpDown, 0);
            this.Controls.SetChildIndex(this.ShiftButton, 0);
            this.Controls.SetChildIndex(this.Unshift, 0);
            this.Controls.SetChildIndex(this.CaesarShiftExplanationTextBox, 0);
            this.Controls.SetChildIndex(this.TitleLabel, 0);
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
        private System.Windows.Forms.TextBox CaesarShiftExplanationTextBox;
        private System.Windows.Forms.Label TitleLabel;
    }
}
