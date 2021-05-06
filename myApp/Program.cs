using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
                     Console.WriteLine("The current time is " + DateTime.Now);
                     if (args.Length > 0) {
Console.WriteLine($"Hello, {args[0]}! My name is C#");
                     } else {
                         Console.WriteLine("Hello, I am an else statement");
                     }
        }
    }
}
