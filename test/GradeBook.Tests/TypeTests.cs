using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact] 
        public void Test1()
        {
            //arrange // Act
            var book1 = GetBook("Book 1");//new Book("");
          var book2 = GetBook("Book 2");
          
            //Assert
        Assert.Equal("Book 1", book1.Name);
        Assert.Equal("Book 2", book2.Name);
        }
        Book GetBook(string name) {
            return new Book(name)
        }
    }
}
