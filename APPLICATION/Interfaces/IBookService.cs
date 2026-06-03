using APPLICATION.DTO;

namespace Application.Interfaces
{
    public interface IBookService
    {
        Task<BookDTO> GetById(Guid id);

        Task<List<BookDTO>> GetAll();

        Task<Guid> Create(CreateBookDTO dto);

        Task<bool> Patch(Guid id, PatchBookDTO dto);

        Task<bool> Delete(Guid id);

        Task<List<BookDTO>> Search(string query);
    }
}
