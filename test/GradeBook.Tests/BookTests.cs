using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact] // attribute , data attached to symbol that follows it i.e. Test1
        // means this is a unit test
        public void Test1()
        {
            //arrange
            var book = new Book("");
            book.addGrade(89.1);
             book.addGrade(90.5);
              book.addGrade(77.3);
            //Act 
            var result = book.GetStatistics(); 

            //Assert
Assert.Equal(85.6, result.Average, 1);
Assert.Equal(77.3, result.Low, 1);
Assert.Equal(90.5, result.High, 1);
        }
    }
}
