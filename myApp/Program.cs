using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 34.12;
                     Console.WriteLine("The current time is " + DateTime.Now);
                     if (args.Length > 0) {
Console.WriteLine($"Hello, {args[0]}! My name is C#");
                     } else {
                         Console.WriteLine("Hello, I am an else statement");
                     }
        }
    }
}
