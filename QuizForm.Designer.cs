namespace Group_project
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
            this.answerButton4 = new System.Windows.Forms.Button();
            this.correctLabel = new System.Windows.Forms.Label();
            this.nextQuestionTimer = new System.Windows.Forms.Timer(this.components);
            this.answerButton3 = new System.Windows.Forms.Button();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // questionDisplayText
            // 
            this.questionDisplayText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(202)))), ((int)(((byte)(243)))));
            this.questionDisplayText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.questionDisplayText.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionDisplayText.Location = new System.Drawing.Point(15, 165);
            this.questionDisplayText.Multiline = true;
            this.questionDisplayText.Name = "questionDisplayText";
            this.questionDisplayText.ReadOnly = true;
            this.questionDisplayText.Size = new System.Drawing.Size(748, 153);
            this.questionDisplayText.TabIndex = 5;
            this.questionDisplayText.TabStop = false;
            this.questionDisplayText.Text = "Questions are shown here";
            this.questionDisplayText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // answerButton1
            // 
            this.answerButton1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerButton1.ForeColor = System.Drawing.Color.DarkGreen;
            this.answerButton1.Location = new System.Drawing.Point(8, 8);
            this.answerButton1.Name = "answerButton1";
            this.answerButton1.Size = new System.Drawing.Size(347, 69);
            this.answerButton1.TabIndex = 1;
            this.answerButton1.Text = "button1";
            this.answerButton1.UseVisualStyleBackColor = true;
            this.answerButton1.Click += new System.EventHandler(this.answerButton1_Click);
            // 
            // answerButton2
            // 
            this.answerButton2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerButton2.ForeColor = System.Drawing.Color.DarkGreen;
            this.answerButton2.Location = new System.Drawing.Point(401, 8);
            this.answerButton2.Name = "answerButton2";
            this.answerButton2.Size = new System.Drawing.Size(347, 69);
            this.answerButton2.TabIndex = 2;
            this.answerButton2.Text = "button2";
            this.answerButton2.UseVisualStyleBackColor = true;
            this.answerButton2.Click += new System.EventHandler(this.answerButton2_Click);
            // 
            // answerButton4
            // 
            this.answerButton4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerButton4.ForeColor = System.Drawing.Color.DarkGreen;
            this.answerButton4.Location = new System.Drawing.Point(401, 83);
            this.answerButton4.Name = "answerButton4";
            this.answerButton4.Size = new System.Drawing.Size(347, 69);
            this.answerButton4.TabIndex = 4;
            this.answerButton4.Text = "button4";
            this.answerButton4.UseVisualStyleBackColor = true;
            this.answerButton4.Click += new System.EventHandler(this.answerButton4_Click);
            // 
            // correctLabel
            // 
            this.correctLabel.AutoSize = true;
            this.correctLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.correctLabel.Location = new System.Drawing.Point(345, 330);
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(90, 28);
            this.correctLabel.TabIndex = 13;
            this.correctLabel.Text = "label1";
            this.correctLabel.Visible = false;
            // 
            // nextQuestionTimer
            // 
            this.nextQuestionTimer.Interval = 1500;
            this.nextQuestionTimer.Tick += new System.EventHandler(this.nextQuestionTimer_Tick);
            // 
            // answerButton3
            // 
            this.answerButton3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerButton3.ForeColor = System.Drawing.Color.DarkGreen;
            this.answerButton3.Location = new System.Drawing.Point(8, 83);
            this.answerButton3.Name = "answerButton3";
            this.answerButton3.Size = new System.Drawing.Size(347, 69);
            this.answerButton3.TabIndex = 3;
            this.answerButton3.Text = "button3";
            this.answerButton3.UseVisualStyleBackColor = true;
            this.answerButton3.Click += new System.EventHandler(this.answerButton3_Click);
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.answerButton4);
            this.buttonPanel.Controls.Add(this.answerButton3);
            this.buttonPanel.Controls.Add(this.answerButton2);
            this.buttonPanel.Controls.Add(this.answerButton1);
            this.buttonPanel.Location = new System.Drawing.Point(7, 371);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(765, 178);
            this.buttonPanel.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Group_project.Properties.Resources.titleQuiz;
            this.pictureBox1.Location = new System.Drawing.Point(282, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 92);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.correctLabel);
            this.Controls.Add(this.questionDisplayText);
            this.Name = "QuizForm";
            this.Controls.SetChildIndex(this.questionDisplayText, 0);
            this.Controls.SetChildIndex(this.correctLabel, 0);
            this.Controls.SetChildIndex(this.buttonPanel, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.buttonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox questionDisplayText;
        private System.Windows.Forms.Button answerButton1;
        private System.Windows.Forms.Button answerButton2;
        private System.Windows.Forms.Button answerButton4;
        private System.Windows.Forms.Label correctLabel;
        private System.Windows.Forms.Timer nextQuestionTimer;
        private System.Windows.Forms.Button answerButton3;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
