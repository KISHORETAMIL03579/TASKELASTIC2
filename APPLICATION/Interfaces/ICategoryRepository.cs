using DOMAIN.Entities;
namespace APPLICATION.Interfaces
{
    public interface ICategoryRepository
    {
        Task<Category> GetById(Guid id);

        Task<List<Category>> GetAll();

        Task<Guid> Create(Category category);

        Task<bool> Patch(Guid id, Dictionary<string, object> fields);

        Task<bool> Delete(Guid id);
    }
}
