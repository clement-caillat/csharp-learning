namespace App
{
    public static class NoteApp
    {
        public static void Main()
        {
            Note.init();
            Menu.draw();
        }

        public static void printColor(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}