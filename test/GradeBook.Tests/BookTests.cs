using System;
using Xunit;

namespace GradeBook.Tests
{
    public class UnitTest1
    {
        [Fact] // attribute , data attached to symbol that follows it i.e. Test1
        public void Test1()
        {
            //arrange
            var x = 5;
            var y = 2; 
            var expected = 7;
            //Act 
            var actual = x * y;
            //Assert
Assert.Equal(expected, actual);
        }
    }
}
