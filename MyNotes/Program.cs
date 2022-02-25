namespace App
{
    public class Program
    {

        private static string noteDirectory = Environment.CurrentDirectory + "/notes";
        public static void Main()
        {
            InitializeApp();
            MenuStarter();
        }

        private static void MenuStarter(int menu = 0)
        {
            switch (menu)
            {
                case 0:
                    Menu MainMenu = new Menu("Main Menu", new string[5] {"View notes", "Create note", "Delete note", "Reset All", "Quit"});
                    Main_Menu(MainMenu.Run());
                    break;
                case 1:
                    int count = 0;
                    string[] n;
                    string[] notes = Directory.GetFiles(noteDirectory);
                    foreach (var note in notes)
                    {
                        count++;
                    }
                    n = new string[count];
                    int i = 0;
                    foreach (var note in notes)
                    {
                        n[i] = Path.GetFileName(note).Split('.')[0];
                        i++;
                    }

                    Menu ViewNoteMenu = new Menu("Notes", n);
                    ViewNote_Menu(ViewNoteMenu.Run());

                    break;
                case 2:
                    Console.Write("Titre de la note : ");
                    string? title = Console.ReadLine();
                    string path = Environment.CurrentDirectory + "/notes/" + title + ".txt";

                    Console.Write("Combien de lignes : ");
                    int n_lines = Convert.ToInt32(Console.ReadLine());

                    string[] lines = new string[n_lines];

                    for(int iter = 0; iter < n_lines; iter++)
                    {
                        string? line = Console.ReadLine();
                        lines[iter] = line;
                    }
                    using (StreamWriter writer = new StreamWriter(path))  
                    {  
                        foreach (string line in lines)
                        {
                            writer.WriteLine(line);
                        }  
                    }  
                    MenuStarter();
                    break;
                case 3:
                    int c = 0;
                    string[] no;
                    string[] notess = Directory.GetFiles(noteDirectory);
                    foreach (var note in notess)
                    {
                        c++;
                    }
                    n = new string[c];
                    int it = 0;
                    foreach (var note in notess)
                    {
                        n[it] = Path.GetFileName(note).Split('.')[0];
                        it++;
                    }

                    Menu DeleteNoteMenu = new Menu("Notes", n);
                    DeleteNote_Menu(DeleteNoteMenu.Run());
                    break;
                case 4:
                    Menu ResetMenu = new Menu("Reset all ?", new string[2] {"Yes", "No"});
                    Reset_Menu(ResetMenu.Run());
                    break;

            }
        }
        private static void Main_Menu(int option)
        {
            switch (option)
            {
                case 0:
                    MenuStarter(1);
                    break;
                case 1:
                    MenuStarter(2);
                    break;
                case 2:
                    MenuStarter(3);
                    break;
                case 3:
                    MenuStarter(4);
                    break;
                case 4:
                    Console.Clear();
                    System.Environment.Exit(1);
                    break;
                default:
                    break;
            }
        }

        private static void ViewNote_Menu(int option)
        {
            string[] notes = Directory.GetFiles(noteDirectory);
            
            foreach (string line in System.IO.File.ReadLines(notes[option]))
            {
                Console.WriteLine(line);                
            }
            Console.ReadLine();
            MenuStarter();
        }
        private static void Reset_Menu(int option)
        {
            switch (option)
            {
                case 0:
                    if (Directory.Exists(noteDirectory))
                    {
                        ResetAll();
                    }
                    MenuStarter();
                    break;
                case 1:
                    MenuStarter();
                    break;
            }
        }

        public static void DeleteNote_Menu(int option)
        {
            string[] notes = Directory.GetFiles(noteDirectory);
            
            File.Delete(notes[option]);
            MenuStarter();
        }

        public static void ResetAll()
        {
            string[] files = Directory.GetFiles(noteDirectory);

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }
        }

        private static void InitializeApp()
        {
            Console.Title = "MyNotes";
            Console.CursorVisible = false;
            if (!Directory.Exists(noteDirectory))
            {
                Directory.CreateDirectory(noteDirectory);
            }
        }
    }
}