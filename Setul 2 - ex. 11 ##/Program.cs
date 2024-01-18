using System;

namespace Setul_2___ex._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. 

            int n, suma = 0, ogl = 0, cif, numar;

            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) 
            {
                Console.Write("numar = ");
                numar = int.Parse(Console.ReadLine());

                while (numar != 0)
                {
                    cif = numar % 10;
                    ogl = ogl * 10 + cif;
                    numar /= 10;
                }

                suma += ogl;
                ogl = 0;
            }

            Console.WriteLine($"Suma inverselor secventei de {n} numere date este {suma}.");
        }
    }
}
