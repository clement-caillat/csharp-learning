namespace App
{
    public static class NoteApp
    {
        public static void Main()
        {
            Console.ResetColor();
            Note.init();
            Menu.drawMenu("main.menu", Menu.mainMenu);
        }
    }
}