using System;
using System.Collections.Generic;
using System.Threading;
using static System.Console;

namespace Stopwatch
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            string input = string.Empty;
            while (input != "end")
            {
                WriteLine("options: 'start', 'stop', 'list' or 'end'\n");
                input = ReadLine();
                switch (input)
                {
                    case "start":
                        if (!stopwatch.running) stopwatch.Start();
                        else throw new InvalidOperationException();
                        WriteLine($"\nSTART: {DateTime.Now.ToShortTimeString()}\n");
                        break;
                    case "stop":
                        if (stopwatch.running) stopwatch.Stop();
                        else throw new InvalidOperationException();
                        WriteLine($"\nSTOP: {DateTime.Now.ToShortTimeString()}\n");
                        Thread.Sleep(500);
                        WriteLine("calculating...\n");
                        Thread.Sleep(500);
                        WriteLine($"TIME: {stopwatch.Calculate(stopwatch.start, stopwatch.stop)} seconds\n");
                        break;
                    case "list":
                        WriteLine($"\nTIMES:\n\n{stopwatch.List()}");
                        break;
                    case "end":
                        WriteLine("\nending...\n");
                        Thread.Sleep(500);
                        WriteLine($"FINAL TIMES:\n{stopwatch.List()}");
                        Thread.Sleep(500);
                        break;
                    default:
                        WriteLine("\ninvalid entry...\n");
                        Thread.Sleep(500);
                        break;
                }
                Thread.Sleep(250);
            }
        }

        public class Stopwatch
        {
            public bool running;
            public DateTime start;
            public DateTime stop;
            public List<double> times = new List<double>();

            public DateTime Start()
            {
                running = true;
                start = DateTime.Now;
                return start;
            }

            public DateTime Stop()
            {
                running = false;
                stop = DateTime.Now;
                return stop;
            }

            public double Calculate(DateTime start, DateTime stop)
            {
                double newTime = (stop - start).TotalSeconds;
                times.Add(newTime);
                return newTime;
            } 

            public string List()
            {
                string output = string.Empty;
                foreach (double time in this.times)
                    output += time + " secs\n";
                return output;
            }
        }

    }
}
