using System;

namespace Setul_2___ex._8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ...

            int s = 0, n, nr1 = 0, nr2 = 1, numarn = 0;

            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            if (n == 1)
                Console.Write(nr1 + " ");
            else
                Console.Write(nr1 + " " + nr2 + " ");

            for (int i = 3; i <= n; i++)
            {
                s = nr1 + nr2;
                Console.Write(s + " ");

                nr1 = nr2;

                nr2 = s;

                if (i == n)
                    numarn = i;
            }

            Console.WriteLine();

            if (n == 1)
                numarn = nr1;
            else if (n == 2)
                numarn = nr2;

            Console.Write($"Al {n}-lea numar din sirul lui Fibonacci este {numarn}");
        }
    }
}
