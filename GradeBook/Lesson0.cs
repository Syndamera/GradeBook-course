using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    class Lesson0
    {
        float[] numbers = new float[3];
        float result = 0;

        List<float> grades = new List<float>();


        public void Test()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = 1.5f;
                result += numbers[i];
            }

            Console.WriteLine(result);

            grades.Add(2.4f);
            grades.Add(4.4f);
            grades.Add(7.4f);
            result = 0;
            foreach (var grade in grades)
            {
                result += grade;
            }

            float average = result / grades.Count;

            Console.WriteLine(result);
            Console.WriteLine($"Average grade is {average:N1}");


            /*if (args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello!");
            }*/
        }
    }
}
