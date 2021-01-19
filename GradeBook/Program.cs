using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Jocke");
            book.AddGrade(24.5f);
            book.AddGrade(12.8f);
            book.AddGrade(55.5f);
            
            book.AddGrade(101);
            book.AddGrade(-1.5f);

            var result = book.GetStatistics();

            Console.WriteLine($"Lowest grade is {result.Low}");
            Console.WriteLine($"Higest grade is {result.High}");
            Console.WriteLine($"Average grade is {result.Average:N1}");
        }
    }
}
