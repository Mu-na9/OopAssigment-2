using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeTracker.Model
{
    public class Student
    {
        public string Name;
        public string ID;
        private int[] grades;
        private int gradeCount;

        public Student(string name, string id)
        {
            Name = name;
            ID = id;
            grades = new int[10];
            gradeCount = 0;
        }

        public void AddGrade(int grade)
        {
            if (gradeCount < 10)
            {
                grades[gradeCount] = grade;
                gradeCount++;
                Console.WriteLine($" Grade {grade} added   for {Name}");
            }
            else
            {
                Console.WriteLine("Can't add more grades!");
            }
        }


        public double CalculateAverage()
        {
            if (gradeCount == 0)
            {
                return 0;
            }

            int sum = 0;
            for (int i = 0; i < gradeCount; i++)
            {
                sum += grades[i];
            }

            return (double)sum / gradeCount;
        }


        public void PrintStudentReport()
        {
            Console.WriteLine($" Student Report: {Name}");
            Console.WriteLine($" Student ID: {ID}");


            if (gradeCount == 0)
            {
                Console.WriteLine("No Grades! ");
            }
            else
            {
                Console.Write("Grades: ");
                for (int i = 0; i < gradeCount; i++)
                {
                    Console.Write(grades[i] + " ");
                }
                Console.WriteLine();

                double average = CalculateAverage();
                Console.WriteLine($"The Average : {average:F2}");

                // التقدير
                if (average >= 90)
                    Console.WriteLine(" Exelante A");
                else if (average >= 80)
                    Console.WriteLine(" Very Good B");
                else if (average >= 70)
                    Console.WriteLine(" Good  C");
                else if (average >= 60)
                    Console.WriteLine(" Weak D");
                else
                    Console.WriteLine("Fail F");
            }
        

        }
    }
}
