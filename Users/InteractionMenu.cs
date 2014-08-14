using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using WhoWantsToBeAMillionaire;

namespace Users
{
    public class InteractionMenu
    {
        public void Menu()
        {
            Console.WriteLine("WELCOME TO THE MENU");
            Console.Write("If you are a teacher, press 1. Elsewhere, press 2: ");

            int input = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter your username: ");
            string username = Console.ReadLine();

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();
            Console.WriteLine();

            if (input == 1)
            {
                Host newHost = new Host(username, password);

                WriteOptions();

                Console.WriteLine();

                Console.Write("Enter your choice: ");
                input = int.Parse(Console.ReadLine());
                Console.WriteLine();

                while (input != 7)
                {
                    int questionnaireNumber;
                    int questionNumber;
                    string question;
                    List<string> answers = new List<string>();
                    short correctAnswer;

                    Console.Clear();

                    switch (input)
                    {

                        case 1:

                            newHost.CreateQuestionnaire();
                            Console.WriteLine("Congratulations, the questionnaire was created. Now add questions to it.");
                            Console.WriteLine();
                            WriteOptions();

                            break;

                        case 2:

                            Console.Write("Enter the number of the questionnaire you want to add question to: ");
                            questionnaireNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            Console.Write("Enter the number of the question you want to add: ");
                            questionNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            Console.Write("Enter the question you want to add: ");
                            question = Console.ReadLine();
                            Console.WriteLine();

                            Console.WriteLine("Enter the answers you want to add.");

                            for (int i = 0; i < 4; i++)
                            {
                                Console.Write("Answer {0}: ", i);
                                string answer = Console.ReadLine();
                                answers.Add(answer);
                            }

                            Console.WriteLine();

                            Console.Write("Enter the number of the correct answer: ");
                            correctAnswer = short.Parse(Console.ReadLine());
                            Console.WriteLine();

                            newHost.CreateQuestion(questionnaireNumber, questionNumber, question, answers, correctAnswer);
                            WriteOptions();

                            break;

                        case 3:

                            Console.Write("Enter the number of the questionnaire you want to delete question from: ");
                            questionnaireNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            Console.Write("Enter the number of the question you want to delete: ");
                            questionNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            newHost.DeleteQuestion(questionnaireNumber, questionNumber);
                            WriteOptions();

                            break;

                        case 4:

                            Console.Write("Enter the number of the questionnaire you want to edit question from: ");
                            questionnaireNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            Console.Write("Enter the number of the question you want to edit: ");
                            questionNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            StreamReader streamReader = new StreamReader(@"...\\...\\...\\Questionnaires\\Questionnary " + questionnaireNumber + @"\\Question " + questionNumber + ".txt");

                            using (streamReader)
                            {
                                Console.WriteLine("This is the current question: ");
                                Console.WriteLine();
                                question = streamReader.ReadToEnd();
                                Console.WriteLine(question);
                            }

                            newHost.DeleteQuestion(questionnaireNumber, questionNumber);

                            Console.Write("Enter the edited question you want to add: ");
                            question = Console.ReadLine();
                            Console.WriteLine();

                            Console.WriteLine("Enter the edited answers you want to add.");
                            answers = new List<string>();

                            for (int i = 0; i < 4; i++)
                            {
                                Console.Write("Answer {0}: ", i);
                                string answer = Console.ReadLine();
                                answers.Add(answer);
                            }

                            Console.WriteLine();

                            Console.Write("Enter the number of the correct answer: ");
                            correctAnswer = short.Parse(Console.ReadLine());
                            Console.WriteLine();

                            newHost.CreateQuestion(questionnaireNumber, questionNumber, question, answers, correctAnswer);
                            WriteOptions();

                            break;

                        case 5:

                            Console.Write("Enter the number of the questionnaire you want to delete: ");
                            questionnaireNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            Directory.Delete(@"...\\...\\...\\Questionnaires\\Questionnary " + questionnaireNumber, true);
                            WriteOptions();

                            break;

                        default:
                            break;
                    }

                    Console.Write("Enter your new choice: ");
                    input = int.Parse(Console.ReadLine());
                }
            }

            else
            {
                Player newPlayer = new Player(username, password);
                int[] prizes = { 0, 100, 200, 300, 500, 1000, 2000, 4000, 8000, 16000, 32000, 64000, 125000, 250000, 500000, 1000000 };

                Console.Write("Enter the number of the questionnaire you want to take: ");
                int questionnaireNumber = int.Parse(Console.ReadLine());

                int questionsCount = Directory.GetFiles(@"...\\...\\...\\Questionnaires\\Questionnary " + questionnaireNumber).Length;

                for (int questionNumber = 0; questionNumber < questionsCount; questionNumber++)
                {
                    Console.Clear();

                    StreamReader streamReader = new StreamReader(@"...\\...\\...\\Questionnaires\\Questionnary " + questionnaireNumber + @"\\Question " + questionNumber + ".txt");
                    string correctAnswerLine = File.ReadLines(@"...\\...\\...\\Questionnaires\\Questionnary " + questionnaireNumber + @"\\Question " + questionNumber + ".txt").Skip(5).Take(1).First().Trim();
                    string correctAnswer = correctAnswerLine[correctAnswerLine.Length - 2].ToString();

                    using (streamReader)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine(streamReader.ReadLine());
                        }
                        Console.WriteLine();
                    }

                    Console.Write("Choose your answer or type \"Stop\" in order to stop your participation with the sum you already have: ");
                    string answer = Console.ReadLine();

                    if (answer == "Stop")
                    {
                        Console.WriteLine("Congratulations, your final prize is {0}!", prizes[questionNumber]);
                        Console.WriteLine();
                        break;
                    }

                    else if (correctAnswer != answer)
                    {
                        Console.WriteLine("Sorry, wrong answer! Your final prize is {0}. Better luck next time.", prizes[questionNumber / 5]);
                        Console.WriteLine();
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Congratulations, you just won {0}!", prizes[questionNumber + 1]);
                        Console.WriteLine();
                        continue;
                    }
                }
            }
        }

        public void WriteOptions()
        {
            Console.WriteLine("To create new questionnaire, press 1.");
            Console.WriteLine("To add a question to existing questionnaire, press 2.");
            Console.WriteLine("To delete a question from existing questionnaire, press 3.");
            Console.WriteLine("To edit a question from existing questionnaire, press 4.");
            Console.WriteLine("To delete questionnaire, press 5.");
            Console.WriteLine("To view previous results, press 6.");
            Console.WriteLine("To exit from the program, press 7.");
            Console.WriteLine();
        }
    }
}
