using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeTracker.Model
{
    public class Student
    {
        public  string name;
        public  string id;
        public  int[] grades;
        public  int gradeCount;

        public Student( string name, string id)
        {
            this.name = name;
            this.id = id;
            this.grades = new int[100];
            this.gradeCount = 0;
        }
        public Student() 
        { 
        
        
        }    

    }
}
