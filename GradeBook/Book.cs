using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        // fields
        private List<float> grades;
        public string Name;

        // contructor for the class, can not have a return value.
        public Book(string name) 
        {
            grades = new List<float>();
            Name = name;
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();

            result.Low = float.MaxValue;
            result.High = float.MinValue;
            result.Average = 0;

            foreach (var grade in grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }

            result.Average /= grades.Count;
            return result;
        }

        public bool AddGrade(float grade)
        {
            if(grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
                return true;
            }
            else
            {
                Console.WriteLine("Error invalid value: " + grade);
                return false;
            }
        }
    }
}
