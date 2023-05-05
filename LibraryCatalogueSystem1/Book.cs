using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCatalogueSystem1
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int ISBN { get; set; }
        public bool CheckedOut { get; set; }

        public Book(string title, string author, int iSBN, bool checkedOut)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            CheckedOut = checkedOut;
        }

        public override string ToString()
        {
            return $"Title:{Title}\nAuthor:{Author}\nISBN:{ISBN}\nChecked out or not:{CheckedOut}";
        }
    }
}
