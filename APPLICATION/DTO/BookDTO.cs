namespace APPLICATION.DTO
{
    public class BookDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public AuthorDTO Author { get; set; }
        public CategoryDTO Category { get; set; }
        public PublisherDTO Publisher { get; set; }
        public double AverageRating { get; set; }
        public int TotalReviews { get; set; }
    }
    public class CreateBookDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Guid AuthorId { get; set; }
        public Guid CategoryId { get; set; }
        public Guid PublisherId { get; set; }
    }
    public class BookShortDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class PatchBookDTO
    {
        public string? Name { get; set; }
        public string? Description { get; set; }

        public Guid? AuthorId { get; set; }
        public Guid? CategoryId { get; set; }
        public Guid? PublisherId { get; set; }

        public bool? IsPublished { get; set; }
    }
}
