using Models;

namespace Managers.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetBooks();
        Book? GetBook(int id);
        void AddBook(Book book);
        Book? UpdateSummary(int id, string summary);
    }
}
