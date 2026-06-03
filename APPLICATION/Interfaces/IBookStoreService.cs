using APPLICATION.DTO;
namespace APPLICATION.Interfaces
{
    public interface IBookStoreService
    {
        Task<BookStoreDTO> GetById(Guid id);

        Task<List<BookStoreDTO>> GetAll();

        Task<Guid> Create(CreateBookStoreDTO dto);

        Task<bool> Patch(Guid id, PatchBookStoreDTO dto);

        Task<bool> Delete(Guid id);

        Task<bool> AddBook(Guid storeId, Guid bookId);

        Task<bool> RemoveBook(Guid storeId, Guid bookId);
    }
}
