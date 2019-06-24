using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;

namespace StackDesigner
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Initialize();
            var input = string.Empty;
            while (input != "done")
            {
                WriteLine("options:\n\n" +
                	"push\npop\ndisplay\nclear\ndone\n");
                switch (ReadLine())
                {
                    case "push":
                        WriteLine("\npush what?");
                        stack.Push(ReadLine());
                        break;
                    case "pop":
                        WriteLine("\nhow many?");
                        var number = int.Parse(ReadLine());
                        WriteLine(stack.Pop(number));
                        break;
                    case "display":
                        WriteLine(stack.Display());
                        break;
                    case "clear":
                        WriteLine("\ncleared");
                        stack.Clear();
                        break;
                    case "done":
                        WriteLine("\nok bye");
                        input = "done";
                        break;
                    default:
                        WriteLine("\nwhat?");
                        break;
                }
            }
        }
    }

    public class Stack
    {
        private ArrayList _collection;

        public void Push(object o)
        {
            if (o == null)
                throw new InvalidOperationException();
            _collection.Add(o);
        }

        public string Pop(int i)
        {
            if (_collection.Count < i || i == 0)
                throw new InvalidOperationException();
            var output = string.Empty;
            for (int j = 0; j < i; j++)
            {
                output += $"{_collection[_collection.Count - 1]}\n";
                _collection.RemoveAt(_collection.Count - 1);
            }
            return output;
        }

        public string Display ()
        {
            var output = string.Empty;
            foreach (object o in _collection)
               output += $"\n{o.ToString()}";
            return output;
        }

        public void Initialize ()
        {
            var collection = new ArrayList
               { "Corey", new int[] { 7, 8, 9 }, true,
                  new List<DivideByZeroException>() };
            _collection = collection;
        }

        public void Clear() { _collection.Clear(); }
    }
}
