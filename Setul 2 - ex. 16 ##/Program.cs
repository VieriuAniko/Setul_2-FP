namespace Setul_2___ex._16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive
            //(rotire = primul element devine ultimul).Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita. 

            Console.WriteLine("Introduceti o secventa de numere: ");
            string input = Console.ReadLine();

            int secventa = int.Parse(input);

            bool rezultat = EsteBitonicaRotita(secventa);

            if (rezultat)
                Console.WriteLine("Secventa este bitonica rotita");
            else
                Console.WriteLine("Secventa nu este bitonica rotita");

            static bool EsteBitonicaRotita(int secventa)
            {
                int curent = 0, precedent = 0;

                int n = secventa.ToString().Length;

                int schimbari = 0;

                for (int i = 0; i < n; i++)
                {
                    curent = secventa % 10;
                    precedent = (secventa / 10) % 10;
                    int urmator = (secventa / 100) % 10;

                    if ((curent < precedent && curent > urmator) || (curent > precedent && curent < urmator))
                        schimbari++;

                    secventa /= 10;
                }

                if (schimbari > 2)
                    return false;

                if (schimbari == 2)
                {
                    int prima = secventa % 10;
                    int ultima = curent;

                    int aDoua = (secventa / 10) % 10;
                    int penultima = precedent;

                    if ((prima < ultima && aDoua < prima && penultima < ultima) || (prima > ultima && aDoua > prima && penultima > ultima))
                        return false;
                }

                return true;
            }
        }
    }
}
