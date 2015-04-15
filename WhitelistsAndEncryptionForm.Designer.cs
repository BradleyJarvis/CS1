namespace Group_project
{
    partial class WhitelistsAndEncryptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WhitelistsAndEncryptionForm));
            this.imgTitle = new System.Windows.Forms.PictureBox();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.explainationText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // imgTitle
            // 
            this.imgTitle.BackColor = System.Drawing.Color.Transparent;
            this.imgTitle.Image = global::Group_project.Properties.Resources.titleWhitelists;
            this.imgTitle.Location = new System.Drawing.Point(63, 48);
            this.imgTitle.Name = "imgTitle";
            this.imgTitle.Size = new System.Drawing.Size(646, 51);
            this.imgTitle.TabIndex = 64;
            this.imgTitle.TabStop = false;
            // 
            // PreviousButton
            // 
            this.PreviousButton.Image = global::Group_project.Properties.Resources.btnNetworkPrevious;
            this.PreviousButton.Location = new System.Drawing.Point(12, 239);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(55, 45);
            this.PreviousButton.TabIndex = 69;
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Image = global::Group_project.Properties.Resources.btnNetworkNext;
            this.NextButton.Location = new System.Drawing.Point(717, 239);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(55, 45);
            this.NextButton.TabIndex = 68;
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
            this.explainationText.Location = new System.Drawing.Point(77, 134);
            this.explainationText.Multiline = true;
            this.explainationText.Name = "explainationText";
            this.explainationText.ReadOnly = true;
            this.explainationText.Size = new System.Drawing.Size(632, 277);
            this.explainationText.TabIndex = 67;
            this.explainationText.TabStop = false;
            this.explainationText.Text = resources.GetString("explainationText.Text");
            this.explainationText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WhitelistsAndEncryptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackgroundImage = global::Group_project.Properties.Resources.NetworkSecurityFormBackground;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.explainationText);
            this.Controls.Add(this.imgTitle);
            this.Name = "WhitelistsAndEncryptionForm";
            this.Text = "Whitelists and Encryption";
            this.Controls.SetChildIndex(this.imgTitle, 0);
            this.Controls.SetChildIndex(this.explainationText, 0);
            this.Controls.SetChildIndex(this.NextButton, 0);
            this.Controls.SetChildIndex(this.PreviousButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgTitle;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.TextBox explainationText;

    }
}
