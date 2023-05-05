using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCatalogueSystem1
{
    public class Catalogue
    {
        public IList<Book> books { get; set; }
        public Catalogue()
        {
           books = new List<Book>();    
        }

        public void AddBook(Book book)
        {
            books.Add(book);    
        }

        public void RemoveBook(Book book) 
        { 
            books.Remove(book);
        }

        public void GetAvailableBook() 
        {
            foreach (var item in books)
            {

                if (item.CheckedOut == true)
                {
                        Console.WriteLine(item);
                }
            }
        
        }

       
        public void GetCheckedOutBooks()
        {
            foreach (var item in books)
            {
                if (item.CheckedOut == true)
                {
                    Console.WriteLine($"{item.Title}\n{item.Author}\n{item.ISBN}");
                }

            }
        }
    }
}
