using System;

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
