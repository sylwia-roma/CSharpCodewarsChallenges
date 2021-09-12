using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Ch4113ng3
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Nerdify("Los Angeles"));
        }

        public static string Nerdify(string str)
        {
            string newString = str.Replace("A", "4").Replace("a", "4").Replace("E", "3").Replace("e", "3").Replace("l", "1");
            return newString;
        }
    }
}
