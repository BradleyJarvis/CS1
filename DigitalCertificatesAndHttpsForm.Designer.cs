namespace Group_project
{
    partial class DigitalCertificatesAndHttpsForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.explainationText = new System.Windows.Forms.TextBox();
            this.imgTitle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Group_project.Properties.Resources.httpsImgOne;
            this.pictureBox1.Location = new System.Drawing.Point(565, 343);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 211);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Group_project.Properties.Resources.httpsImgThree;
            this.pictureBox2.Location = new System.Drawing.Point(0, 352);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(263, 202);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Group_project.Properties.Resources.httpsImgTwo;
            this.pictureBox3.Location = new System.Drawing.Point(284, 363);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(263, 181);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // PreviousButton
            // 
            this.PreviousButton.Image = global::Group_project.Properties.Resources.btnDigitalPrevious;
            this.PreviousButton.Location = new System.Drawing.Point(25, 208);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(55, 45);
            this.PreviousButton.TabIndex = 57;
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Image = global::Group_project.Properties.Resources.btnDigitalNext;
            this.NextButton.Location = new System.Drawing.Point(750, 208);
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
            this.explainationText.Location = new System.Drawing.Point(86, 143);
            this.explainationText.Multiline = true;
            this.explainationText.Name = "explainationText";
            this.explainationText.ReadOnly = true;
            this.explainationText.Size = new System.Drawing.Size(658, 177);
            this.explainationText.TabIndex = 55;
            this.explainationText.TabStop = false;
            this.explainationText.Text = "HTTPS is a protocol that can be used to securely transfer data over a network. It" +
    " works by using the SSL encryption technique combined with the HTTP data transfe" +
    "r protocol to encrypt all data sent. \r\n";
            this.explainationText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // imgTitle
            // 
            this.imgTitle.BackColor = System.Drawing.Color.Transparent;
            this.imgTitle.Image = global::Group_project.Properties.Resources.titleCertificates;
            this.imgTitle.Location = new System.Drawing.Point(177, 58);
            this.imgTitle.Name = "imgTitle";
            this.imgTitle.Size = new System.Drawing.Size(487, 37);
            this.imgTitle.TabIndex = 58;
            this.imgTitle.TabStop = false;
            // 
            // DigitalCertificatesAndHttpsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackgroundImage = global::Group_project.Properties.Resources.DigitalSecurityFormBackground_jpg;
            this.ClientSize = new System.Drawing.Size(840, 561);
            this.Controls.Add(this.imgTitle);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.explainationText);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DigitalCertificatesAndHttpsForm";
            this.Text = "HTTPS and Digital Certificates";
            this.Load += new System.EventHandler(this.DigitalCertificatesAndHttpsForm_Load);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.pictureBox3, 0);
            this.Controls.SetChildIndex(this.explainationText, 0);
            this.Controls.SetChildIndex(this.NextButton, 0);
            this.Controls.SetChildIndex(this.PreviousButton, 0);
            this.Controls.SetChildIndex(this.imgTitle, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.TextBox explainationText;
        private System.Windows.Forms.PictureBox imgTitle;
    }
}
