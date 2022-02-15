namespace App
{
    public static class Menu
    {
        public static void draw(int x, int y)
        {  
            var size = new Dictionary<char, int>()
            {
                {'x', x},
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
                for (int w = 0; w < size['x']; w++)
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
    }
}