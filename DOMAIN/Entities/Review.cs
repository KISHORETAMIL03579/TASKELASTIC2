namespace DOMAIN.Entities
{
    public class Review
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
        public string CreatedById { get; set; }
        public User CreatedBy { get; set; }
        public string BookId { get; set; }
        public Book Book { get; set; }
        public ReviewDetails ReviewDetails { get; set; }
    }
}
