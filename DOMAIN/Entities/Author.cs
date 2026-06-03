namespace DOMAIN.Entities
{
    public class Author
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public List<string> Awards { get; set; } = new();
        public int TotalPublished { get; set; }
        public double AverageRating { get; set; }
        public List<Book> LatestBooks { get; set; } = new();
    }
}
