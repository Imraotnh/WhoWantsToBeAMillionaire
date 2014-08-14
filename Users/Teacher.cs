﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using WhoWantsToBeAMillionaire;

namespace Users
{
    public class Teacher
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Teacher(string username, string password)
        {
            this.Username = username;
            this.Password = password;
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
    }
}
