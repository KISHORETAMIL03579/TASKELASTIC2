namespace APPLICATION.DTO
{
    public class ReviewDTO
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }

        public UserShortDTO CreatedBy { get; set; }
        public BookShortDTO Book { get; set; }

        public ReviewDetailsDTO ReviewDetails { get; set; }
    }

    public class ReviewDetailsDTO
    {
        public int Likes { get; set; }
        public List<CommentDTO> Comments { get; set; }
    }

    public class CommentDTO
    {
        public Guid Id { get; set; }
        public string User { get; set; }
        public string Content { get; set; }
    }

    public class UserShortDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class CreateReviewDTO
    {
        public string Content { get; set; }
        public int Rating { get; set; }
        public Guid BookId { get; set; }
        public Guid UserId { get; set; }
    }

    public class PatchReviewDTO
    {
        public string? Content { get; set; }
        public int? Rating { get; set; }
    }

    public class PatchReviewDetailsDTO
    {
        public int? Likes { get; set; }
    }

}
