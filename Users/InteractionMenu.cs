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
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("WELCOME TO THE MENU");
            Console.WriteLine("To create new questionnaire, press 1.");
            Console.WriteLine("To add a question to existing questionnaire, press 2.");
            Console.WriteLine("To delete a question from existing questionnaire, press 3.");
            Console.WriteLine("To edit a question from existing questionnaire, press 4.");
            Console.WriteLine("To delete questionnaire, press 5.");
            Console.WriteLine("To view previous results, press 6.");
            Console.WriteLine("To exit from the program, press 7.");

            
            while (input != 7)
            {
                switch (input)
                {
                    case 1:

                    default:
                        break;
                }
                
            }
        }
    }        
}
