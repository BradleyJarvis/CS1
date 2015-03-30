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

            MessageReplyLabel.ForeColor = Color.Red;
            RecieverReplyLabel.ForeColor = Color.Red;
            HackerReplyLabel.ForeColor = Color.Red;
            SenderReplyLabel.ForeColor = Color.Red;

            RecieverReplyLabel.Text = Convert.ToString((Math.Pow(3, Convert.ToInt64(RecieverSecretKeyNumberLabel.Text))) % 17);
            MessageReplyLabel.Text = RecieverReplyLabel.Text;
            HackerReplyLabel.Text = RecieverReplyLabel.Text;
            SenderReplyLabel.Text = RecieverReplyLabel.Text;

            Replybutton.Visible = false;
            Back3button.Visible = false;
            ReplytextBox.Visible = false;

            
            MessageReplyLabel.Visible = true;
            SenderReplyLabel.Visible = true;
            RecieverReplyLabel.Visible = true;
            HackerReplyLabel.Visible = true;

            Back4button.Visible = true;
            FindCommonNumberButton.Visible = true;
            FindCommontextBox.Visible = true;

        }

        private void FindCommonNumberButton_Click(object sender, EventArgs e)
        {

            MessageReplyLabel.ForeColor = Color.Black;
            RecieverReplyLabel.ForeColor = Color.Black;
            HackerReplyLabel.ForeColor = Color.Black;
            SenderReplyLabel.ForeColor = Color.Black;
         
            SharedSecretNumberLabel.ForeColor = Color.Red;

            SharedSecretNumberLabel.Text = Convert.ToString((Math.Pow(Convert.ToInt64(SenderReplyLabel.Text), Convert.ToInt64(SenderSecretKeyNumberLabel.Text))) % 17);

            Back4button.Visible = false;
            FindCommonNumberButton.Visible = false;
            FindCommontextBox.Visible = false;

            Back5button.Visible = true;
            FinnishedTextBox.Visible = true;
            RestartButton.Visible = true;
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            SenderSecretKeyNumberLabel.ForeColor = Color.Black;
            RecieverSecretKeyNumberLabel.ForeColor = Color.Black;

            SenderSecretKeyNumberLabel.Text = "_";
            RecieverSecretKeyNumberLabel.Text = "_";

            GeneraterandomtextBox.Visible = true;
            GenerateSecretNumbersButton.Visible = true;

            FindModtextbox.Visible = false;
            FindAnswerbutton.Visible = false;
            Backbutton.Visible = false;
        }

        private void Back2button_Click(object sender, EventArgs e)
        {
            SenderSecretKeyNumberLabel.ForeColor = Color.Red;
            RecieverSecretKeyNumberLabel.ForeColor = Color.Red;

            SenderTextLabel.Text = "Sender Text";
            SenderTextLabel.ForeColor = Color.Black;

            FindModtextbox.Visible = true;
            FindAnswerbutton.Visible = true;
            Backbutton.Visible = true;

            Send1textBox.Visible = false;
            Send1button.Visible = false;
            Back2button.Visible = false;
        }

        private void Back3button_Click(object sender, EventArgs e)
        {
            SenderTextLabel.ForeColor = Color.Red;

            MessageSentLabel.ForeColor = Color.Black;
            RecieverTextLabel.ForeColor = Color.Black;
            HackerTextLabel.ForeColor = Color.Black;

            MessageSentLabel.Text = "Message Sent";
            RecieverTextLabel.Text = "Reciever Text";
            HackerTextLabel.Text = "Hacker Text";

            Send1textBox.Visible = true;
            Send1button.Visible = true;
            Back2button.Visible = true;

            Replybutton.Visible = false;
            Back3button.Visible = false;
            ReplytextBox.Visible = false;
        }

        private void Back4button_Click(object sender, EventArgs e)
        {
            MessageSentLabel.ForeColor = Color.Red;
            RecieverTextLabel.ForeColor = Color.Red;
            HackerTextLabel.ForeColor = Color.Red;

            MessageReplyLabel.ForeColor = Color.Black;
            RecieverReplyLabel.ForeColor = Color.Black;
            HackerReplyLabel.ForeColor = Color.Black;
            SenderReplyLabel.ForeColor = Color.Black;

            MessageReplyLabel.Text = "Message Reply";
            RecieverReplyLabel.Text = "Reciever Reply";
            HackerReplyLabel.Text = "Hacker Reply";
            SenderReplyLabel.Text = "Sender Reply";

            Replybutton.Visible = true;
            Back3button.Visible = true;
            ReplytextBox.Visible = true;

            MessageReplyLabel.Visible = false;
            SenderReplyLabel.Visible = false;
            RecieverReplyLabel.Visible = false;
            HackerReplyLabel.Visible = false;

            Back4button.Visible = false;
            FindCommonNumberButton.Visible = false;
            FindCommontextBox.Visible = false;

        }

        private void Back5button_Click(object sender, EventArgs e)
        {
            MessageReplyLabel.ForeColor = Color.Red;
            RecieverReplyLabel.ForeColor = Color.Red;
            HackerReplyLabel.ForeColor = Color.Red;
            SenderReplyLabel.ForeColor = Color.Red;

            SharedSecretNumberLabel.ForeColor = Color.Black;

            SharedSecretNumberLabel.Text = "_";

            Back4button.Visible = true;
            FindCommonNumberButton.Visible = true;
            FindCommontextBox.Visible = true;

            Back5button.Visible = false;
            FinnishedTextBox.Visible = false;
            RestartButton.Visible = false;
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {


            SenderSecretKeyNumberLabel.Text = "_";
            RecieverSecretKeyNumberLabel.Text = "_";

            SenderTextLabel.Text = "Sender Text";
            MessageSentLabel.Text = "Message Sent";
            RecieverTextLabel.Text = "Reciever Text";
            HackerTextLabel.Text = "Hacker Text";

            RecieverReplyLabel.Text = "_";
            MessageReplyLabel.Text = "_";
            HackerReplyLabel.Text = "_";
            SenderReplyLabel.Text = "_";


            SharedSecretNumberLabel.ForeColor = Color.Black;

            SharedSecretNumberLabel.Text = "_";


            GeneraterandomtextBox.Visible = true;
            GenerateSecretNumbersButton.Visible = true;

            Back5button.Visible = false;
            FinnishedTextBox.Visible = false;
            RestartButton.Visible = false;

            MessageReplyLabel.Visible = false;
            SenderReplyLabel.Visible = false;
            RecieverReplyLabel.Visible = false;
            HackerReplyLabel.Visible = false;
        }


    }
}
