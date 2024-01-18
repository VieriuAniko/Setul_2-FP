using System;

namespace Setul_2___ex._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Se da o secventa de n numere. Sa se determine cate sunt negative, cate sunt zero si cate sunt pozitive.

            int n, nrneg = 0, nr0 = 0, nrpoz = 0, numar;

            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("numar = ");
                numar = int.Parse(Console.ReadLine());

                if (numar < 0)
                    nrneg++;
                else
                    if (numar > 0)
                        nrpoz++;
                    else
                        nr0++;
            }
            Console.WriteLine($"Numere negative: {nrneg}\n0-uri: {nr0}\nNumere pozitive: {nrpoz}");
        }
    }
}
