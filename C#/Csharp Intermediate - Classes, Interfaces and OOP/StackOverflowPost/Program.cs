using System;
using System.Threading;
using System.Collections.Generic;
using static System.Console;

namespace StackOverflowPost
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            WriteLine("what's your problem?");
            string title = ReadLine();
            WriteLine("dang. that stinks. tell me more:");
            string description = ReadLine();
            WriteLine("jeez. can you show me a code snippet?");
            string askSnippet = ReadLine();

            var post = new Post(title, description);
            if (new List<string> { "yes", "yea", "yeah", "y" }
                .Contains(askSnippet.ToLower()))
            {
                WriteLine("ok. hit me:");
                post.Code = ReadLine();
            }

            WriteLine("okeday, here's your post:");
            WriteLine(post.Display());

            Thread.Sleep(1000);
            Write(".");
            Thread.Sleep(500);
            Write(".");
            Thread.Sleep(500);
            Write(".");
            Thread.Sleep(1000);

            var random = new Random();
            WriteLine("\n\nwow look at your vote count now!");
            for (int i = 0; i < 100; i++) post.Vote(random.Next(-1, 2));
            WriteLine($"\nVote: {post.Votes}");
        }

        public class Post
        {
            private readonly DateTime _timestamp;
            private readonly string _title, _description;

            public Post(string title, string description)
            {
                _title = title;
                _description = description;
                _timestamp = DateTime.Now;
            }

            public int Votes { get; private set; } = 0;
            public string Code { private get; set; } = string.Empty;
            public void Vote(int direction) { Votes += direction; }

            public string Display()
            {
                string body = $"\n{_title.ToUpper()}\n\n{_description}";
                if (Code.Length > 0) body += $"\n[{Code}]";
                return $"{body}\n\n{_timestamp.ToShortDateString()}\nVote: {Votes}\n";
            }
        }
    }
}
