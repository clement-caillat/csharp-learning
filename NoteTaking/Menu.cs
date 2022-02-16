using System;

namespace App
{
    public static class Menu
    {
        public static void draw(int x, int y)
        {  

            string[] options = {};

            foreach (string line in System.IO.File.ReadLines("titles.menu"))
            {  
                options.Add(line);
            }

            foreach (string item in options)
            {
                Console.Write(item);                
            }



            // var size = new Dictionary<char, int>()
            // {
            //     {'x', x},
            //     {'y', y}
            // };
            
            // Console.Write("█");
            // for (int w = 0; w < size['x']; w++)
            // {
            //     Console.Write("▀");
            // }
            // Console.WriteLine("█");
            // for (int h = 0; h < size['y']; h++)
            // {
            //     Console.Write("█");
            //     for (int w = 0; w < size['x']; w++)
            //     {
            //         Console.Write(" ");
            //     }
            //     Console.WriteLine("█");
            // }
            // Console.Write("█");
            // for (int w = 0; w < size['x']; w++)
            // {
            //     Console.Write("▄");
            // }
            // Console.WriteLine("█");
        }
    }
}