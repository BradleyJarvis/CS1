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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.explainationText = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Group_project.Properties.Resources.titleWhitelists;
            this.pictureBox2.Location = new System.Drawing.Point(64, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(650, 62);
            this.pictureBox2.TabIndex = 71;
            this.pictureBox2.TabStop = false;
            // 
            // PreviousButton
            // 
            this.PreviousButton.Image = global::Group_project.Properties.Resources.btnNetworkPrevious;
            this.PreviousButton.Location = new System.Drawing.Point(12, 201);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(55, 45);
            this.PreviousButton.TabIndex = 70;
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Image = global::Group_project.Properties.Resources.btnNetworkNext;
            this.NextButton.Location = new System.Drawing.Point(711, 214);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(55, 45);
            this.NextButton.TabIndex = 69;
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // explainationText
            // 
            this.explainationText.BackColor = System.Drawing.Color.LavenderBlush;
            this.explainationText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.explainationText.Cursor = System.Windows.Forms.Cursors.Default;
            this.explainationText.Font = new System.Drawing.Font("Segoe WP", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explainationText.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.explainationText.Location = new System.Drawing.Point(73, 104);
            this.explainationText.Multiline = true;
            this.explainationText.Name = "explainationText";
            this.explainationText.ReadOnly = true;
            this.explainationText.Size = new System.Drawing.Size(632, 223);
            this.explainationText.TabIndex = 68;
            this.explainationText.TabStop = false;
            this.explainationText.Text = resources.GetString("explainationText.Text");
            this.explainationText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Group_project.Properties.Resources.imgWhitelist;
            this.pictureBox1.Location = new System.Drawing.Point(221, 334);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // WhitelistsAndEncryptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackgroundImage = global::Group_project.Properties.Resources.NetworkSecurityFormBackground;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.explainationText);
            this.Name = "WhitelistsAndEncryptionForm";
            this.Controls.SetChildIndex(this.explainationText, 0);
            this.Controls.SetChildIndex(this.NextButton, 0);
            this.Controls.SetChildIndex(this.PreviousButton, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.TextBox explainationText;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}
