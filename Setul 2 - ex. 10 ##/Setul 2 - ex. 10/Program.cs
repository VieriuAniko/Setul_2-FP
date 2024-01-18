using System;

namespace Setul_2___ex.__10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. 

            int n, i, nrmax = 0, nr = 0, x, y;

            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            Console.Write("y = ");
            y = int.Parse(Console.ReadLine());

            nr++;

            for (i = 1; i < n; i++) 
            {
                Console.Write("x = ");
                x = int.Parse(Console.ReadLine());

                if (x == y)
                    nr++;
                else
                {
                    nrmax = nr;
                    nr = 1;
                }
                y = x;
            }

            Console.WriteLine($"Numarul maxim de numere consecutive egale din secventa de {n} numere date este {nrmax}.");
        }
    }
}