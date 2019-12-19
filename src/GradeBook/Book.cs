using System;
using System.Collections.Generic;

namespace GradeBook
{

    class Book 
    {
        public Book(string name) {
            grades = new List<double>();
            this.name = name; // sa this name kazemo da je to objekat i da name posle znaka jednako ide iz parametra funkcije 
        } 
        
        public void AddGrade (double grade) { // AddGrade je instanca member klase Book
            grades.Add(grade);
        }

        public void ShowStatistic()
        {
            var result = 0.0;
                var highGrade = double.MinValue;
                var lowGrade = double.MaxValue;
                foreach(var number in grades)
                {   

                   highGrade = Math.Max(number, highGrade);
                   lowGrade = Math.Min(number, lowGrade);
                    result += number;
                }
                result /= grades.Count;
                Console.WriteLine($"The lowest grade is {lowGrade}");
                Console.WriteLine($"The average grade is {result:N1}");// formatiramo na jednu decimalu
                Console.WriteLine($"The higest grade is {highGrade}");
        }

        // nije bas jasan deo nalazi se u tutorijalu classes and objects 
        private List<double> grades;
        private string name;
    }


// push from Desktop 
/*

*/
} 