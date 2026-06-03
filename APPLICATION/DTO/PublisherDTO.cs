namespace APPLICATION.DTO
{
    public class PublisherDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public List<BookShortDTO> Books { get; set; }
    }

    public class CreatePublisherDTO
    {
        public string Name { get; set; }
        public string Location { get; set; }
    }

    public class PatchPublisherDTO
    {
        public string? Name { get; set; }
        public string? Location { get; set; }
    }
}
