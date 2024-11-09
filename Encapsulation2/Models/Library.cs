using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation2.Models
{
    public class Library
    {
        public Book[] Books = Array.Empty<Book>();

        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[^1] = book;
        }

        public Book GetBookById(int id)
        {
            foreach (Book book in Books)
            {

                if (book.Id == id) return book;
            }

            return null;
        }

        public Book GetBookByName(string name)
        {
            foreach (var book in Books)
            {
                if(book.Name.ToLower().Contains(name.ToLower())) return book;

            }
            return null;
        }

        public Book[] GetFilteredBooks(string genre)
        {
            Book[] wantedBooks = new Book[0];
            foreach (var book in Books)
            {
                if(book.Genre.ToLower().Contains(genre.ToLower()))
                {
                    Array.Resize(ref wantedBooks,wantedBooks.Length + 1);
                    wantedBooks[^1] = book;
                }
               
            }
            return wantedBooks;
        }

        public Book[] GetFilteredBooks(double minPrice, double maxPrice)
        {
            Book[] wantedBooks = new Book[0];
            foreach (Book book in Books)
            {
                double price = book.Price;
                if (minPrice <= price && price <= maxPrice)
                {
                    Array.Resize(ref wantedBooks, wantedBooks.Length + 1);
                    wantedBooks[^1] = book;
                }
            }
            return wantedBooks;

        }

    }
}
