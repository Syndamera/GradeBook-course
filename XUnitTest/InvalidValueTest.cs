using Xunit;

namespace GradeBook.Tests
{
    public class InvalidValueTest
    {
        [Fact]
        public void InvalidValue()
        {
            // arrange
            Book book = new Book("");
            bool a = book.AddGrade(105.1f);
            bool b = book.AddGrade(90.5f);
            bool c = book.AddGrade(-77.3f);

            // act


            // assert
            Assert.False(a);
            Assert.True(b);
            Assert.False(c);
        }
    }
}
