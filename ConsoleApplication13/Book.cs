using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
   public class Book
    {
        internal int ID;
        internal string name;
        internal string author;
        internal bool published;

        public Book(int ID, string name, string author, bool published) 
        {
            this.ID = ID;
            this.name = name;
            this.author = author;
            this.published = published;
        }

        public override string ToString()
        {

            return "\nName of book: " + name + "\nAuthor:" + author + "\nID: " + ID + "\nPublished:" + published;

        }

        




    }
}
