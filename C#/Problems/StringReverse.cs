using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Problems
{
    public static class StringReverse
    {
        public static void Run()
        {
            Debug.LineSplit();
            Debug.Write("Reverses a string");

            var Input = Debug.ReadInput("Enter a string to reverse (press enter for default): ");

            if (string.IsNullOrEmpty(Input))
                Input = "ReverseThisString";

            var CharArray = Input.ToCharArray();
            var Reversed = CharArray.Reverse().ToArray();

            Debug.Result($"{new string(Reversed)}");
            
        }
    }
}
