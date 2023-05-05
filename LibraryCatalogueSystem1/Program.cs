namespace LibraryCatalogueSystem1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Days of our Youth", "J. rolands", 12345, true);
            Book books = new Book(" Youth", "k. Holands", 454645, false);

            Catalogue catalogue = new Catalogue();
            User user1 = new User();

            catalogue.AddBook(book1);
            catalogue.AddBook(books);

            Console.WriteLine("Books Available");
            catalogue.GetAvailableBook();
            
            Console.WriteLine();
            Console.WriteLine("Books checked out already");
            catalogue.GetCheckedOutBooks();
        Console.WriteLine();
            user1.CheckOutBook(books);
        }
    }
}