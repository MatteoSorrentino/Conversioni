using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 0;

            Console.WriteLine("inserisci un numero da convertire a base 2");

            value = Convert.ToInt32(Console.ReadLine());

            string binary = Convert.ToString(value, 2);

            Console.WriteLine($"il numero {value} convertito in base 2 diventa {binary}");

            Console.ReadLine();
        }
    }
}
