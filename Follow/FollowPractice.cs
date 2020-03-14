using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Follow
{
    class FollowPractice
    {
        //Create a function that returns true if a string contains any spaces.
        public static bool AnySpace(String Str)
        {
            if(Str.Contains(" "))
            {
                return true;
            }
            return false;
        }

        //Create a function that accepts an array and returns the last item in the array.
        //The array can contain any of C#'s primitive data types.
        public static object GetLastItem(object [] arr)
        {
            return arr.Last();
        }

        //Create a function that takes in a word and determines whether or not it is plural. 
        //A plural word is one that ends in "s".
        public static bool IsSingular(string str)
        {
            if (str.EndsWith("s"))
            {
                return true;
            }
            return false;
        }

        // Write a function that validates whether two strings are identical.Make it case insensitive.
        public static bool Identical(string a, string b)
        {
            if (string.Equals(a, b))
            {
                return true;
            }
            return false;
        }

        // Create a function that takes an array of numbers. Return the largest number in the array.
        public static object LargeInArray(object [] arr)
        {
            return arr.Max();
        }

        // Create a function that takes a number as an argument and returns the amount of digits it has.
        public static int Digits(int Digit)
        {
            return Digit.ToString().Length;
        }
    }
}
