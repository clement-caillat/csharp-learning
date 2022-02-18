namespace App
{
    public class Note
    {
        public static string noteDirectory = Environment.CurrentDirectory + "/notes";

        public static void init()
        {
            if (!Directory.Exists(noteDirectory))
            {
                Console.WriteLine("Creating directory...");
                Thread.Sleep(2000);
                Directory.CreateDirectory(noteDirectory);
                Tools.printColor("Directory created !", ConsoleColor.Green);
                Thread.Sleep(1000);
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
