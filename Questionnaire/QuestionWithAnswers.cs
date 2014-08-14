namespace WhoWantsToBeAMillionaire
{
    using System;
    using System.Collections.Generic;
    using System.Text;

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
            StringBuilder questionWithAnswers = new StringBuilder();
            questionWithAnswers.Append(this.Question + "\n");

            int answersCount = this.Answers.Count;

            for (int i = 0; i < answersCount; i++)
            {
                questionWithAnswers.Append((char)(65 + i) + ") " + this.Answers[i] + "\n");
            }
            
            return questionWithAnswers.ToString();
        }

        public string ToStringWithCorrectAnswer()
        {
            StringBuilder questionWithAnswersAndCorrectAnswer = new StringBuilder();
            questionWithAnswersAndCorrectAnswer.Append(this.ToString());

            questionWithAnswersAndCorrectAnswer.Append("Correct answer: " + "(" + (char)(65 + this.CorrectAnswer) + ") \n \n");

            return questionWithAnswersAndCorrectAnswer.ToString();
        }
    }
}
