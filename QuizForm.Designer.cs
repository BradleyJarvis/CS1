﻿namespace Group_project
{
    partial class QuizForm
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
            this.components = new System.ComponentModel.Container();
            this.questionDisplayText = new System.Windows.Forms.TextBox();
            this.answerButton1 = new System.Windows.Forms.Button();
            this.answerButton2 = new System.Windows.Forms.Button();
            this.answerButton3 = new System.Windows.Forms.Button();
            this.answerButton4 = new System.Windows.Forms.Button();
            this.correctLabel = new System.Windows.Forms.Label();
            this.nextQuestionTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // questionDisplayText
            // 
            this.questionDisplayText.Location = new System.Drawing.Point(13, 28);
            this.questionDisplayText.Multiline = true;
            this.questionDisplayText.Name = "questionDisplayText";
            this.questionDisplayText.ReadOnly = true;
            this.questionDisplayText.Size = new System.Drawing.Size(526, 97);
            this.questionDisplayText.TabIndex = 8;
            this.questionDisplayText.Text = "Questions are shown here";
            // 
            // answerButton1
            // 
            this.answerButton1.Location = new System.Drawing.Point(13, 132);
            this.answerButton1.Name = "answerButton1";
            this.answerButton1.Size = new System.Drawing.Size(127, 80);
            this.answerButton1.TabIndex = 9;
            this.answerButton1.Text = "button1";
            this.answerButton1.UseVisualStyleBackColor = true;
            this.answerButton1.Click += new System.EventHandler(this.answerButton1_Click);
            // 
            // answerButton2
            // 
            this.answerButton2.Location = new System.Drawing.Point(146, 132);
            this.answerButton2.Name = "answerButton2";
            this.answerButton2.Size = new System.Drawing.Size(127, 80);
            this.answerButton2.TabIndex = 10;
            this.answerButton2.Text = "button2";
            this.answerButton2.UseVisualStyleBackColor = true;
            this.answerButton2.Click += new System.EventHandler(this.answerButton2_Click);
            // 
            // answerButton3
            // 
            this.answerButton3.Location = new System.Drawing.Point(279, 132);
            this.answerButton3.Name = "answerButton3";
            this.answerButton3.Size = new System.Drawing.Size(127, 80);
            this.answerButton3.TabIndex = 11;
            this.answerButton3.Text = "button3";
            this.answerButton3.UseVisualStyleBackColor = true;
            this.answerButton3.Click += new System.EventHandler(this.answerButton3_Click);
            // 
            // answerButton4
            // 
            this.answerButton4.Location = new System.Drawing.Point(412, 131);
            this.answerButton4.Name = "answerButton4";
            this.answerButton4.Size = new System.Drawing.Size(127, 80);
            this.answerButton4.TabIndex = 12;
            this.answerButton4.Text = "button4";
            this.answerButton4.UseVisualStyleBackColor = true;
            this.answerButton4.Click += new System.EventHandler(this.answerButton4_Click);
            // 
            // correctLabel
            // 
            this.correctLabel.AutoSize = true;
            this.correctLabel.Location = new System.Drawing.Point(13, 232);
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(35, 13);
            this.correctLabel.TabIndex = 13;
            this.correctLabel.Text = "label1";
            this.correctLabel.Visible = false;
            // 
            // nextQuestionTimer
            // 
            this.nextQuestionTimer.Interval = 2000;
            this.nextQuestionTimer.Tick += new System.EventHandler(this.nextQuestionTimer_Tick);
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(552, 316);
            this.Controls.Add(this.correctLabel);
            this.Controls.Add(this.answerButton4);
            this.Controls.Add(this.answerButton3);
            this.Controls.Add(this.answerButton2);
            this.Controls.Add(this.answerButton1);
            this.Controls.Add(this.questionDisplayText);
            this.Name = "QuizForm";
            this.Controls.SetChildIndex(this.questionDisplayText, 0);
            this.Controls.SetChildIndex(this.answerButton1, 0);
            this.Controls.SetChildIndex(this.answerButton2, 0);
            this.Controls.SetChildIndex(this.answerButton3, 0);
            this.Controls.SetChildIndex(this.answerButton4, 0);
            this.Controls.SetChildIndex(this.correctLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox questionDisplayText;
        private System.Windows.Forms.Button answerButton1;
        private System.Windows.Forms.Button answerButton2;
        private System.Windows.Forms.Button answerButton3;
        private System.Windows.Forms.Button answerButton4;
        private System.Windows.Forms.Label correctLabel;
        private System.Windows.Forms.Timer nextQuestionTimer;
    }
}
