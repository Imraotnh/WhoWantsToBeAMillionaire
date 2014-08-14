namespace WhoWantsToBeAMillionaire
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Questionnaire
    {
        public List<QuestionWithAnswers> Questions { get; set; }

        public Questionnaire(List<QuestionWithAnswers> questions)
        {
            this.Questions = questions;
        }

        public void AddQuestion(QuestionWithAnswers question)
        {
            this.Questions.Add(question);
        }

        public void DeleteQuestion(int index)
        {
            this.Questions.RemoveAt(index);
        }

        public void ClearQuestionnaire()
        {
            this.Questions.Clear();
        }

        public override string ToString()
        {
            StringBuilder questionnaire = new StringBuilder();

            int questionsCount = this.Questions.Count;

            for (int i = 0; i < questionsCount; i++)
            {
                questionnaire.Append(i + ". " + this.Questions[i].ToString() + "\n");                
            }

            return questionnaire.ToString();
        }

        public string ToStringWithCorrectAnswers()
        {
            StringBuilder questionnaire = new StringBuilder();

            int questionsCount = this.Questions.Count;

            for (int i = 0; i < questionsCount; i++)
            {
                questionnaire.Append(i + ". " + this.Questions[i].ToStringWithCorrectAnswer() + "\n");       
            }

            return questionnaire.ToString();            
        }
    }
}
