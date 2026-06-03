using DOMAIN.Entities;
namespace APPLICATION.Interfaces
{
    public interface ISearchRepository
    {
        Task<List<Book>> SearchBooks(string query);

        Task<List<User>> SearchUsers(string query);

        Task<List<Author>> SearchAuthors(string query);

        Task<List<Category>> SearchCategories(string query);

        Task<List<Review>> SearchReviews(string query);
    }
}
