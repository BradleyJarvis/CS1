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

            // All questions go here
            question Q1 = new question ("What is the answer to this question", "This is correct", "Answer 2", "Answer 3", "Answer 4", "crypt");
            allQuestions.Add(Q1);
            question Q2 = new question ("This is the second question, used to check the functionality", "This is the correct answer", "This is wrong", "This is wrong too", "And this is wrong as well", "digital");
            allQuestions.Add(Q2);
            question Q3 = new question("This is the third and final test question", "This answer is correct", "This answer is not correct", "This is a wrong answer", "And this is wrong too", "net");
            allQuestions.Add(Q3);
            // End of questions
            showNewQuestion(allQuestions[0]);
        }

        void showNewQuestion(question Q)
        {
            questionDisplayText.Text = Q.questionText;

            int[] answersPlaced = new int[] {5,5,5,5};// Array used to track what answers have been placed on buttons already, starts containing 5s to prevent hang when 0 chosen
            int number = 0;// Used to store the random number while it is check that it isn't already placed
            Button[] buttons = new Button[] {answerButton1, answerButton2, answerButton3, answerButton4};
            string[] answers = new string[] {Q.answer1, Q.answer2, Q.answer3, Q.answer4};// Aray used to hold strings with the possible answers
            for (int count = 0; count < 4; count++)
            {// Place a random answer on button[count]
                number = rnd.Next(0, 4);
                if (answersPlaced.Contains(number) == true)
                    count--;
                else
                {
                    answersPlaced[count] = number;
                    buttons[count].Text = answers[number];
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
                MessageBox.Show("This is the end of the quiz. Your scores are as follows:\nCryptography: " + cryptScore + "\nDigital security: " + digitalScore + "\nNetwork security: " + netScore + "\nYour total score is " + (cryptScore + digitalScore + netScore));
                buttonPanel.Enabled = false;
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
