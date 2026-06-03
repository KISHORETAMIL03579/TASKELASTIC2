namespace DOMAIN.Entities
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string User { get; set; }
        public string Content { get; set; }
    }
}
