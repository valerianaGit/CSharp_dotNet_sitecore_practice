using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {

        
        static void Main(string[] args)
        {









            // SYNTAX!
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
//or 
var numbersb = new[] {2.7, 13.4, 14.5, 8.9};
// Sum all items -> naive approach
var result  = numbers[0];
result += numbers[1];
result = result + numbers[2];
//for loop 
var resultF = 0.0;
foreach(double number in numbersb) {
resultF += number;
}
resultF /= numbersb.Length;
Console.WriteLine($" average grade for numbersb list: {resultF:N3}");

//COLLECTIONS
//LIST -> Mutable array 
List<double> grades = new List<double>(){12.7, 13.4, 14.5, 8.9}; //initializer is the curly braces {}
grades.Add(20.9); // add value to list 

//CLASSES AND OBJECTS 

var book = new Book("Valeria");
book.addGrade(20.5);
book.addGradesFrom(numbersa);
var stats = book.GetStatistics();
Console.WriteLine($"Average of grades {stats.Average}");
Console.WriteLine($"lowest grade {stats.Low}");
Console.WriteLine($"highest of grade {stats.High:N1}");

//             Console.WriteLine($"Summations of both float numbers is {summationOfFloats}");
//                      Console.WriteLine("The current time is " + DateTime.Now);
//                      if (args.Length > 0) {
// Console.WriteLine($"Hello, {args[0]}! My name is C#");
//                      } else {
//                          Console.WriteLine("Hello, I am an else statement");
//                      }
        }
    }
}
