using System;
using System.Collections.Generic;
namespace GradeBook{
public class Book {

//CONSTRUCTOR TO Book 
private List<double> grades; // = new List<double>() {45.6, 78.3};
public string Name; // public memeber should have an upper case name 
public Book (string name) {
    grades = new List<double>();
    this.Name = name;
}

// methods 
public void addGrade (double number) {
    //validate the input 
    if (number > 0.0) {
grades.Add(number);
Console.WriteLine($"grade added!: {number}");
    }
}
// double result = 0.0;
// double lowGrade = double.MaxValue; // so it is definetly larger than any number, that way we get the true min of the list 
// double highGrade = double.MinValue; // so it is deifnetly smaller than whatever number we are comparing 
public Statistics GetStatistics() {
    var result = new Statistics();
result.Average = 0.0;
result.Low = double.MaxValue;
result.High = double.MinValue;
    foreach(double grade in grades) {
result.Low  = Math.Min(grade, result.Low);
result.High = Math.Max(grade, result.High);
result.Average += grade;
    }
     result.Average /= grades.Count;
     return result;
}

public void addGradesFrom(double[] numbers) {
foreach(double number in numbers ) {
this.grades.Add(number);
}
Console.WriteLine($"new values in array {this.grades}");
}

}
}