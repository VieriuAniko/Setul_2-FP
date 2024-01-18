using System;

namespace Setul_2___ex._7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. 

            int n, numar, maxim, minim;

            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            Console.Write("numar = ");
            numar = int.Parse(Console.ReadLine());
            maxim = numar;
            minim = numar;

            for (int i = 1; i < n; i++)
            {
                Console.Write("numar = ");
                numar = int.Parse(Console.ReadLine());

                if (numar > maxim)
                    maxim = numar;

                if (numar < minim)
                    minim = numar;
            }

            Console.WriteLine($"In secventa data, de {n} numere, cea mai mare valoare este {maxim}, iar cea mai mica este {minim}");
        }
    }
}
