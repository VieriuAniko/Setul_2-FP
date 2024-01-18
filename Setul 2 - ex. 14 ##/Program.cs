namespace Setul_2___ex._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive.
            //Determinati daca o secventa de n numere este o secventa monotona rotita. 

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write($"Numarul de pe pozitia {0}: ");
            int x = int.Parse(Console.ReadLine());

            int firstNumber = x;
            int cresc = 0;
            int descresc = 0;

            for (int i = 1; i < n; i++)
            {
                Console.Write($"Numarul de pe pozitia {i}: ");
                int y = int.Parse(Console.ReadLine());
                if (x >= y)
                    cresc++;
                if (x <= y) 
                    descresc++;

                x = y;
            }
            if ((cresc <= 1 && firstNumber > x) || (descresc <= 1 && firstNumber < x))
                Console.WriteLine("Secventa este monoton rotita.");
            else
                Console.WriteLine("Secventa nu este monoton rotita.");
        }
    }
}
