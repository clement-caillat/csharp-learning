namespace App
{
    public class Note
    {
        public static string noteDirectory = Environment.CurrentDirectory + "/notes";

        public static void init()
        {
            Console.WriteLine("Checking directory...");
            Thread.Sleep(500);
            if (!Directory.Exists(noteDirectory))
            {
                Console.WriteLine("Creating directory...");
                Thread.Sleep(2000);
                Directory.CreateDirectory(noteDirectory);
                App.NoteApp.printColor("Directory created !", ConsoleColor.Green);
            } else {
                App.NoteApp.printColor("Directory already exists", ConsoleColor.Red);
            }
        }

        public static bool deleteDirectory()
        {
            if (Directory.Exists(noteDirectory))
            {
                Directory.Delete(noteDirectory);
                return true;
            }
            else {
                return false;
            }
        }
    }
}
