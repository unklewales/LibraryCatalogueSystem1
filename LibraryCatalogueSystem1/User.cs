using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCatalogueSystem1
{
    public class User
    {
        public String Name { get; set; }
        public string Email { get; set; }
        public IList<Book> CheckedOutBooks { get; set; }

        public User()
        {
            CheckedOutBooks = new List<Book>();
        }

        public void CheckOutBook(Book book)
        {
            if (book.CheckedOut == true)
            {
                Console.WriteLine("book already checked out");

                CheckedOutBooks.Add(book);
            }
            
        }
    }
}
