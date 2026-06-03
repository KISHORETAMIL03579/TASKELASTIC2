namespace APPLICATION.DTO
{
    public class UserDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public List<BookShortDTO> FavoriteBooks { get; set; }
        public int TotalReviews { get; set; }
    }

    public class PatchUserDTO
    {
        public string? Name { get; set; }
        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }
        public int? Age { get; set; }
    }

    public class CreateUserDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
    }

}
