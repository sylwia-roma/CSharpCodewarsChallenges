// Complete the function that accepts a string parameter, and reverses each word in the string. All spaces in the string should be retained.

// Examples

// "This is an example!" ==> "sihT si na !elpmaxe"
// "double  spaces"      ==> "elbuod  secaps"

﻿using System;
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
