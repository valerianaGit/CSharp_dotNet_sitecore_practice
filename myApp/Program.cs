using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 34.12;
            // add 2 floats and print the result 
            float float1 = 35.25f;
            float float2 = 3.45F;
            float summationOfFloats = float1 + float2;
//Arrays
        //    Create => 
        double[] numbers = new double[3];
//Access => 
double first = numbers[0] = 12.7;
numbers[1] = 13.4;
numbers[2] = 14.5;

//Array implementation
 double[] numbersa = new double[] {12.7, 13.4, 14.5, 8.9};

// Sum all items -> naive approach
var result  = numbers[0];
result = result + numbers[1];
result = result + numbers[2];
                     Console.WriteLine("The current time is " + DateTime.Now);
                     if (args.Length > 0) {
Console.WriteLine($"Hello, {args[0]}! My name is C#");
                     } else {
                         Console.WriteLine("Hello, I am an else statement");
                     }
        }
    }
}
