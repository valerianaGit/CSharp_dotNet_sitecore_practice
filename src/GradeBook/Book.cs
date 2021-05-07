using System;
using System.Collections.Generic;
namespace GradeBook{
class Book {
static void methods() {

}
//CONSTRUCTOR TO Book 
private List<double> numbers; // = new List<double>() {45.6, 78.3};
private string name;
public Book (string name) {
    numbers = new List<double>();
    this.name = name;
}


public void addGrade (double number) {

    //validate the input 
    if (number > 0.0) {
numbers.Add(number);
Console.WriteLine($"grade added!: {number}");
    }

}
double result = 0.0;
double lowGrade = double.MaxValue; // so it is definetly larger than any number, that way we get the true min of the list 
double highGrade = double.MinValue; // so it is deifnetly smaller than whatever number we are comparing 
public void showStatistics(double[] numbers) {

    foreach(double number in numbers) {
lowGrade = Math.Min(number, lowGrade);
highGrade = Math.Max(number, highGrade);
result += number;
    }
    result /= numbers.Length;
    Console.WriteLine($"The lowest grade is {lowGrade}");
    Console.WriteLine($"The highest grade is {highGrade}");
    Console.WriteLine($"The average is {result}");
}

public void addGradesFrom(double[] numbers) {
foreach(double number in numbers ) {
this.numbers.Add(number);
}
Console.WriteLine($"new values in array {this.numbers}");
}

}
}