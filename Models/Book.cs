namespace Models
{
    public class Book
    {
        public Book(int id, string title, string author, Genre genre)
        {
            Id = id;
            Title = title;
            Author = author;
            Genre = genre;
        }

        public Book(int id, string title, string author, string summary, Genre genre) : this(id, title, author, genre)
        {
            Summary = summary;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string? Summary { get; set; }
        public Genre Genre { get; }
    }
}
