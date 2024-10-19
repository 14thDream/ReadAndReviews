using System.Text.Json.Serialization;

namespace Models
{
    public class Book
    {
        public Book(int id, string title, string author, int genreId)
        {
            Id = id;
            Title = title;
            Author = author;
            GenreId = genreId;
        }

        [JsonConstructor]
        public Book(int id, string title, string author, string summary, int genreId) : this(id, title, author, genreId)
        {
            Summary = summary;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string? Summary { get; set; }
        public int GenreId { get; }
        private Genre Genre { get; }
    }
}
