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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordManagersForm));
            this.passOutputBox = new System.Windows.Forms.TextBox();
            this.passLengthBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.GenPassButton = new System.Windows.Forms.Button();
            this.specalCheckBox = new System.Windows.Forms.CheckBox();
            this.explainationText = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.passLengthBox)).BeginInit();
            this.SuspendLayout();
            // 
            // passOutputBox
            // 
            this.passOutputBox.Location = new System.Drawing.Point(167, 97);
            this.passOutputBox.Name = "passOutputBox";
            this.passOutputBox.ReadOnly = true;
            this.passOutputBox.Size = new System.Drawing.Size(120, 20);
            this.passOutputBox.TabIndex = 4;
            // 
            // passLengthBox
            // 
            this.passLengthBox.Location = new System.Drawing.Point(14, 69);
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
            this.passLengthBox.TabIndex = 1;
            this.passLengthBox.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Password length";
            // 
            // GenPassButton
            // 
            this.GenPassButton.Location = new System.Drawing.Point(14, 95);
            this.GenPassButton.Name = "GenPassButton";
            this.GenPassButton.Size = new System.Drawing.Size(120, 23);
            this.GenPassButton.TabIndex = 3;
            this.GenPassButton.Text = "Generate password";
            this.GenPassButton.UseVisualStyleBackColor = true;
            this.GenPassButton.Click += new System.EventHandler(this.genPassword);
            // 
            // specalCheckBox
            // 
            this.specalCheckBox.AutoSize = true;
            this.specalCheckBox.Location = new System.Drawing.Point(167, 70);
            this.specalCheckBox.Name = "specalCheckBox";
            this.specalCheckBox.Size = new System.Drawing.Size(150, 17);
            this.specalCheckBox.TabIndex = 2;
            this.specalCheckBox.Text = "Include special characters";
            this.specalCheckBox.UseVisualStyleBackColor = true;
            // 
            // explainationText
            // 
            this.explainationText.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.explainationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explainationText.Location = new System.Drawing.Point(14, 124);
            this.explainationText.Multiline = true;
            this.explainationText.Name = "explainationText";
            this.explainationText.ReadOnly = true;
            this.explainationText.Size = new System.Drawing.Size(521, 311);
            this.explainationText.TabIndex = 5;
            this.explainationText.TabStop = false;
            this.explainationText.Text = resources.GetString("explainationText.Text");
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TitleLabel.Location = new System.Drawing.Point(9, 24);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(224, 25);
            this.TitleLabel.TabIndex = 44;
            this.TitleLabel.Text = "Password Managers";
            // 
            // PasswordManagersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(547, 447);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.explainationText);
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
            this.Controls.SetChildIndex(this.explainationText, 0);
            this.Controls.SetChildIndex(this.TitleLabel, 0);
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
        private System.Windows.Forms.TextBox explainationText;
        private System.Windows.Forms.Label TitleLabel;
    }
}
