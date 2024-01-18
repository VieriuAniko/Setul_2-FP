using System;

namespace Setul_2___ex._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. Considerati fiecare astfel de grup ca fiind un cuvant,
            //zero fiind delimitator de cuvinte.

            ///<example>1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3</example>

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            int grupuri = 0, /*nrConsecActual*/ nrConsecPredecesor, ok = 1, numar = int.Parse(Console.ReadLine()),  nr = 1;

            while (numar == 0)
            {
                Console.Write("numar = ");
                numar = int.Parse(Console.ReadLine());
                nr++;
            }

            nrConsecPredecesor = numar;

            for (int i = nr; i < n; i++) 
            {
                Console.Write("numar = ");
                numar = int.Parse(Console.ReadLine());

                if (numar != 0 && numar == nrConsecPredecesor + 1)
                {
                    nrConsecPredecesor = numar;
                    ok = 1;
                }
                else if ((numar != 0 && numar != nrConsecPredecesor + 1 && ok == 1) || numar == 0 && ok == 1)
                {
                    grupuri++;
                    ok = 0;
                }
            }
            if (ok == 1)
                grupuri++;
            
            if (grupuri == 1)
                Console.WriteLine($"In secventa data exista {grupuri} grup de numere consecutive");
            else
                Console.WriteLine($"In secventa data exista {grupuri} grupuri de numere consecutive");
        }
    }
}
