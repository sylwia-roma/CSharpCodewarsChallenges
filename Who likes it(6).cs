﻿//You probably know the "like" system from Facebook and other pages. People can "like" blog posts, pictures or other items. We want to create the text that should be displayed next to such an item.

//Implement the function which takes an array containing the names of people that like an item. It must return the display text as shown in the examples:

//[]                                --> "no one likes this"
//["Peter"]-- > "Peter likes this"
//["Jacob", "Alex"]-- > "Jacob and Alex like this"
//["Max", "John", "Mark"]-- > "Max, John and Mark like this"
//["Alex", "Jacob", "Mark", "Max"]-- > "Alex, Jacob and 2 others like this"
//Note: For 4 or more names, the number in "and 2 others" simply increases.

using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        //public static string Likes(string[] names)
        //{
        //    switch (names.Length)
        //    {
        //        case 0: return "no one likes this"; // :(
        //        case 1: return $"{names[0]} likes this";
        //        case 2: return $"{names[0]} and {names[1]} like this";
        //        case 3: return $"{names[0]}, {names[1]} and {names[2]} like this";
        //        default: return $"{names[0]}, {names[1]} and {names.Length - 2} others like this";
        //    }
        //}

        public static String whoLikesIt(String[] names)
        {
            string who = "";
            int length = names.length - 2;


            if (names.Length < 1)
            {
                who = "no one likes this";
            }
            if (names.Length == 1)
            {
                who = names[0] + " likes this";
            }
            if (names.Length == 2)
            {
                who = names[0] + " and " + names[1] + " like this";
            }
            if (names.Length == 3)
            {
                who = names[0] + ", " + names[1] + " and " + names[2] + " like this";
            }
            if (names.Length >= 4)
            {
                who = names[0] + ", " + names[1] + " and " + length + " others like this";
            }

            return who;
        }
    }