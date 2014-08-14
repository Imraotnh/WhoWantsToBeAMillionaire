using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoWantsToBeAMillionaire
{
    class Program
    {
        static void Main(string[] args)
        {
            QuestionWithAnswers first = new QuestionWithAnswers("Koy e Boyko?", new List<string>() { "pich", "gay", "desen" }, 2);
            QuestionWithAnswers second = new QuestionWithAnswers("Koy ne e Boyko?", new List<string>() { "pich", "gay", "desen" }, 2);
            Console.WriteLine(first);
            Console.WriteLine(second);
            Questionnaire quest = new Questionnaire(new List<QuestionWithAnswers>() { });
           

            quest.Questions.Add(first);
            quest.Questions.Add(second);
            Console.WriteLine(quest.ToString());
            Console.WriteLine(quest.ToStringWithCorrectAnswers());

            second.ChangeQuestion("Q kaji za Radan bokluk");

            Console.WriteLine(quest.ToString());
            Console.WriteLine(quest.ToStringWithCorrectAnswers());
        }
    }
}
