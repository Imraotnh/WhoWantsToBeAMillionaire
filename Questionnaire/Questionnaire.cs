using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WhoWantsToBeAMillionaire
{
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
            StringBuilder Questionnaire = new StringBuilder();

            int questionsCount = this.Questions.Count;

            for (int i = 0; i < questionsCount; i++)
            {
                Questionnaire.Append(i + ". " + this.Questions[i].ToString() + "\n");                
            }

            return Questionnaire.ToString();
        }

        public string ToStringWithCorrectAnswers()
        {
            StringBuilder Questionnaire = new StringBuilder();

            int questionsCount = this.Questions.Count;

            for (int i = 0; i < questionsCount; i++)
            {
                Questionnaire.Append(i + ". " + this.Questions[i].ToStringWithCorrectAnswer() + "\n");       
            }

            return Questionnaire.ToString();            
        }
    }
}
