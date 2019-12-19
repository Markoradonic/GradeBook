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
                book.AddGrade(90.1);
                book.AddGrade(77.6);
                book.ShowStatistic();
                
            
                
                
        }
    }
}
