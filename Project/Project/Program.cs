using System;

namespace Project
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double plotas = Math.PI * Math.Pow(6371, 2);
            double turis = 4/3 * Math.PI * Math.Pow(6371, 3);
            double izambine = Math.Sqrt(Math.Pow(10, 2) + Math.Pow(15, 2));


            Console.WriteLine("Kintamuju suma: {0}", plotas + turis + izambine);
            Console.WriteLine("Kintamuju vidurkis: {0}", (plotas + turis + izambine) / 3);

            Console.ReadLine();

        }
    }
}
