using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
                var book = new Book("Scott's grades book");
                book.AddGrade(89.1);
                book.AddGrade(90.5);
                book.AddGrade(77.3);

                var stats = book.GetStatistics();

                Console.WriteLine($"The lowest grade is {stats.Low}");
                Console.WriteLine($"The average grade is {stats.Average:N1}");// formatiramo na jednu decimalu
                Console.WriteLine($"The higest grade is {stats.High}");

                
            
                
                
        }
    }
}
