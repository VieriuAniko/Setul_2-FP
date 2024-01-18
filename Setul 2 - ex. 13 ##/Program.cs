namespace Setul_2___ex._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr-o secventa in ordine crescatoare
            //prin rotiri succesive (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul).
            //Determinati daca o secventa de n numere este o secventa crescatoare rotita. 

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write($"Numarul de pe pozitia {0}: ");
            int x = int.Parse(Console.ReadLine());

            int firstNumber = x;
            int j = 0;
            
            for (int i = 1; i < n; i++)
            {
                Console.Write($"Numarul de pe pozitia {i}: ");
                int y = int.Parse(Console.ReadLine());
                if (x > y)
                    j++;

                x = y;
            }
            if (j <= 1 && firstNumber > x)
                Console.WriteLine("Secventa este crescatoare rotita.");
            else
                Console.WriteLine("Secventa nu este crescatoare rotita.");

        }
    }
}
