namespace DOMAIN.Entities
{
    public class BookStore
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public List<Book> Books { get; set; } = new();
    }
}
