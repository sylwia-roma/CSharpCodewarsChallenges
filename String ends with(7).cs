using System;
using System.Collections.Generic;
using System.Text;

namespace CodewarsChallenges
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution("sumo", "omokok"));
        }

        public static bool Solution(string str, string ending)
        {
            return str.EndsWith(ending);
        }
    }
}
