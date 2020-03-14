using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Follow
{
    class Easy
    {
        //Create a function that returns true if an input string contains only uppercase or only lowercase letters.
        public static bool UpperLower(String UpLow)
        {
            return UpLow == UpLow.ToUpper() | UpLow == UpLow.ToLower();
        }

        // Create a function that removes the first and last characters from a string.
        public static string RemoveFirstLast(string Str)
        {
            if (Str.Length <= 2)
                return Str;
            else
                return Str.Substring(1, Str.Length - 2);
        }

        //Create a function that takes a string and returns 
        //a string in which each character is repeated once.

        public static string DoubleChar(String Str)
        {
            string newstr = "";
            foreach (char s in Str)
            {
                newstr = Str.ToString() + Str.ToString();
            }
            return newstr;
        }

        //Create a function that repeats each character in a string n times.
        public static string Repeat(string strone, int n)
        {
            String res = "";
            foreach (char c in strone)
            {
                for (int i = 0; i < n; i++)
                {
                    res += c;
                }
            }
            return res;
        }

        // Create a function that takes a string as its argument and returns the string in reversed order.
        public static string ReverseVal(String RevMd)
        {
            return string.Concat(RevMd.Reverse());
        }

        //Write a program to count how many numbers between 1 and 100 are 
        //divisible by 3 with no remainder.Display the count on the console.

        public static void divisible(int num)
        {
            int newnum = 0;
            for (int i = 1; i<=num; i++)
            {
                if (i % 3 == 0)
                {
                    newnum++;

                }
            }
            Console.WriteLine("There are {0} number in 100", newnum);
        }

        // Create a function that returns true if an input string contains
        // only upper case or only lowercase letters.
        public static bool Uplower(string UpLow)
        {
            return UpLow == UpLow.ToUpper() | UpLow == UpLow.ToLower();
        }
        
        // create a function that takes a word and returns true if the word
        // has two consecutive identical letters.

        public static bool dbllettter(string word)
        {
            for (int i = 1; word.Length >i; i++)
            {
                if (word [i] == word[i - 1])
                {
                    return true;
                }
            }
            return false;
        }

    }
}


