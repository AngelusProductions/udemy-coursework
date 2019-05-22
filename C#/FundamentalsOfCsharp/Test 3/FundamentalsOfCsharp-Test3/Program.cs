using System;
using System.Collections.Generic;
using System.Linq;

namespace FundamentalsOfCsharpTest3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Consecutive();
            Duplicates();
            GoodTimes();
            Pascal();
            Vowels();
        }

        public static void Consecutive()
        {
            Console.WriteLine("Enter #s with dash delimiter:");
            string input = Console.ReadLine();
            string[] numberArray = input.Split('-');
            Array.Sort(numberArray);
            bool consecutive = true;
            int i = 0;
            if (numberArray.Length > 0)
                foreach (string number in numberArray)
                {
                    consecutive &= i >= numberArray.Length - 1
                    || Convert.ToInt32(number) == Convert.ToInt32(numberArray[i + 1]) - 1;
                    i++;
                }
            Console.WriteLine("Consecutive? ..." + consecutive);
        }

        public static void Duplicates()
        {
            Console.WriteLine("Enter #s with dash delimiter:");
            string input = Console.ReadLine();
            string[] numberArray = input.Split('-');
            Array.Sort(numberArray);
            var library = new List<string>();
            var duplicates = new List<string>();
            if (numberArray.Length > 0)
                foreach (string number in numberArray)
                    if (library.Contains(number)
                        && !duplicates.Contains(number))
                        duplicates.Add(number);
                    else
                        library.Add(number);
            Console.WriteLine("Duplicates: " + String.Join(", ", duplicates));
        }

        public static void GoodTimes()
        {
            bool valid = true;
            Console.WriteLine("Enter time in international format:");
            string input = Console.ReadLine();
            string[] inputArray = input.Split(':');
            if (input.Length != 5
             || input.Substring(2, 1) != ":"
             || !int.TryParse(input.Replace(":", ""), out _)
             || !Enumerable.Range(0, 24).Contains(Convert.ToInt32(inputArray[0]))
             || !Enumerable.Range(0, 60).Contains(Convert.ToInt32(inputArray[1]))
             ) valid = false;
            Console.WriteLine("Valid? ..." + valid);
        }

        public static void Pascal()
        {
            Console.WriteLine("Enter a a few words:");
            string input = Console.ReadLine().ToLower();
            string[] wordArray = input.Split(' ');
            string output = "";
            foreach (string word in wordArray)
                output += word.Substring(0,1).ToUpper() + word.Remove(0, 1);
            Console.WriteLine(output);
        }

        public static void Vowels()
        {
            Console.WriteLine("Enter something:");
            string input = Console.ReadLine().ToLower();
            char[] inputArray = input.ToCharArray();
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int count = 0;
            foreach(char letter in inputArray)
                if (vowels.Contains(letter))
                    count++;
            Console.WriteLine(count + " vowels");
        }

    }
}
