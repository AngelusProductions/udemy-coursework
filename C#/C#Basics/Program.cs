using System;
using System.Linq;

namespace CSharpForBeginnersTest1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Valid();
            MaxNum();
            Orientation();
            Speeding();
        }

        public static void Valid ()
        {
            Console.WriteLine("Enter #");
            string input = Console.ReadLine();
            int inputNum = Convert.ToInt32(input);
            if (inputNum > 10)
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                Console.WriteLine("Valid");
            }
        }

        public static void MaxNum ()
        {
            Console.WriteLine("Enter 1st #");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd #");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int[] nums = { num1, num2 };
            Console.WriteLine($"Higher Number: {nums.Max()}");
        }

        public static void Orientation ()
        {
            Console.WriteLine("Height?");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Width?");
            int w = Convert.ToInt32(Console.ReadLine());
            if (h > w)
            {
                Console.WriteLine("Portrait");
            }
            else
            {
                Console.WriteLine("Landscape");
            }
        }

        public static void Speeding ()
        {
            Console.WriteLine("Speed Limit?");
            int limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Speed?");
            int speed = Convert.ToInt32(Console.ReadLine());
            if (speed < limit)
            {
                Console.WriteLine("All gucci");
            }
            else
            {
                int difference = speed - limit;
                double mod5 = difference / 5;
                int demerits = Convert.ToInt32(Math.Round(mod5));
                Console.WriteLine($"{demerits} demerits.");
                if (demerits > 12)
                {
                    Console.WriteLine("License suspended.");
                }
            }
            

        }
    }
}
