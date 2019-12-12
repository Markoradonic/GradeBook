using System.Collections.Generic;

namespace GradeBook
{

    class Book 
    {
        public Book(string name) {
            grades = new List<double>();
            this.name = name;
        }
        
        public void AddGrade (double grade) {
            grades.Add(grade);
        }
        // nije bas jasan deo nalazi se u tutorijalu classes and objects 
        private List<double> grades;
        private string name;
    }


// push from Desktop 
} 