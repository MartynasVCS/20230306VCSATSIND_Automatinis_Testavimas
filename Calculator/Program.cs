using System;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (Sandauga(5,5) == 25)
            {
                Console.WriteLine("Veikia!");
            }
            else
            {
                Console.WriteLine("Klaida!");
            }
        }

        public static double Dalyba(int skaicius1, int skaicius2)
        {
            return (double)skaicius1 / skaicius2;
        }

        public static int Sandauga(int skaicius1, int skaicius2)
        {
            return skaicius1 * skaicius2;
        }

        public static int Skirtumas(int skaicius1, int skaicius2)
        {
            return skaicius1 - skaicius2;
        }

        public static int Suma(int skaicius1, int skaicius2)
        {
            return skaicius1 + skaicius2;
        }
    }
}
