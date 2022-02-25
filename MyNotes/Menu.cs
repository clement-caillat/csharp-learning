namespace App
{
    public class Menu
    {
        private bool running = false;
        private string name;
        private string[] choices;

        private int currentIndex = 0;
        public Menu(string name, string[] choices)
        {
            this.name = name;
            this.choices = choices;
            this.Draw();
        }

        private void Draw()
        {
            Console.Clear();
            #region InitializeSize

            int maxWidth;
            int lastMax = 0;
            int height = 4;
            int index = 0;

            foreach (var item in choices)
            {
                if (lastMax < item.Length)
                {
                    lastMax = item.Length;
                }
                height++;
            }

            maxWidth = lastMax;

            if (lastMax < this.name.Length)
            {
                maxWidth = this.name.Length;
            }

            var size = new Dictionary<char, int>()
            {
                {'x', maxWidth + 10},
                {'y', height}
            };

            #endregion


            Console.Write("█");
            for (int w = 0; w < size['x']; w++)
            {
                Console.Write("▀");
            }
            Console.WriteLine("█");
            
            Console.Write("█");
            for (int w = 0; w < (size['x'] - this.name.Length) / 2; w++)
            {
                Console.Write(" ");
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(this.name);
            Console.ResetColor();
            for (int w = 0; w < (size['x'] - this.name.Length) / 2; w++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("█");
            Console.Write("█");
            for (int w = 0; w < size['x']; w++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("█");

            foreach (string option in choices)
            {
                Console.Write("█");
                for (int w = 0; w < (size['x'] - option.Length) / 2; w++)
                {
                    Console.Write(" ");
                }
                if (this.currentIndex == index)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(option);
                    Console.ResetColor();
                } else
                {
                    Console.Write(option);
                }
                index++;

                for (int w = 0; w < (size['x'] - option.Length) / 2; w++)
                {
                    Console.Write(" ");
                }
                if ((size['x'] - option.Length) % 2 != 0)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("█");
            }
            Console.Write("█");
            for (int w = 0; w < size['x']; w++)
            {
                Console.Write("▄");
            }
            Console.WriteLine("█");
        }


        public int Run()
        {
            this.running = true;

            while (this.running)
            {
                var key = Console.ReadKey().Key;
                if (key == ConsoleKey.Enter) 
                {
                    this.running = false;
                }
                if (key == ConsoleKey.UpArrow)
                {
                    if (this.currentIndex > 0)
                    {
                        this.currentIndex--;
                        this.Draw();
                    }
                }
                if (key == ConsoleKey.DownArrow)
                {
                    if (this.currentIndex < (this.choices.Length - 1))
                    {
                        this.currentIndex++;
                        this.Draw();
                    }
                }
            }

            return this.currentIndex;
        }

        public void ShowName()
        {
            Console.Write(this.name);
        }
    }
}