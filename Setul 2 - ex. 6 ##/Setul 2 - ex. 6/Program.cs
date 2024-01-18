using System;

namespace Setul_2___ex._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. 

            int n, ok = 1, nr, nra;

            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            Console.Write("nr = ");
            nr = int.Parse(Console.ReadLine());

            nra = nr;

            for (int i = 1; i < n; i++)
            {
                Console.Write("nr = ");
                nr = int.Parse(Console.ReadLine());

                if (nr <= nra)
                    ok = 0;
            }

            if (ok == 1)
                Console.WriteLine("Numerele sunt in ordine crescatoare.");
            else
                Console.WriteLine("Numerele nu sunt in ordine crescatoare.");
        }
    }
}
