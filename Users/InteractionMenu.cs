using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    public class InteractionMenu
    {
        public void TeacherMenu()
        {
            Console.WriteLine("WELCOME TO THE MENU");
            Console.Write("If you are a teacher, press 1. Elsewhere, press 2: ");

            int input = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (input == 1)
            {
                Console.Write("Enter your username: ");
                string username = Console.ReadLine();

                Console.Write("Enter your password: ");
                string password = Console.ReadLine();
                Console.WriteLine();

                Host newHost = new Host(username, password);

                WriteOptions();

                Console.WriteLine();                

                Console.Write("Enter your choice: ");
                input = int.Parse(Console.ReadLine());
                Console.WriteLine();

                while (input != 7)
                {
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
                            int questionnaireNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            Console.Write("Enter the number of the question you want to add: ");
                            int questionNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            Console.Write("Enter the question you want to add: ");
                            string question = Console.ReadLine();
                            Console.WriteLine();

                            Console.WriteLine("Enter the answers you want to add.");
                            List<string> answers = new List<string>();
                            Console.WriteLine();

                            for (int i = 0; i < 4; i++)
                            {
                                Console.Write("Answer {0}: ", i);
                                string answer = Console.ReadLine();
                                answers.Add(answer);
                            }

                            Console.WriteLine();

                            Console.Write("Enter the number of the correct answer: ");
                            short correctAnswer = short.Parse(Console.ReadLine());
                            Console.WriteLine();

                            newHost.CreateQuestion(questionnaireNumber, questionNumber, question, answers, correctAnswer);
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
