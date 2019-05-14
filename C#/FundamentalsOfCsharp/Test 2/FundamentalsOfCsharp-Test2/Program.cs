using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics;

namespace FundamentalsOfCsharpTest2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Facebook();
            Reverse();
            Unique();
            Order();
            Smallest();
            System.Threading.Thread.Sleep(2000);
        }

        private static void Facebook()
        {
            Console.WriteLine("Friend who like?");
            var friends = new List<string>();
            var userInput = Console.ReadLine();

            while (userInput != "")
            {
                friends.Add(userInput);
                Console.WriteLine("Friend who like?");
                userInput = Console.ReadLine();
            }

            switch (friends.Count)
            {
                case (0):
                    Console.WriteLine("loserface!");
                    break;
                case (1):
                    Console.WriteLine(String.Format("{0} liked your post", friends[0]));
                    break;
                case (2):
                    Console.WriteLine(String.Format("{0} and {1} liked your post", friends[0], friends[1]));
                    break;
                default:
                    Console.WriteLine(String.Format("{0}, {1} and others liked your post", friends[0], friends[1]));
                    break;
            }
        }

        private static void Reverse()
        {
            Console.WriteLine("Yo what's ur name?");
            var name = Console.ReadLine();
            char[] nameArray = name.ToCharArray();
            for (int i = nameArray.Length - 1; i >= 0; i--)
                Console.Write(nameArray[i]);
            Console.WriteLine();
        }

        private static void Unique()
        {
            int i = 0;
            int[] numbers = new int[5];
            do
            {
                try
                {
                    Console.WriteLine("Enter integer {0}", i + 1);
                    var input = Console.ReadLine();
                    numbers[i] = Int32.Parse(input);
                    i++;
                }
                catch
                {
                    Console.WriteLine("Dummy!");
                }

            } while (i < 5);
            Array.Sort(numbers);
            foreach (int number in numbers)
                Console.Write(number);
            Console.WriteLine();
        }


        private static void Order()
        {
            var input = "";
            var numbers = new List<string>();
            do
            {
                Console.WriteLine("Enter a number or 'Quit':");
                input = Console.ReadLine();
                if (int.TryParse(input, out int n))
                    numbers.Add(input);
                else if (input != "Quit")
                    Console.WriteLine("A number, dummy.");
            } while (input != "Quit");
            var display = new List<string>();
            foreach (string number in numbers)
                if (!display.Contains(number))
                    display.Add(number);
            Console.WriteLine(String.Join(",", display));
        }

        private static void Smallest()
        {
            var stringList = new List<int>();
            var numberList = new List<int>();
            var lowThree = new List<int>();

            while (lowThree.Count < 3)
            {
                Console.WriteLine("Enter 5 numbers:");
                string input = Console.ReadLine();
                string stringStripped = input.Trim();
                var stringArray = stringStripped.Split(',');

                if (stringArray.Length < 5)
                    Console.WriteLine("Need more numbers!");
                else
                {
                    foreach (var str in stringArray)
                        numberList.Add(int.Parse(str));
                    while (lowThree.Count < 3)
                    {
                        var min = numberList.Min();
                        lowThree.Add(min);
                        numberList.Remove(min);
                    }
                    Console.WriteLine("Lowest three #s: " + String.Join(", ", lowThree.ToArray()));
                }
            }
        }
    }
}



