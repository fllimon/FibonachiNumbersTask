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
            try
            {
                DataValidator validator = new DataValidator();

                bool result = validator.GetNumber(DataConvertor.ConvertData(args[0]), DataConvertor.ConvertData(args[1]));

                if (result)
                {
                    FibonacciNumber numbers = new FibonacciNumber(DataConvertor.ConvertData(args[0]),
                                                                  DataConvertor.ConvertData(args[1]));

                    foreach (int item in numbers)
                    {
                        Console.Write($"{item}, ");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
