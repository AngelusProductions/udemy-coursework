using System;
using System.IO;
using static System.Math;
using static System.Console;
using static System.Convert;
using static System.IO.File;
using static System.IO.Directory;

namespace FundamentalsOfCsharpTest4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            WriteLine("What's the name of your file?");
            WriteLine($"\nYour file says:\n\n{CreateAndReadTextFile(ReadLine())}");
        }

        public static string CreateAndReadTextFile (string input)
        {
            Random random = new Random();
            string newPath = $"{GetCurrentDirectory()}/{input}.txt", randomText = "";
            for (int i = 0; i < random.Next(50); i++)
            {
                char chr = ToChar(ToInt32(Floor((26 * random.NextDouble()) + 65)));
                randomText += chr;
            }
            using (StreamWriter text = AppendText(newPath))
                text.WriteLine(randomText);
            return $"{ReadAllText(newPath)}\n\n{LongestWord(newPath)}";
        }

        public static string LongestWord (string input)
        {
            string longest = "";
            string[] textArray = ReadAllText(input).Split('\n');
            foreach (string word in textArray)
                if (word.Length > longest.Length) longest = word;
            return $"The longest word is: {longest}.";
        }
    }
}
