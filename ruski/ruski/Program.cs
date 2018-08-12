using System;

namespace ruski
{
    class Program
    {
        public static int RussBauerMultiplikation(int faktor1, int faktor2)
        {
            int ergebnis = 0;
            if((faktor1 % 2) == 0)
            {
                ;
            }
            else
            {
                ergebnis = faktor2;
            }
                
            while(faktor1 > 1)
            {
                faktor1 /= 2;
                faktor2 *= 2;
                if (faktor1 % 2 == 0)
                {
                    ;
                }
                else
                {
                    ergebnis += faktor2;
                }
                    
            }
            return ergebnis;
        }

        static void Main(string[] args)
        {
            int x = RussBauerMultiplikation(47, 42);
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
