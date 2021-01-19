using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculateStatistics()
        {
            // arrange
            Book book = new Book("");
            book.AddGrade(89.1f);
            book.AddGrade(90.5f);
            book.AddGrade(77.3f);

            // act
            var result = book.GetStatistics();

            // assert
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);
        }
    }
}
