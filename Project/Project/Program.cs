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
            double kvPlotas = Math.Pow(10,2);
            double a = 10;


            Console.WriteLine("Zemes rutulio plotas: {0}", plotas);
            Console.WriteLine("Zemes rutulio turis: {0}", turis);
            Console.WriteLine("Staciojo trikampio izambines ilgis: {0}", izambine);

            Console.WriteLine("Kintamuju suma: {0}", plotas + turis + izambine);
            Console.WriteLine("Kintamuju vidurkis: {0}", (plotas + turis + izambine) / 3);
            

            Console.ReadLine();

        }
    }
}
