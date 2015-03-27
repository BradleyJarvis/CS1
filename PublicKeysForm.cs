using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Group_project
{
    public partial class PublicKeysForm : Group_project.InteractionBase
    {
        public PublicKeysForm()
        {
            InitializeComponent();
        }

        private void GenerateSecretNumbersButton_Click(object sender, EventArgs e)
        {
            Random RandomNumber = new Random();
            int SenderSecretKeyNumber = RandomNumber.Next(1, 100);
            int RecieverSecretKeyNumber = RandomNumber.Next(1, 100);


            SenderSecretKeyNumberLabel.ForeColor = Color.Red;
            RecieverSecretKeyNumberLabel.ForeColor = Color.Red;

            SenderSecretKeyNumberLabel.Text = Convert.ToString(SenderSecretKeyNumber); 
            RecieverSecretKeyNumberLabel.Text = Convert.ToString(RecieverSecretKeyNumber);
           
            GeneraterandomtextBox.Visible = false;
            GenerateSecretNumbersButton.Visible = false;

            FindModtextbox.Visible = true;
            FindAnswerbutton.Visible = true;
            Backbutton.Visible = true;
        }

        private void FindAnswerbutton_Click(object sender, EventArgs e)
        {
            SenderSecretKeyNumberLabel.ForeColor = Color.Black;
            RecieverSecretKeyNumberLabel.ForeColor = Color.Black;

            SenderTextLabel.Text = Convert.ToString((Math.Pow(3,Convert.ToInt64(SenderSecretKeyNumberLabel.Text))) % 17 );
            SenderTextLabel.ForeColor = Color.Red;

            FindModtextbox.Visible = false;
            FindAnswerbutton.Visible = false;
            Backbutton.Visible = false;

            Send1textBox.Visible = true;
            Send1button.Visible = true;
            Back2button.Visible = true;


        }

        private void Send1button_Click(object sender, EventArgs e)
        {
            SenderTextLabel.ForeColor = Color.Black;

            MessageSentLabel.ForeColor = Color.Red;
            RecieverTextLabel.ForeColor = Color.Red;
            HackerTextLabel.ForeColor = Color.Red;

            MessageSentLabel.Text = SenderTextLabel.Text;
            RecieverTextLabel.Text = SenderTextLabel.Text;
            HackerTextLabel.Text = SenderTextLabel.Text;

            Send1textBox.Visible = false;
            Send1button.Visible = false;
            Back2button.Visible = false;

            Replybutton.Visible = true;
            Back3button.Visible = true;
            ReplytextBox.Visible = true;
        }

        private void Replybutton_Click(object sender, EventArgs e)
        {
            MessageSentLabel.ForeColor = Color.Black;
            RecieverTextLabel.ForeColor = Color.Black;
            HackerTextLabel.ForeColor = Color.Black;

            MessageReplyLabel.Text = Convert.ToString((Math.Pow(3, Convert.ToInt64(RecieverSecretKeyNumberLabel.Text))) % 17);
            RecieverReplyLabel.Text = MessageSentLabel.Text;
            HackerReplyLabel.Text = MessageSentLabel.Text;
            SenderReplyLabel.Text = MessageSentLabel.Text;

            Replybutton.Visible = false;
            Back3button.Visible = false;
            ReplytextBox.Visible = false;

            
            MessageReplyLabel.Visible = true;
            SenderReplyLabel.Visible = true;
            RecieverReplyLabel.Visible = true;
            HackerReplyLabel.Visible = true;

            FindCommonNumberButton.Visible = true;
            FindCommontextBox.Visible = true;

        }

        private void FindCommonNumberButton_Click(object sender, EventArgs e)
        {

        }


    }
}
