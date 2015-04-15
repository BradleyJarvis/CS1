using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Group_project
{
    public partial class QuizForm : Group_project.InteractionBase
    {
        Random rnd = new Random();// Create an RNG for shuffling the order answers appear
        int currentQuestion;
        int cryptScore, digitalScore, netScore;
        List <question> allQuestions = new List <question>();

        public QuizForm()
        {
            InitializeComponent();
            // All variables are reset, prevents issues if quiz re-opened 
            currentQuestion = 0;
            cryptScore = 0;
            digitalScore = 0;
            netScore = 0;

            #region questions
            // All questions go here
            // Questions should be added directly to the question list
            // Variables to pass to new question are: question text, correct answer, incorrect answer 1, incorrect answer 2, incorrect answer 3, category
            allQuestions.Add(new question("If the word \"Test\" is encrypted with a Caeser shift of 7, what is the result?", "Alza", "Docd", "Zlac", "Tset", "crypt"));
            allQuestions.Add(new question("What does a firewall do?", "Blocks unauthorised network traffic", "Protects against viruses", "Encrypt network traffic so it can't be read by eavesdroppers", "Makes a computer run hotter", "net"));
            allQuestions.Add(new question("Which of the following is NOT a benefit of using HTTPS?", "Faster data transfer", "Prevents eavesdropping", "Identity confirmation", "All of these are benefits of HTTPS", "digital"));
            allQuestions.Add(new question("If each the word \"LongTest\" was encrypted using a ceaser shift on each character with the key 8,15,19,1,1,7,20,14 what would be the encrypted result?", "TdghUlmh", "AdcvIthi", "PigmLtzt", "MqqkYkzb", "crypt"));
            allQuestions.Add(new question("What does brute force hacking mean?", "Trying every possible password until the corrrect one is found", "Threatening the account holder to give up their password", "Using a keylogger to find the password", "None of these", "digital"));
            allQuestions.Add(new question("You are given the word \"Zydkdy\" and are told that it has been Ceaser shifted by 10. What is the original word?", "Potato", "Buzzes", "Jackal", "Backup", "crypt"));
            allQuestions.Add(new question("What can a listener find if you are using an unsecured Wifi network?", "All unencrypted information", "Emails", "Financial data", "Websites visited", "net"));
            allQuestions.Add(new question("If you were knew someone was using a Ceaser shift to encrypt the word \"Cheese\" and the result is \"Gliiwi\", what value was it shifted by?", "4", "3", "8", "10", "crypt"));
            allQuestions.Add(new question("What does two factor authentication require as well as normal login and password?", "A one use code sent to the user when they log in", "A second password", "Permission to be granted by another person", "Nothing, it is another name for username and password", "digital"));
            allQuestions.Add(new question("What does encryption do?","Makes data unreadble without decryption keys","Makes it so data can't be accessed without permission","Prevents data from being sent","Transmits data annonymously","net"));
            allQuestions.Add(new question("Which of the following passwords would (in theory) take longest to crack?", "14 characters, upper and lowercase letters, numbers, special characters", "16 lowercase letters", "20 characters, all numbers", "18 characters, uppercase letters and numbers", "digital"));
            #endregion
            showNewQuestion(allQuestions[0]);
        }

        void showNewQuestion(question Q)
        {
            questionDisplayText.Text = Q.questionText;

            int[] buttonsPlaced = new int[] {5,5,5,5};// Array used to track what buttons have answers placed already, starts containing 5s to prevent hang when 0 chosen
            int number = 0;// Used to store the random number while it is check that it isn't already placed
            Button[] buttons = new Button[] {answerButton1, answerButton2, answerButton3, answerButton4};
            string[] answers = new string[] {Q.answer1, Q.answer2, Q.answer3, Q.answer4};// Aray used to hold strings with the possible answers
            for (int count = 0; count < 4; count++)
            {// Place answer[count] on random button
                number = rnd.Next(0, 4);
                if (buttonsPlaced.Contains(number) == true)
                    count--;
                else
                {
                    buttonsPlaced[count] = number;
                    buttons[number].Text = answers[count];
                }
            }
        }
        bool checkAnswer(Button buttonPressed)
        {// Checks the answer given, if it correct it will return true, else it will return false
            if (buttonPressed.Text == allQuestions[currentQuestion].answer1)
                return true;
            else
                return false;
        }
        void updateResults(Button buttonPressed)
        {// Used to update quiz progress systems and move to next question

            if (nextQuestionTimer.Enabled == true)
                return;// Do nothing if answer already given

            // Update the correct label as needed
            if (checkAnswer(buttonPressed) == true)
            {
                correctLabel.Text = "True";
                addScore(allQuestions[currentQuestion].category);
            }
            else 
            {
                correctLabel.Text = "False";
            }
            
            correctLabel.Show();

            nextQuestionTimer.Enabled = true;
        }
        #region answerButtonClick
        private void answerButton1_Click(object sender, EventArgs e)
        {
            updateResults(answerButton1);
        }


        private void answerButton2_Click(object sender, EventArgs e)
        {
            updateResults(answerButton2);
        }

        private void answerButton3_Click(object sender, EventArgs e)
        {
            updateResults(answerButton3);
        }

        private void answerButton4_Click(object sender, EventArgs e)
        {
            updateResults(answerButton4);
        }
        #endregion

        private void nextQuestionTimer_Tick(object sender, EventArgs e)
        {
            nextQuestionTimer.Enabled = false;
            correctLabel.Hide();
            currentQuestion++;

            if (currentQuestion >= allQuestions.Count)
            {
                MessageBox.Show("This is the end of the quiz. Your scores are as follows:\nCryptography: " + cryptScore + "\nDigital security: " + digitalScore + "\nNetwork security: " + netScore + "\nYour total score is " + (cryptScore + digitalScore + netScore) + " / " + allQuestions.Count);
                buttonPanel.Enabled = false;
                closeForm();
                return;
            }

            showNewQuestion(allQuestions[currentQuestion]);
        }
        private void addScore(string cat)
        {// Adds a point to the score of the category that was answered
            switch (cat)
            {
                case"crypt":
                    cryptScore++;
                    break;
                case"digital":
                    digitalScore++;
                    break;
                case"net":
                    netScore++;
                    break;
                default:
                    break;
            }
        }

        void closeForm()
        {
            this.Close();
        }
    }
    public class question
    {
        public string questionText, answer1, answer2, answer3, answer4, category;
        // One string used to hold the text asking the question, 4 more used for each of the possible answers. answer1 should be used to hold the correct answer, all other should be incorrect.
        // The category is used to determine what section the question relates to, valid entries are "crypt", "digital" and "net", relating to the 3 main sections

        public question (string Q, string a1, string a2, string a3, string a4, string cat)
        {// Constructor used to assign strings to correct variables
            questionText = Q;
            answer1 = a1;
            answer2 = a2;
            answer3 = a3;
            answer4 = a4;
            category = cat;
        }
    }
}
