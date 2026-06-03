using APPLICATION.DTO;

namespace APPLICATION.Interfaces
{
    public interface IPublisherService
    {
        Task<PublisherDTO> GetById(Guid id);

        Task<List<PublisherDTO>> GetAll();

        Task<Guid> Create(CreatePublisherDTO dto);

        Task<bool> Patch(Guid id, PatchPublisherDTO dto);

        Task<bool> Delete(Guid id);

        Task<bool> AddBook(Guid publisherId, Guid bookId);

        Task<bool> RemoveBook(Guid publisherId, Guid bookId);
    }
}
