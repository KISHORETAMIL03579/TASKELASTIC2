using DOMAIN.Entities;
namespace APPLICATION.Interfaces
{
    public interface IPublisherRepository
    {
        Task<Publisher> GetById(Guid id);

        Task<List<Publisher>> GetAll();

        Task<Guid> Create(Publisher publisher);

        Task<bool> Patch(Guid id, Dictionary<string, object> fields);

        Task<bool> Delete(Guid id);
    }
}
