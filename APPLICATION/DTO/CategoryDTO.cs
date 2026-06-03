namespace APPLICATION.DTO
{
    public class CategoryDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class CreateCategoryDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class PatchCategoryDTO
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
