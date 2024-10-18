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

        private int Id { get; }
        private Account? Account { get; }
        private Book Book { get; }
        private int Rating { get; set; }
    }
}
