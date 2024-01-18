using System;

namespace Setul_2___ex._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. Se considera ca primul element din secventa este pe pozitia 0. 

            int n, nr = 0, numar;

            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("numar = ");
                numar = int.Parse(Console.ReadLine());

                if (numar == i)
                    nr++;
            }
            Console.WriteLine($"{nr} numere din secventa sunt egale cu pozitia in care apar.");
        }
    }
}
