using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            // strings are a reference type aka class not a struct.
            string name = "Jocke";
            string upper = MakeUpperCase(name);

            Assert.Equal("Jocke", name);
            Assert.Equal("JOCKE", upper);
        }

        private string MakeUpperCase(string paramenter)
        {
            return paramenter.ToUpper();
        }

        [Fact]
        public void ValueTypesPassByValue()
        {
            int x = GetInt();
            SetInt(ref x);

            Assert.Equal(55, x);
        }

        private void SetInt(ref int x)
        {
            x = 55;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void PassByReference()
        {
            // arrange
            Book book1 = GetBook("Book 1");

            // act
            GetBookSetName(ref book1, "New Name"); // "out" pass by reference

            // assert
            Assert.Equal("New Name", book1.Name);
        }

        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void PassByValue()
        {
            // arrange
            Book book1 = GetBook("Book 1");

            // act
            GetBookSetName(book1, "New Name");

            // assert
            Assert.Equal("Book 1", book1.Name);
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
            book.Name = name; // local only as its a new instance of the book
        }

        [Fact]
        public void SetNameFromReference()
        {
            // arrange
            Book book1 = GetBook("Book 1");

            // act
            SetName(book1, "New Name");

            // assert
            Assert.Equal("New Name", book1.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void ReturnDifferentBookObjects()
        {
            // arrange
            Book book1 = GetBook("Book 1");
            Book book2 = GetBook("Book 2");

            // act

            // assert
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
        }

        [Fact]
        public void TwoBooksCanReferenceSameObject()
        {
            // arrange
            Book book1 = GetBook("Book 1");
            Book book2 = book1; // this is a pointer to book1 memory data

            // act

            // assert
            Assert.Same(book1, book2);
            Assert.True(ReferenceEquals(book1, book2));
        }

        private Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
