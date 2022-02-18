namespace App
{

    public static class Tools
    {
        public static void printColor<T>(T text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}