using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Problems
{
    public static class CharacterCount
    {
        public static void Run(string Text = "feeeedddmmee", string CorrectResult = "f1e4d3m2e2")
        {
            Debug.LineSplit();
            Debug.Write("Takes an input and returns the number of characters. For example, 'feeedmee' becomes 'f1e3d1m1e2.");

            var Input = Debug.ReadInput("Enter a string to test (press enter for default): ");
            var Output = Debug.ReadInput("Enter the expected result (press enter for default): ");

            if (!string.IsNullOrEmpty(Input) && !string.IsNullOrEmpty(Output))
            {
                Text = Input;
                CorrectResult = Output;
            }

            // Convert to lower case
            Text = Text.ToLower();
            CorrectResult = CorrectResult.ToLower();

            // First, convert the line to a charArray 
            var Line = Text.ToCharArray();
            // String termination
            char Current = '\0';
            // Holds the count
            int Count = 0;
            // The end result
            string Result = string.Empty;

            // Loop through each char in Line
            foreach (char c in Line)
            {
                // If the current char 'C' doesn't match the Current...
                if (c != Current)
                {
                    if (Count > 0) // And the Count is greater than 0 (it exists, and there is more than 0)
                    {
                        Result += $"{Current}{Count}"; // Add to the result - get current count & add the current letter that we are counting
                    }

                    Current = c; // Set the current letter to current char we are on
                    Count = 1; // Reset the count

                }
                else // If it is a match, add to the count.
                {
                    Count++;
                }
            }

            if (Count > 0) // If the result is greater than 0, update the result
            {
                Result += $"{Current}{Count}";
            }


            if (Result.Equals(CorrectResult))
            {
                Debug.Result("The input matches the expected output.");
            } else
            {
                Debug.Result("The output does not match!");
            }
            Debug.Result($"{Result} = {CorrectResult}");
        }
    }
}
