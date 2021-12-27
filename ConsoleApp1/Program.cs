using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Reader|Writer example");

            var file = new Reader("contextExample.txt");

            var example = "Lorem ipsum dolor sit amet, consectetur adipiscing elit," +
                " sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";

            file.SaveContent(example);

            Console.WriteLine($"Is result is equal to source?\n {String.Equals(example, file.GetContent())}");


        }
    }
}