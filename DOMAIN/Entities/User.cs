namespace DOMAIN.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public List<Book> FavoriteBooks { get; set; } = new();
        public int TotalReviews { get; set; }
        public double AverageRating { get; set; }
    }
}
