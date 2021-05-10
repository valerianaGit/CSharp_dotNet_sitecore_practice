using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {

    [Fact] 
        public void PassByReferenceWillBeChanged()
        {
            //arrange
            var x = GetInt();
             //Act
        SetInt(ref x);         
            //Assert   
       Assert.Equal(42, x);
        }
         private void SetInt( ref int x) {
                 x = 42;
        }
        [Fact] 
        public void valueTypesinCSharp()
        {
            //arrange //Act
        var x = GetInt();         
            //Assert   
       Assert.Equal(3, x);
        }
         private int GetInt( ) {
                 return 3;
        }
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
