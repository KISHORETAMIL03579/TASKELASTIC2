using APPLICATION.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace APPLICATION.Interfaces
{
    public interface IUserService
    {
        Task<UserDTO> GetById(Guid id);

        Task<List<UserDTO>> GetAll();

        Task<Guid> Create(CreateUserDTO dto);

        Task<bool> Patch(Guid id, PatchUserDTO dto);

        Task<bool> Delete(Guid id);

        Task<List<UserDTO>> Search(string query);

        Task<List<BookDTO>> GetFavoriteBooks(Guid userId);

        Task<bool> AddFavoriteBook(Guid userId, Guid bookId);

        Task<bool> RemoveFavoriteBook(Guid userId, Guid bookId);
    }
}
