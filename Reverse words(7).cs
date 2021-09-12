using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseWords("de ef rge"));
        }

        public static string ReverseWords(string original)
        {
           string result = string.Join(" ", original.Split(' ').Select(x => new string(x.Reverse().ToArray())));
            return result;
        }
    }
}
