using DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace APPLICATION.Interfaces
{
    public interface IAuthorRepository
    {
        Task<Author> GetById(Guid id);

        Task<List<Author>> GetAll();

        Task<Guid> Create(Author author);

        Task<bool> Patch(Guid id, Dictionary<string, object> fields);

        Task<bool> Delete(Guid id);

        Task<List<Author>> Search(string query);
    }
}
