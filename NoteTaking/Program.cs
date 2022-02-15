namespace App
{
    public static class NoteApp
    {
        public static void Main()
        {
            Note.init();
            Menu.draw(50, 10);
        }

        public static void printColor(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}