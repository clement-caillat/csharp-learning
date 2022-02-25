namespace App
{
    public static class Program
    {
        public static void Main(String[] args)
        {
            Console.Title ="This is a Test app";
            Console.WriteLine($"Voici les paramètres : {args[0]}");
            Console.ReadKey();
        }
    }
}