﻿using System;
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

            string risultato = Convert.ToString(value, 16);

            Console.WriteLine($"il numero {value} convertito in base 16 diventa {risultato}");

            string risultato2 = Convert.ToString(value, 8);

            Console.WriteLine($"il numero {value} convertito in base 8 diventa {risultato2}");

            Console.WriteLine("ciao");

            Console.ReadLine();
        }
    }
}
