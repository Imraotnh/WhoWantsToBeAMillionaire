namespace Users
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            Teacher ayshe = new Teacher("ayshe", "hasan");
            ayshe.CreateQuestionnaire();
            ayshe.CreateQuestion(2, 3, "Kak si", new List<string> { "dobre", "stava", "zle" }, 2);
        }
    }
}
