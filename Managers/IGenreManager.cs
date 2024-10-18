using Models;

namespace Managers
{
    interface IGenreManager
    {
        void AddGenre(string name);
        Genre? GetGenre(int id);
    }
}
