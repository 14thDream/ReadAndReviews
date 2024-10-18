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

        private int Id { get; }
        private string Title { get; set; }
        private string Author { get; set; }
        private string? Summary { get; set; }
        private Genre Genre { get; }
    }
}
