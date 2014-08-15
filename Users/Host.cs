namespace Users
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using WhoWantsToBeAMillionaire;

    public class Host : User
    {
        public Host(string username)
            : base(username)
        {
        }

        public void CreateQuestionnaire()
        {
            int questionnairesCount = Directory.GetDirectories(@"...\\...\\...\\Questionnaires").Length;
            DirectoryInfo di = Directory.CreateDirectory(@"...\\...\\...\\Questionnaires\\Questionnary " + questionnairesCount);
        }

        public void CreateQuestion(int questionnaireNumber, int questionNumber, string question, List<string> answers, short correctAnswer)
        {
            StreamWriter streamWriter = new StreamWriter(@"...\\...\\...\\Questionnaires\\Questionnary " + questionnaireNumber + @"\\Question " + questionNumber + ".txt");
            QuestionWithAnswers questionWithAnswer = new QuestionWithAnswers(question, answers, correctAnswer);

            using (streamWriter)
            {
                streamWriter.WriteLine(questionWithAnswer.ToStringWithCorrectAnswer());
            }
        }

        public void DeleteQuestion(int questionnaireNumber, int questionNumber)
        {
            File.Delete(@"...\\...\\...\\Questionnaires\\Questionnary " + questionnaireNumber + @"\\Question " + questionNumber + ".txt");
        }
    }
}
