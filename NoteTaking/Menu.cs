using System;

namespace App
{
    public static class Menu
    {

        public static void GetUserChoice()
        {
            Tools.printColor<string>("Please choose an option : ", ConsoleColor.Blue);
            try
            {
                string? choice = Console.ReadLine();
                Console.WriteLine(choice);
            }
            catch (System.Exception)
            {
                Tools.printColor<string>("Error", ConsoleColor.Red);
                throw;
            }
        }

        public static void drawMenu(string path, Func<int> callback)
        {  

            Console.Clear();
            
            List<string> options = new List<string>();

            int counter = 1;
            int x = 0;
            int y = 0;
            int index = 0;

            try
            {
                System.IO.File.ReadLines($"menus/{path}");
            }
            catch (System.Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                throw new System.IO.FileNotFoundException($"Le fichier menus/{path} est introuvable");
            }
            finally {
                foreach (string line in System.IO.File.ReadLines($"menus/{path}"))
                {  
                    options.Add($"{counter}." + line);
                    counter++;
                }
            }


            foreach (string item in options)
            {  
                if (x < item.Length)
                {
                    x++;
                }

                y++;
            }
            counter -= 2;

            var size = new Dictionary<char, int>()
            {
                {'x', x + 2},
                {'y', y}
            };
            
            Console.Write("█");
            for (int w = 0; w < size['x']; w++)
            {
                Console.Write("▀");
            }
            Console.WriteLine("█");
            for (int h = 0; h < size['y']; h++)
            {

                Console.Write("█");
                for (int w = 0; w < (size['x'] - options[index].Length) / 2; w++)
                {
                    Console.Write(" ");
                }
                Console.Write(options[index]);
                for (int w = 0; w < (size['x'] - options[index].Length) / 2; w++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("█");
                if (index < counter) {
                    index++;
                }
            }
            Console.Write("█");
            for (int w = 0; w < size['x']; w++)
            {
                Console.Write("▄");
            }
            Console.WriteLine("█");

            callback();
        }

        public static int mainMenu()
        {
            Console.WriteLine("Hello from main menu");
            return 0;
        }
    }
}