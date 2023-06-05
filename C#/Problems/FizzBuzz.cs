using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Problems
{
    public static class FizzBuzz
    {
        public static void Run()
        {
            Debug.LineSplit();
            Debug.Write("Executes fizzbuzz!");

            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) Debug.Result("FizzBuzz"); // Divisble by 3 and 5
                else if (i % 3 == 0) Debug.Result("Fizz"); // Divisible only by 3
                else if (i % 5 == 0) Debug.Result("Buzz"); // Divisible only by 5
                else Debug.Result($"{i}"); // Any other number 
            }

            Debug.Result("Complete!");
        }
    }
}
