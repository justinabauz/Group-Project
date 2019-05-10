using System;

namespace Project
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double plotas = Math.PI * Math.Pow(6371, 2);
            double turis = 0;
            double izambine = 0;


            Console.WriteLine("Kintamuju suma: {0}", plotas + turis + izambine);
            Console.WriteLine("Kintamuju vidurkis: {0}", (plotas + turis + izambine) / 3);

            Console.ReadLine();

        }
    }
}
