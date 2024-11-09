using Encapsulation2.Models;

namespace Encapsulation2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(1,"Pride and Prejudice",25,"Romance");
            Book book2 = new Book(2, "Invisible Man", 15, "Fiction");
            Book book3 = new Book(3, "Atomic Habits", 10, "NonFiction");

            Library library = new Library();

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            Book wantedBook = library.GetBookById(11);
            
            if (wantedBook != null)
            {
                Console.WriteLine(wantedBook.Name);

            }
            else
            {
                Console.WriteLine("The book is not found!");
            }



            Book wantedBook2 = library.GetBookByName("Invi");

            if (wantedBook2 != null)
            {
                Console.WriteLine(wantedBook2.Name);
            }
            else
            {
                Console.WriteLine("The book is not found!");
            }


            

            Book[] wantedBooks = library.GetFilteredBooks("Fic");


            if (wantedBooks != null)
            {
                foreach (var book in wantedBooks)
                {

                    Console.WriteLine(book.Name);
                }

            }
            else
            {
                Console.WriteLine("The book is not found!");
            }



            Book[] wantedBooks2 = library.GetFilteredBooks(10, 20);



            if (wantedBooks2 != null)
            {
                foreach (Book book in wantedBooks2)
                {
                    Console.WriteLine(book);
                }
            }
            else
            {
                Console.WriteLine("The book is not found!");
            }
            

        }
    }
}
