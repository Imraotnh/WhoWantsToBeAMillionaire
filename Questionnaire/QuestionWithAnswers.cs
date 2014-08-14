using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WhoWantsToBeAMillionaire
{    
    public class QuestionWithAnswers
    {
        public string Question { get; set; }
        public List<string> Answers { get; set; }
        public short? CorrectAnswer { get; set; }

        public QuestionWithAnswers(string question, List<string> answers, short correctAnswer)
        {
            this.Question = question;
            this.Answers = answers;
            this.CorrectAnswer = correctAnswer;
        }

        public void ChangeQuestion(string newQuestion)
        {            
            this.Question = newQuestion;
        }

        public override string ToString()
        {
            StringBuilder QuestionWithAnswers = new StringBuilder();
            QuestionWithAnswers.Append(this.Question + "\n");

            int answersCount = this.Answers.Count;

            for (int i = 0; i < answersCount; i++)
            {
                QuestionWithAnswers.Append((char)(65 + i) + ") " + this.Answers[i] + "\n");
            }
            
            return QuestionWithAnswers.ToString();
        }

        public string ToStringWithCorrectAnswer()
        {
            StringBuilder QuestionWithAnswersAndCorrectAnswer = new StringBuilder();
            QuestionWithAnswersAndCorrectAnswer.Append(this.ToString());

            QuestionWithAnswersAndCorrectAnswer.Append("Correct answer: " + "(" + (char)(65 + this.CorrectAnswer) + ") \n \n");

            return QuestionWithAnswersAndCorrectAnswer.ToString();
        }
    }
}
