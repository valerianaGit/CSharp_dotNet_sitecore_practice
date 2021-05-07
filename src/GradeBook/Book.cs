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

public void addGradesFrom(double[] numbers) {
foreach(double number in numbers ) {
this.numbers.Add(number);
}
Console.WriteLine($"new values in array {this.numbers}");
}

}
}