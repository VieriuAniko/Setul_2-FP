namespace Setul_2____ex._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrescator.
            //De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. Sa se determine daca este bitonica. 

            int n, i, cresc = 1, descresc = 0;

            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            int previous, current;

            Console.Write("previous = ");
            previous = int.Parse(Console.ReadLine());

            Console.Write("current = ");
            current = int.Parse(Console.ReadLine());

            if (previous > current)
            {
                Console.WriteLine("Secventa de numere nu este bitonica.");
                //Environment.Exit(0);
                cresc = 0;
            }
            else
                previous = current;

            if (cresc == 1)
            {
                for (i = 3; i <= n; i++) 
                {
                    Console.Write("current = ");
                    current = int.Parse(Console.ReadLine());

                    if (previous > current)
                    {
                        cresc = 0;
                        descresc = 1;
                    }

                    if (descresc == 1 && (previous < current))
                        Console.WriteLine("Secventa de numere nu este bitonica.");
                    previous = current;
                }
            }


            if (cresc == 0 && descresc == 1)
                Console.WriteLine("Secventa de numere este bitonica.");
            //else Console.WriteLine("Secventa de numere nu este bitonica.");
        }
    }
}
