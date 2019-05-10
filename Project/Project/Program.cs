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


            Console.WriteLine("Zemes rutulio plotas: {0}", plotas);
            Console.WriteLine("Zemes rutulio turid: {0}", turis);
            Console.WriteLine("Staciojo trikampio izambines ilgis: {0}", izambine);

            Console.WriteLine("Kintamuju suma: {0}", plotas + turis + izambine);
            Console.WriteLine("Kintamuju vidurkis: {0}", (plotas + turis + izambine) / 3);

            Console.ReadLine();

        }
    }
}
