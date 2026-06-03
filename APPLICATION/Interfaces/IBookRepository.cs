using DOMAIN.Entities;

namespace APPLICATION.Interfaces
{
    public interface IBookRepository
    {
        Task<Book> GetById(Guid id);

        Task<List<Book>> GetAll();

        Task<Guid> Create(Book book);

        Task<bool> Patch(Guid id, Dictionary<string, object> fields);

        Task<bool> Delete(Guid id);

        Task<List<Book>> Search(string query);
    }
}
