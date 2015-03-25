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
            this.label1 = new System.Windows.Forms.Label();
            this.GenPassButton = new System.Windows.Forms.Button();
            this.specalCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.passLengthBox)).BeginInit();
            this.SuspendLayout();
            // 
            // passOutputBox
            // 
            this.passOutputBox.Location = new System.Drawing.Point(167, 61);
            this.passOutputBox.Name = "passOutputBox";
            this.passOutputBox.ReadOnly = true;
            this.passOutputBox.Size = new System.Drawing.Size(120, 20);
            this.passOutputBox.TabIndex = 8;
            // 
            // passLengthBox
            // 
            this.passLengthBox.Location = new System.Drawing.Point(14, 33);
            this.passLengthBox.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.passLengthBox.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.passLengthBox.Name = "passLengthBox";
            this.passLengthBox.Size = new System.Drawing.Size(44, 20);
            this.passLengthBox.TabIndex = 9;
            this.passLengthBox.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Password length";
            // 
            // GenPassButton
            // 
            this.GenPassButton.Location = new System.Drawing.Point(14, 59);
            this.GenPassButton.Name = "GenPassButton";
            this.GenPassButton.Size = new System.Drawing.Size(120, 23);
            this.GenPassButton.TabIndex = 11;
            this.GenPassButton.Text = "Generate password";
            this.GenPassButton.UseVisualStyleBackColor = true;
            this.GenPassButton.Click += new System.EventHandler(this.genPassword);
            // 
            // specalCheckBox
            // 
            this.specalCheckBox.AutoSize = true;
            this.specalCheckBox.Location = new System.Drawing.Point(167, 34);
            this.specalCheckBox.Name = "specalCheckBox";
            this.specalCheckBox.Size = new System.Drawing.Size(150, 17);
            this.specalCheckBox.TabIndex = 12;
            this.specalCheckBox.Text = "Include special characters";
            this.specalCheckBox.UseVisualStyleBackColor = true;
            // 
            // PasswordManagersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(453, 314);
            this.Controls.Add(this.specalCheckBox);
            this.Controls.Add(this.GenPassButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passLengthBox);
            this.Controls.Add(this.passOutputBox);
            this.Name = "PasswordManagersForm";
            this.Controls.SetChildIndex(this.passOutputBox, 0);
            this.Controls.SetChildIndex(this.passLengthBox, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.GenPassButton, 0);
            this.Controls.SetChildIndex(this.specalCheckBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.passLengthBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passOutputBox;
        private System.Windows.Forms.NumericUpDown passLengthBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GenPassButton;
        private System.Windows.Forms.CheckBox specalCheckBox;
    }
}
