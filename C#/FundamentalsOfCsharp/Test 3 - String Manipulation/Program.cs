using System;
using System.Linq;
using System.Collections.Generic;
using static System.Console;
using static System.Convert;
using static System.Linq.Enumerable;

namespace FundamentalsOfCsharpTest3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            WriteLine("Enter #s with dash delimiter:");
            WriteLine($"Consecutive: {Consecutive(ReadLine())}");

            WriteLine("Enter #s with dash delimiter:");
            WriteLine($"Duplicates: {Duplicates(ReadLine())}");

            WriteLine("Enter time in international format:");
            WriteLine($"Valid: {GoodTimes(ReadLine())}");

            WriteLine("Enter a few words:");
            WriteLine($"Pascal Casing: {Pascal(ReadLine())}");

            WriteLine("Enter another few words:");
            WriteLine($"Vowels: {Vowels(ReadLine())}");
        }

        public static bool Consecutive(string input)
        {
            int i = 0;
            bool consecutive = true;
            string[] numArray = input.Split('-');
            Array.Sort(numArray);
            if (numArray.Length > 0)
                foreach (string num in numArray)
                {
                    consecutive &= i >= numArray.Length - 1
                    || ToInt32(num) == ToInt32(numArray[i + 1]) - 1;
                    i++;
                }
            return consecutive;
        }

        public static string Duplicates(string input)
        {
            string[] numArray = input.Split('-');
            Array.Sort(numArray);
            List<string> library = new List<string>();
            List<string> duplicates = new List<string>();
            if (numArray.Length > 0)
                foreach (string num in numArray)
                    if (library.Contains(num) && !duplicates.Contains(num)) duplicates.Add(num);
                    else library.Add(num);
            return duplicates.Count > 0 ? string.Join(", ", duplicates) : "None";
        }

        public static string GoodTimes(string input)
        {
            bool valid = true;
            if (input.Length != 5
             || input.Substring(2, 1) != ":"
             || !int.TryParse(input.Replace(":", ""), out _)
             || !Range(0, 24).Contains(ToInt32(input.Split(':')[0]))
             || !Range(0, 60).Contains(ToInt32(input.Split(':')[1]))
             ) valid = false;
            return valid ? "Yup" : "Nah";
        }

        public static string Pascal(string input)
        {
            string output = "";
            foreach (string word in input.ToLower().Split(' '))
                output += word.Substring(0, 1).ToUpper() + word.Remove(0, 1);
            return output;
        }

        public static int Vowels(string input)
        {
            int count = 0;
            char[] inputToArray = input.ToLower().ToCharArray(),
                   vowels = { 'a', 'e', 'i', 'o', 'u' };
            foreach (char letter in inputToArray)
                if (vowels.Contains(letter)) count++;
            return count;
        }
    }
}
