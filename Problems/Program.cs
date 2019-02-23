using System;

namespace Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public string Prefix(string input)
        {
            int length = input.Length;
            int wordcount = input.Split(' ').Length;

            return(length + "," + wordcount + ":" + input);
        }
    }
}
