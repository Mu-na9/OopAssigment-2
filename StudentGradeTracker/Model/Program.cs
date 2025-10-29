namespace StudentGradeTracker.Model
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  STUDENT GRADE TRACKING SYSTEM");
     

            Student student1 = new Student("Muna ", "S1");
            Student student2 = new Student("Atsloom ", "S2");
            Student student3 = new Student("Ahmed ", "S3");

            Console.WriteLine("Adding grades for Muna : ");
            student1.AddGrade(85);
            student1.AddGrade(92);
            student1.AddGrade(78);
            student1.AddGrade(88);

            Console.WriteLine("\nAdding grades for Atsloom: ");
            student2.AddGrade(90);
            student2.AddGrade(88);
            student2.AddGrade(92);
            student2.AddGrade(87);
            student2.AddGrade(91);

            Console.WriteLine("\nAdding grades for Ahmed: ");
            student3.AddGrade(65);
            student3.AddGrade(72);
            student3.AddGrade(68);
            student3.AddGrade(70);

            Console.WriteLine("      STUDENT REPORTS");
      

            student1.PrintStudentReport();
            student2.PrintStudentReport();
            student3.PrintStudentReport();

            Console.WriteLine("\n Program completed! ");
            Console.ReadKey();


        }
    }
}
