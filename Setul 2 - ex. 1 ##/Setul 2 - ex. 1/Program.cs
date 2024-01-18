using System;

namespace Setul_2___ex._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Se da o secventa de n numere. Sa se determine cate din ele sunt pare. 

            int n, numar, nr = 0;

            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                numar = int.Parse(Console.ReadLine());

                if (numar % 2 == 0)
                    nr++;
            }
            Console.WriteLine($"{nr} dintre numerele date sunt pare.");
        }
    }
}
