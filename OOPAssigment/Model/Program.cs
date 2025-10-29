using OOPAssigment.Model;

namespace OOPAssigment.BookClassSysytem
{
    internal class Program
    {
        static void Main()
        {

           
            Console.WriteLine("WELCOME TO BOOK CLASS SYSTEM\n");

           
            Book book1 = new Book( "Clean Code", "Robert C. Martin", 2008,"978-0132350884");
            Book book2 = new Book( "The Pragmatic Programmer" , "Andrew Hunt & David Thomas", 1999,"978-0201616224" );
            Book book3 = new Book( "Design Patterns", "Gang of Four", 1994, "978-0201633610");

        
            Console.WriteLine(" Book 1:");
            book1.PrintBookInfo();

            Console.WriteLine("\n Book 2:");
            book2.PrintBookInfo();

            Console.WriteLine("\n Book 3:");
            book3.PrintBookInfo();

            Console.WriteLine("\n  CHECKING BOOK YEAR: ");
            Console.WriteLine("─────────────────────────────────────");

            int checkYear = 2000;

            Console.WriteLine($"\n Checking if books are older than {checkYear}:\n");

            Console.WriteLine($"'{book1.title}'");
            Console.WriteLine($" Is older than {checkYear}? {book1.IsOlderThan(checkYear)}");

            Console.WriteLine($"\n'{book2.title}'");
            Console.WriteLine($" Is older than {checkYear}? {book2.IsOlderThan(checkYear)}");

            Console.WriteLine($"\n{book3.title}");
            Console.WriteLine($" Is older than {checkYear}? {book3.IsOlderThan(checkYear)}");

            Console.ReadKey();
        }



    }
}
