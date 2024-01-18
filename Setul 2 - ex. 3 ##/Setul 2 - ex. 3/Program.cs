
using System;

namespace Setul_2___ex._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Calculati suma si produsul numerelor de la 1 la n. 

            int n, suma = 0, produs = 1;

            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                suma += i;
                produs *= i;
            }

            Console.WriteLine($"Suma numerelor de la 1 la {n} este {suma}, iar produsul este {produs}.");
        }
    }
}
