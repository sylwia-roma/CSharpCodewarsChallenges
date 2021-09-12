//Make your strings more nerdy: Replace all 'a'/'A' with 4, 'e'/'E' with 3 and 'l' with 1 e.g. "Fundamentals" --> "Fund4m3nt41s"

﻿using System;
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
