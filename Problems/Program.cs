using System;

namespace Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(Prefix(text));
        }

        static string Prefix(string input)
        {
            if (input == null)
            {
                return null;
            } else {
                string result = "";
            int len = input.Length;
            int wordcount = input.Split(' ').Length - 1;

            result = $"{len},{wordcount}{input}";
            return result;
            }            
        }
    }
}
