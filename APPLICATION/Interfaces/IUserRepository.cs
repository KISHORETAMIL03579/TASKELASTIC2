
using DOMAIN.Entities;

namespace APPLICATION.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetById(Guid id);

        Task<List<User>> GetAll();

        Task<Guid> Create(User user);

        Task<bool> Patch(Guid id, Dictionary<string, object> fields);

        Task<bool> Delete(Guid id);

        Task<List<User>> Search(string query);
    }
}
