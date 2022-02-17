using System;

namespace App
{
    public static class Menu
    {
        public static void draw()
        {  

            List<string> options = new List<string>();

            int counter = 0;
            int x = 0;
            int y = 0;
            int index = 0;

            foreach (string line in System.IO.File.ReadLines("titles.menu"))
            {  
                options.Add($"{index}." + line);
                counter++;
            }

            foreach (string item in options)
            {  
                if (x < item.Length)
                {
                    x++;
                }

                y++;
            }

            var size = new Dictionary<char, int>()
            {
                {'x', 3 * (x + 2)},
                {'y', 2 * (y + 2)}
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
                if (index <= counter) {
                    Console.Write(options[index]);
                }
                for (int w = 0; w < (size['x'] - options[index].Length) / 2; w++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("█");
                if (index <= counter) {
                    index++;
                }
            }
            Console.Write("█");
            for (int w = 0; w < size['x']; w++)
            {
                Console.Write("▄");
            }
            Console.WriteLine("█");
        }
    }
}