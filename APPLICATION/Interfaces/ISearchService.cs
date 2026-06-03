using APPLICATION.DTO;
namespace APPLICATION.Interfaces
{
    public interface ISearchService
    {
        Task<List<BookDTO>> SearchBooks(string query);

        Task<List<UserDTO>> SearchUsers(string query);

        Task<List<AuthorDTO>> SearchAuthors(string query);

        Task<List<CategoryDTO>> SearchCategories(string query);

        Task<List<ReviewDTO>> SearchReviews(string query);
    }
}
