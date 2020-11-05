using System;
using System.Security.Cryptography.X509Certificates;
using System.Linq;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {

        private readonly Book[] books = new[]
        {
            new Book(1, "ISBN 12345-12341", "Author#1", "Art Of Programming"),
            new Book(2, "ISBN 12345-12342", "Author#2",  "Refactoring"),
            new Book(3,  "ISBN 12345-12343", "Author#3", "C Programming Languare")
        };

        public Book[] GetAllByIsbn(string isbn)
        {
            throw new NotImplementedException();
        }

        public Book[] GetAllByTitleOrAuthor(string titlePart)
        {
            return books.Where(book => book.Title.Contains(titlePart)).ToArray();
        }
    }
}
