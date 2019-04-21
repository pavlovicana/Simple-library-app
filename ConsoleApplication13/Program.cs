using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book_1 = new Book(8, "Slika Dorijana Greja", "Oskar Vajld", true);
            Book book_2 = new Book(2, "Dama s Kamelijama", "Aleksandar Dima", false);
            Book book_3 = new Book(2, "Central Park", "Gijom Muso", false);
            Book book_4 = new Book(7, "Stranac", "Albert Kami", true);


            Library library = new Library();

            library.AddBook(book_1);
            Console.WriteLine(book_1);

            library.AddBook(book_2);
            Console.WriteLine(book_2);
            Console.WriteLine();

            library.AddBook(book_3);
            Console.WriteLine(book_3);
            Console.WriteLine();

            library.AddBook(book_4);
            Console.WriteLine(book_4);
            Console.WriteLine();

            library.DeleteBook(8);
            Console.WriteLine();

            library.Published();
            Console.WriteLine();

            library.NotPublished();
            Console.WriteLine();

            library.ShowAllBooks();
            Console.WriteLine();

            library.Published();
            Console.WriteLine();

            library.NotPublished();
            Console.WriteLine();


            Console.ReadLine();



        }
    }
}
