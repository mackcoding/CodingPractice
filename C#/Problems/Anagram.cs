﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Problems
{
    public static class Anagram
    {
        public static void Run()
        {
            bool IsAnagram = false;
            Debug.LineSplit();
            Debug.Write("Checks if words are anagrams");

            var Input1 = Debug.ReadInput("Enter the first word (enter for default): ");
            var Input2 = Debug.ReadInput("Enter the second word (enter for default): ");

            if (string.IsNullOrEmpty(Input1) && string.IsNullOrEmpty(Input2))
            {
                Input1 = "Listen";
                Input2 = "Silent";
            }

            // Make everything lower case
            Input1 = Input1.ToLower();
            Input2 = Input2.ToLower();

            // If the input is the same, it could be an anagram
            if (Input1.Length.Equals(Input2.Length))
            {
                // Sort the inputs
                var Input1Sorted = new string(Input1.OrderBy(x=>x).ToArray()); 
                var Input2Sorted = new string(Input2.OrderBy(x => x).ToArray());

                // If the arrays match each other, they are anagrams. Otherwise, they are not
                if (Input1Sorted.Equals(Input2Sorted)) IsAnagram = true;
                else IsAnagram = false;
            }
            else IsAnagram = false; // Not similar; so false.

            Debug.Result($"{Input1} and {Input2} are anagrams: {IsAnagram}");
            
        }
    }
}