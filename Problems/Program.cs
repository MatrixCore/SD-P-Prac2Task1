using System;

namespace Problems
{
    public class Program
    {
        static void Main(string[] args)
        {   
            Program test = new Program();
            string text = Console.ReadLine();
            Console.WriteLine(test.Prefix(text));
        }

        public string Prefix(string input)
        {
            return input == null ? null : $"{input.Length},{input.Split(' ',StringSplitOptions.RemoveEmptyEntries).Length}:{input}";
            //C# Tenary
        }
    }
}
