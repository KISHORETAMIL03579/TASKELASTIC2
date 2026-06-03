namespace DOMAIN.Entities;

public class Book
{
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Guid AuthorId { get; set; }
    public Author Author { get; set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
    public Guid PublisherId { get; set; }
    public Publisher Publisher { get; set; }
    public bool IsPublished { get; set; }
    public double AverageRating { get; set; }
    public int TotalReviews { get; set; }
}
