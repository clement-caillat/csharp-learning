namespace Game
{
    class Program
    {

        // Fonction pour écrire du texte en couleur
        // C'est une fonction privée qui ne retourne rien, prend en paramètre une string et un objet ConsoleColor
        private static void printColour(string text, ConsoleColor colour)
        {
            // On set la couleur
            Console.ForegroundColor = colour;
            // On écrit le texte
            Console.WriteLine(text);
            // On reset la couleur à celle de base
            Console.ResetColor();
        }

        // Notre fonction Main
        static void Main()
        {
            Console.Title = "Less Or Plus Game";
            // On créer un nouvel objet de type random
            Random rand = new Random();
            // On créer une variable de type integer à qui on attribu un chiffre aléatoire entre 1 et 100 grâce à notre objet rand
            int mystery = rand.Next(1, 100);

            // On instantie le nombre integer que l'utilisateur rentrera pour rentrer dans la boucle
            int unumber = 0;
            
            // Impression de l'écran de bienvenue
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--------Welcome on Less or Plus Game---------");
            Console.ResetColor();


            // Boucle du jeu
            while (unumber != mystery)
            {
                Console.Write("Please choose number : ");
                string? n = Console.ReadLine();

                unumber = Convert.ToInt32(n);

                if (unumber < mystery){
                    printColour("It's plus", ConsoleColor.Green);
                }
                else if (unumber > mystery)
                {
                    printColour("It's less", ConsoleColor.Red);
                }
                else
                {
                    printColour("You win !", ConsoleColor.Magenta);
                    Console.Beep();
                    Console.Beep();
                }
            }
        }



    }
}