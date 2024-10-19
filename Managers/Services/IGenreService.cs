using Models;

namespace Managers.Services
{
    public interface IGenreService
    {
        void AddGenre(string name);
        Genre? GetGenre(int id);
        IEnumerable<Genre> GetGenres();
    }
}
