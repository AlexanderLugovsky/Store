using System;
using System.Security.Cryptography.X509Certificates;
using System.Linq;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {

        private readonly Book[] books = new[]
        {
            new Book(1, "ISBN 12345-12341", "Author#1", "Art Of Programming", "Описание 1", 11.11m),
            new Book(2, "ISBN 12345-12342", "Author#2",  "Refactoring", "Описание 2", 12.12m),
            new Book(3,  "ISBN 12345-12343", "Author#3", "C Programming Languare", "Описание 3", 13.13m)
        };

        public Book[] GetAllByIsbn(string isbn)
        {
            return books.Where(book => book.Isbn == isbn).ToArray();
        }

        public Book[] GetAllByTitleOrAuthor(string query)
        {
            return books.Where(book => book.Author.Contains(query)
                                    || book.Title.Contains(query))
                        .ToArray();
        }
        public Book GetById(int id)
        {
                return books.Single(book => book.Id == id);
        }
    }
}
