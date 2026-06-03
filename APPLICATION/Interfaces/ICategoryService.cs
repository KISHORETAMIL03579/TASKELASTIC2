using APPLICATION.DTO;
namespace APPLICATION.Interfaces
{
    public interface ICategoryService
    {
        Task<CategoryDTO> GetById(Guid id);

        Task<List<CategoryDTO>> GetAll();

        Task<Guid> Create(CreateCategoryDTO dto);

        Task<bool> Patch(Guid id, PatchCategoryDTO dto);

        Task<bool> Delete(Guid id);
    }
}
