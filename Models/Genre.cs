namespace Models
{
    public class Genre
    {
        public Genre(string name)
        {
            Id = 0;
            Name = name;
        }

        private int Id { get; }
        private string Name { get; }
    }
}
