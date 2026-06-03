using APPLICATION.DTO;
namespace APPLICATION.Interfaces
{
    public interface IAuthorService
    {
        Task<AuthorDTO> GetById(Guid id);

        Task<List<AuthorDTO>> GetAll();

        Task<Guid> Create(CreateAuthorDTO dto);

        Task<bool> Patch(Guid id, PatchAuthorDTO dto);

        Task<bool> Delete(Guid id);

        Task<List<AuthorDTO>> Search(string query);
    }
}
