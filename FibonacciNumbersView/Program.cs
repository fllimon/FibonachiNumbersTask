using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FibonachiNumbersLib;

namespace FibonacciNumbersView
{
    class Program
    {
        static void Main(string[] args)
        {
            FibonacciNumber numbers = new FibonacciNumber(200, 2500);

            foreach (int item in numbers)
            {
                Console.Write($"{item}, ");
            }

            Console.ReadKey();
        }
    }
}
