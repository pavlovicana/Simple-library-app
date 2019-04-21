using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    public class Library
    {
        public static Dictionary<int, Book> myDic = new Dictionary<int, Book>();


        public void AddBook(Book book)
        {

            if (!myDic.ContainsKey(book.ID))
            {
                myDic.Add(book.ID, book);
                //Console.WriteLine("The book is added.");
            }
            else
            {
                Console.WriteLine("\nBook with ID [{0} ", book.ID + "] is in the library.");
                Console.Write("Set new ID: ");
                int number = Convert.ToInt32(Console.ReadLine());

                while (number == book.ID)
                {

                    Console.Write("Set ID again: ");
                    number = Convert.ToInt32(Console.ReadLine());

                }
                if (number != book.ID)
                {
                    book.ID = number;
                    myDic.Add(book.ID, book);
                    Console.WriteLine(book);

                }
            }
        }

        public void DeleteBook(int ID)
        {
            if (myDic.ContainsKey(ID))
            {
                myDic.Remove(ID);
                Console.WriteLine("The book with {0} ID ", ID + " is deleted. ");

            }
            else
            {
                Console.WriteLine("The book with that ID doesn't exists.");
            }
        }

        public void Published()
        {
            int number = 0;
            foreach (Book k in myDic.Values)
            {
                if (k.published == true)
                {
                    number++;
                }

            }
            Console.WriteLine("Number of published books is: " + number);

        }

        public void NotPublished()
        {
            int index = 0;
            foreach (Book k in myDic.Values)
            {
                if (k.published == false)
                {
                    index++;
                }
            }
            Console.WriteLine("Number of books that has not published: " + index);

        }

        public List<Book> Do()
        {

            List<Book> ret = new List<Book>();
            Console.WriteLine("\n****LIST****");
            foreach (Book k in myDic.Values)
            {
                ret.Add(k);


                Console.Write("\nName:" + k.name + "\nAuthor:" + k.author + "\nID:" + k.ID + "\nPublished:" + k.published);
                Console.WriteLine();
            }

            var sorted = ret.OrderBy(x => x.ID);
            Console.WriteLine("\n***SORTED LIST***");
            foreach (Book b in sorted)
            {

                Console.Write("\nName:" + b.name + "\nAuthor:" + b.author + "\nID:" + b.ID + "\nPublished:" + b.published);
            }

            return ret;
        }

        public void ShowAllBooks()
        {
            Do();
        }



    }

       


                

    



        











    }

