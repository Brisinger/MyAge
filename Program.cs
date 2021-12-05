using System;

namespace MyAge
{
    public class Program
    {
        public Program()
        {
        }

        public static void Main(string[] args)
        {
            Person shubhojit = new Shubhojit("Shubhojit", DateTime.Parse("28 Feb, 1989"));
            Console.WriteLine($"Age of Shubhojit is {shubhojit.Age}");
        }
    }
}
