using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę całkowitą: ");

            var number = GetNumber();

            typeNumber(number);
        }

        private static void typeNumber(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Liczba jest Parzysta");
            }
            else
            {
                Console.WriteLine("Liczba jest Nieparzysta");
            }
        }

        private static int GetNumber()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int validateNumber) || validateNumber <= 0)
                {
                    Console.WriteLine("Błędna liczba");
                    continue;

                }

                return validateNumber;
            }

        }
    }
}
