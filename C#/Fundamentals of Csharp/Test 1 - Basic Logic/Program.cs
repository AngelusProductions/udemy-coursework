using System;
using System.Linq;
using System.Threading;
using static System.Console;
using static System.Convert;

namespace CSharpForBeginnersTest1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            WriteLine("Enter #");
            WriteLine(AboveTen(ToInt32(ReadLine())));

            WriteLine("Enter 1st #");
            int num1 = ToInt32(ReadLine());
            WriteLine("Enter 2nd #");
            int num2 = ToInt32(ReadLine());
            WriteLine($"Higher number is {HigherNum(num1, num2)}");

            WriteLine("Height?");
            int height = ToInt32(ReadLine());
            WriteLine("Width?");
            int width = ToInt32(ReadLine());
            WriteLine($"Orientation is {getOrientation(height, width)}");

            WriteLine("Speed Limit?");
            int limit = ToInt32(ReadLine());
            WriteLine("Speed?");
            int speed = ToInt32(ReadLine());
            WriteLine(Demerits(speed, limit));
        }

        public static string AboveTen (int num)
        {
            return num > 10 ? "Invalid" : "Valid";
        }

        public static int HigherNum (int num1, int num2)
        {
            return new int[] { num1, num2 }.Max();
        }

        public static string getOrientation (int height, int width)
        {
            return height > width ? "Portrait" : "Landscape";
        }

        public static string Demerits (int speed, int limit)
        {   
            if (speed < limit) return "All gucci!";
            int demerits = (int)Math.Round((double)(speed - limit) / 5);
            return $"Demerits: {demerits}. Licence suspended: {demerits > 12}.";
        }
    }
}