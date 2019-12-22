using System;
using System.Collections.Generic;

namespace GradeBook
{

   public class Book  // public je je ovde access modifier koji je potreban da bi moglo da se testira.
    {
        public Book(string name) {
            grades = new List<double>();
            this.name = name; // sa this name kazemo da je to objekat i da name posle znaka jednako ide iz parametra funkcije 
        } 
        
        public void AddGrade (double grade) { // AddGrade je instanca member klase Book
            grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
                foreach(var grade in grades)
                {   
                    result.Low = Math.Min(grade, result.Low);
                    result.High = Math.Max(grade, result.High);
                   
                    result.Average += grade;
                }
                result.Average /= grades.Count;
                
                return result;
        }

        // nije bas jasan deo nalazi se u tutorijalu classes and objects 
        private List<double> grades;
        private string name;
    }


// push from Desktop 
/*

*/
} 