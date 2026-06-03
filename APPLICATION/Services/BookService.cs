using Application.Interfaces;
using APPLICATION.DTO;

namespace APPLICATION.Services;

public class BookService : IBookService
{
    public Task<Guid> Create(CreateBookDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Delete(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<BookDTO>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<BookDTO> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Patch(Guid id, PatchBookDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task<List<BookDTO>> Search(string query)
    {
        throw new NotImplementedException();
    }
}
