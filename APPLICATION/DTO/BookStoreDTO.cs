using System;
using System.Collections.Generic;
using System.Text;

namespace APPLICATION.DTO
{
    public class BookStoreDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public List<BookShortDTO> Books { get; set; }
    }

    public class CreateBookStoreDTO
    {
        public string Name { get; set; }
        public string Location { get; set; }
    }

    public class PatchBookStoreDTO
    {
        public string? Name { get; set; }
        public string? Location { get; set; }
    }
}
