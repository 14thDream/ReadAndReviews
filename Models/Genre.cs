namespace Models
{
    public class Genre
    {
        public Genre(int id, string name)
        {
            Id = id;
            Name = name;
        }

        private int Id { get; }
        private string Name { get; }
    }
}
