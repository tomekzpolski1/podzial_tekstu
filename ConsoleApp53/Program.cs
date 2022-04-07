using System;

namespace ConsoleApp53
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst = "W parę godzin później, gdy noc zbierała się do odejścia,\n" +
                "Puchatek obudził się nagle z uczuciem dziwnego przygnębienia.\n" +
                "To uczucie dziwnego przygnębienia miewał już nie raz i wiedział,\n" +
                "co ono oznacza. Był głodny. Więc poszedł do spiżarni,\n" +
                "wgramolił się na krzesełko, sięgnął na górną półkę, ale nic nie znalał.";
            Console.WriteLine(tekst);

            int licznik = 1;
            int start = 0;
            while ((start = tekst.IndexOf('\n', start + 1)) >= 0)
            {
                licznik++;
            }
            Console.WriteLine("\nLiczba wierszy w tekście: {0}", licznik);
            Console.WriteLine();
            string[] podzial = tekst.Split('\n'); // podzial tekstu na tablce stringow gdzie kazdy zawiera string to jedne wiersz
            for (int i = 0; i < podzial.Length; i++)
            {
                Console.WriteLine("W wierszu '{0}', mamy {1} znaków.", podzial[i], podzial[i].Length);
                Console.WriteLine();
            }
            Console.WriteLine("\nIlość znaków w całym tekście: {0}", tekst.Length);
            Console.ReadKey();
        }
    }
}
