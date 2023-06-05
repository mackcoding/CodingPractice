using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Problems
{
    public static class Atoi
    {
        public static void Run()
        {
            Debug.LineSplit();
            Debug.Write("Converts a string to an int, without using standard libraries.");

            string Input = Debug.ReadInput("Enter a string to convert (press enter for default): ");

            if (string.IsNullOrEmpty(Input))
            {
                Input = "1337";
            }

            int Result = 0;

            // Loop through all chars and update result;
            // take ascii character of corresponding digit
            // and subtract the code from 0 to get numerical value
            // multiply result by 10 to shuffle digits left to update
            // total
            for (int i = 0; i < Input.Length; i++)
                Result = Result * 10 + Input[i] - '0';

            Debug.Result($"{Result}");
        }
    }
}
