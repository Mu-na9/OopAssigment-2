using OOPAssigment.Model;

namespace OOPAssigment.BookClassSysytem
{
    internal class Program
    {
        static void Main()
        {

           
            Console.WriteLine("WELCOME TO BOOK CLASS SYSTEM\n");

           
            Book book1 = new Book( "Heloo", "Mohamed ", 2008,"968-98754867");
            Book book2 = new Book( "The Programmer" , "Eng.saleh ", 2022,"968-4785854" );
            Book book3 = new Book( "Fashion Designer", "Muna", 2024, "968-8745874");

        
            Console.WriteLine(" Book 1:");
            book1.PrintBookInfo();

            Console.WriteLine("\n Book 2:");
            book2.PrintBookInfo();

            Console.WriteLine("\n Book 3:");
            book3.PrintBookInfo();

            Console.WriteLine("\n  CHECKING BOOK YEAR: ");
            Console.WriteLine(".-.-.-.-.-.-.-.-.-.-.-.-.-.");

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
