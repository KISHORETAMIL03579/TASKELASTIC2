namespace APPLICATION.DTO
{
    public class AuthorDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public List<string> Awards { get; set; }
        public List<BookShortDTO> LatestBooks { get; set; }
    }

    public class CreateAuthorDTO
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public List<string> Awards { get; set; }
    }

    public class PatchAuthorDTO
    {
        public string? Name { get; set; }
        public int? Age { get; set; }
        public string? Gender { get; set; }
        public List<string>? Awards { get; set; }
    }
}
