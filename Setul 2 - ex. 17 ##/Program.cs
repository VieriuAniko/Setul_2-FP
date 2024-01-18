namespace Setul_2___ex._17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa.
            //Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor.
            //De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta.

            string s = "01001011"; //secventa citita

            Stack<int> stack = new Stack<int>();

            int level = 0, maxLevel = 0;
            bool isCorrect = true;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '0')
                {
                    stack.Push(i);
                    level++;

                    if (level > maxLevel)
                        maxLevel = level;
                }
                else if (s[i] == '1')
                {
                    if (stack.Count == 0)
                    {
                        isCorrect = false;
                        break;
                    }
                    else
                    {
                        int j = stack.Pop();
                        if (s[j] != '0')
                        {
                            isCorrect = false;
                            break;
                        }
                        else
                            level--;
                    }
                }
            }

            if (stack.Count > 0)
                isCorrect = false;

            if (isCorrect)
                Console.WriteLine($"Secventa este corecta si are nivelul maxim de incuibare {maxLevel}");
            else
                Console.WriteLine("Secventa este incorecta");
        }
    }
}
