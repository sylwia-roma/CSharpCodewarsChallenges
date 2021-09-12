// Sum all the numbers of the array (in F# and Haskell you get a list) except the highest and the lowest element (the value, not the index!).
// (The highest/lowest element is respectively only one element at each edge, even if there are more than one with the same value!)

// Example:

// { 6, 2, 1, 8, 10 } => 16
// { 1, 1, 11, 2, 3 } => 6

// If array is empty, null or None, or if only 1 Element exists, return 0.
// Note:In C++ instead null an empty vector is used. In C there is no null. ;-)


// -- There's no null in Haskell, therefore Maybe [Int] is used. Nothing represents null.
// Have fun coding it and please don't forget to vote and rank this kata! :-)

// I have created other katas. Have a look if you like coding and challenges.

﻿using System;

namespace CodewarsChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = new int[] { 6, 2, 1, 8, 10 };
            Console.WriteLine(sum(integers));
        }

        public static int sum(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0 || numbers.Length == 1)
            {
                return 0;

            }

            int smallest = Int32.MaxValue;
            int biggest = Int32.MinValue;

            int sum = 0;
            int returnSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > biggest)
                {
                    biggest = numbers[i];
                }
                if (numbers[i] < smallest)
                {
                    smallest = numbers[i];
                }

                sum += numbers[i];
            }

            returnSum = sum - smallest - biggest;

            return returnSum;

            //return numbers == null || numbers.Length < 2? 0: numbers.Sum() - numbers.Max() - numbers.Min();
        }
    }
}
