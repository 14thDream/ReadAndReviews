using Models;

namespace Managers.Services
{
    public interface IGenreManager
    {
        void AddGenre(string name);
        Genre? GetGenre(int id);
        IEnumerable<Genre> GetGenres();
    }
}
