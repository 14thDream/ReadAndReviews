using Managers.Services;
using Models;

namespace Managers
{
    public class BookManager : IBookService
    {
        private readonly List<Book> _books;

        public BookManager()
        {
            _books = [];
        }

        public void AddBook(Book book)
        {
            book.Id = _books.Count + 1;
            _books.Add(book);
        }

        public Book? GetBook(int id)
        {
            return (id >= 0 && id < _books.Count) ? _books[id] : null;
        }

        public IEnumerable<Book> GetBooks()
        {
            return _books;
        }

        public Book? UpdateSummary(int id, string summary)
        {
            if (id < 0 || id >= _books.Count) return null;

            _books[id].Summary = summary;
            return _books[id];
        }
    }
}
