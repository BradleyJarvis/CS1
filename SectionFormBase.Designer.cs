namespace Group_project
{
    partial class SectionFormBase
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
            this.textBoxSectionText = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSectionText
            // 
            this.textBoxSectionText.Location = new System.Drawing.Point(12, 27);
            this.textBoxSectionText.Multiline = true;
            this.textBoxSectionText.Name = "textBoxSectionText";
            this.textBoxSectionText.ReadOnly = true;
            this.textBoxSectionText.Size = new System.Drawing.Size(560, 218);
            this.textBoxSectionText.TabIndex = 0;
            this.textBoxSectionText.Text = "Text about this section goes here";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(334, 358);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(238, 91);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.backToMain);
            // 
            // SectionFormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxSectionText);
            this.Name = "SectionFormBase";
            this.Controls.SetChildIndex(this.textBoxSectionText, 0);
            this.Controls.SetChildIndex(this.buttonBack, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        protected System.Windows.Forms.TextBox textBoxSectionText;
    }
}
