namespace Models
{
    public class Review
    {
        public Review(int id, Account account, Book book, int rating)
        {
            Id = id;
            Account = account;
            Book = book;
            Rating = rating;
        }

        public int Id { get; set; }
        public Account? Account { get; }
        public Book Book { get; }
        public int Rating { get; set; }
    }
}
