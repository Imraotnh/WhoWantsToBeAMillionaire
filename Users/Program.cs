namespace Users
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Main(string[] args)
        {
            Directory.CreateDirectory(@"...\\...\\...\\Questionnaires");
            InteractionMenu menu = new InteractionMenu();
            menu.Menu();
        }
    }
}
