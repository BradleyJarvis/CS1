﻿namespace Group_project
{
    partial class Section1
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
            this.buttonInteraction1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSectionText
            // 
            this.textBoxSectionText.Text = "Here is some text about section 1";
            // 
            // buttonInteraction1
            // 
            this.buttonInteraction1.Location = new System.Drawing.Point(12, 251);
            this.buttonInteraction1.Name = "buttonInteraction1";
            this.buttonInteraction1.Size = new System.Drawing.Size(238, 91);
            this.buttonInteraction1.TabIndex = 6;
            this.buttonInteraction1.Text = "Interaction1";
            this.buttonInteraction1.UseVisualStyleBackColor = true;
            this.buttonInteraction1.Click += new System.EventHandler(this.openInteraction1);
            // 
            // Section1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.buttonInteraction1);
            this.Name = "Section1";
            this.Controls.SetChildIndex(this.textBoxSectionText, 0);
            this.Controls.SetChildIndex(this.buttonInteraction1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInteraction1;
    }
}
