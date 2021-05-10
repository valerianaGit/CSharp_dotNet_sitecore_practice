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
[Fact] 
        public void CSharpCanPassByReference()
        {
            //arrange 
            var book1 = GetBook("Book 1");
          //Act
          GetBookSetName(ref book1, "New Name"); // will change the name
          
            //Assert
    
       Assert.Equal("New Name", book1.Name);
        }
         private void GetBookSetName( ref Book book, string name) {
                  book = new Book(name); // create new value 
                  //book.Name = name; // not needed 
        }

        [Fact] 
        public void CSharpAlwaysPassesByValue()
        {
            //arrange 
            var book1 = GetBook("Book 1");
          //Act
          GetBookSetName(book1, "New Name"); 
          
            //Assert
       Assert.Equal("Book 1", book1.Name);
        }
        private void GetBookSetName(Book book, string name) {
                  book = new Book(name); // create new value 
                  //book.Name = name; // not needed 
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
