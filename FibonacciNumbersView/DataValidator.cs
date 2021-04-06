using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbersView
{
    class DataValidator
    {
        public bool GetNumber(int startRange, int finishRange)
        {
            bool isOk = true;

            try
            {
                if (IsOddValue(startRange, finishRange))
                {
                    return isOk = false;
                }

                return isOk;
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Incorrect parameters! {ex.Message}");

                return isOk = false;
            }
        }

        public bool IsOddValue(int startRange, int finishRange)
        {
            return ((startRange < 0) && (finishRange < 0));
        }
    }
}
