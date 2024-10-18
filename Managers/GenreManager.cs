using Models;

namespace Managers
{
    public class GenreManager : IGenreManager
    {
        private readonly List<Genre> _genres;

        public GenreManager()
        {
            _genres = [];
        }

        public void AddGenre(string name)
        {
            int id = _genres.Count + 1;
            _genres.Add(new Genre(id, name));
        }

        public Genre? GetGenre(int id)
        {
            id -= 1;
            return (id >= 0 && id < _genres.Count) ? _genres[id] : null;
        }

        public IEnumerable<Genre> GetGenres()
        {
            return _genres;
        }
    }
}
