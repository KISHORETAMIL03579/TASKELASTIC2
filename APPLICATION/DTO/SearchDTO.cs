using System;
using System.Collections.Generic;
using System.Text;

namespace APPLICATION.DTO
{
    public class SearchResponseDTO<T>
    {
        public List<T> Results { get; set; }
    }
}
