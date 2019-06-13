using System;
using System.Linq;
using static System.Console;
using static System.Convert;
using System.Collections.Generic;

namespace FundamentalsOfCsharpTest2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            WriteLine("Which of your friends liked your post?");
            WriteLine(FacebookLikes(ReadLine()));

            WriteLine("Identify yourself.");
            WriteLine($"Your name backwards is {ReverseString(ReadLine())}");

            WriteLine(UniqueNums());
            WriteLine(OrderNums());

            WriteLine("Enter 5 #s:");
            WriteLine(SmallestNums());
        }

        private static string FacebookLikes(string input)
        {
            var friends = new List<string>();
            while (input != "")
            {
                friends.Add(input);
                WriteLine("Anyone else?");
                input = ReadLine();
            }
            switch (friends.Count)
            {
                case 0: return "Nobody likes you or your post.";
                case 1: return $"{friends[0]} liked your post";
                case 2: return $"{friends[0]} and {friends[1]} liked your post";
                default: return $"{friends[0]}, {friends[1]} and others liked your post";
            }
        }

        private static string ReverseString(string name)
        {
            string nameReversed = "";
            char[] nameArray = name.ToCharArray();
            for (int i = nameArray.Length - 1; i >= 0; i--)
                nameReversed += nameArray[i];
            return nameReversed;
        }

        private static int[] UniqueNums()
        {
            int i = 0;
            int[] numbers = new int[5];
            do
            {
                try
                {
                    WriteLine($"Enter new integer {i + 1}");
                    int input = ToInt32(ReadLine());
                    if (!Array.Exists(numbers, value => value == input))
                    {
                        numbers[i] = input;
                        i++;
                    }
                    else WriteLine("Number already entered.");
                }
                catch
                {
                    WriteLine("Not an integer.");
                }
            } while (i < 5);
            Array.Sort(numbers);
            return numbers;
        }

        private static string OrderNums()
        {
            string input = "";
            var numbers = new List<string>();
            var display = new List<string>();
            do
            {
                WriteLine("Enter a number or 'Quit':");
                input = ReadLine();
                if (int.TryParse(input, out int n)) numbers.Add(input);
                else if (input != "Quit") WriteLine("I said number.");
            } while (input != "Quit");
            foreach (string number in numbers)
                if (!display.Contains(number)) display.Add(number);
            return string.Join(",", display);
        }

        private static string SmallestNums()
        {
            var intList = new List<int>();
            var lowThree = new List<int>();
            while (lowThree.Count < 3)
            {
                char[] inputArray = ReadLine().Trim().ToCharArray();
                if (inputArray.Length == 5)
                {
                    foreach (char c in inputArray) intList.Add(ToInt32(c.ToString()));
                    while (lowThree.Count < 3)
                    {
                        int min = intList.Min();
                        lowThree.Add(min);
                        intList.Remove(min);
                    }
                }
                else WriteLine("I said 5 #s!");
            }
            return "Lowest three #s: " + string.Join(", ", lowThree.ToArray());
        }
    }
}



