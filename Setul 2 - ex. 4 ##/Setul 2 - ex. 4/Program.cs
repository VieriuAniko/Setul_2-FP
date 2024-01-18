using System;

namespace Setul_2___ex._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1. 

            int n, a, numar, ok = 0, nr = -1;

            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("numar = ");
                numar = int.Parse(Console.ReadLine());

                if (numar == a)
                {
                    //Console.WriteLine(i);
                    nr = i;
                    ok = 1;
                }
            }
            Console.WriteLine(nr);
        }
    }
}
