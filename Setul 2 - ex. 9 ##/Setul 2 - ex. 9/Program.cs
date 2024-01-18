using System;

namespace Setul_2___ex._9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare.

            int n, numar, x, nrcres = 1, nrdesc = 1;

            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            Console.Write("numar = ");
            numar = int.Parse(Console.ReadLine());
            x = numar;

            for (int i = 1; i < n; i++) 
            {
                Console.Write("numar = ");
                numar = int.Parse(Console.ReadLine());

                if (numar <= x)
                    nrdesc++;

                if (numar >= x)
                    nrcres++;

                x = numar;
            }

            //if (nrcres == n)
            //    Console.WriteLine("Sirul este monoton crescator.");
            //if (nrdesc == n)
            //    Console.WriteLine("Sirul este monoton descrescator.");
            //if (nrcres == nrdesc)
            //    Console.WriteLine("Sirul poate fi sau crescator sau descrescator.");
            //else
            //    Console.WriteLine("Sirul nu este nici crescator, nici descrescator.");

            if (nrcres == nrdesc)
                Console.WriteLine("Sirul poate fi sau monoton crescator sau monoton descrescator.");
            else if (nrcres == n)
                Console.WriteLine("Sirul este monoton crescator.");
            else if (nrdesc == n)
                Console.WriteLine("Sirul este monoton descrescator.");
            else
                Console.WriteLine("Sirul nu este nici monoton crescator, nici monoton descrescator.");
        }
    }
}