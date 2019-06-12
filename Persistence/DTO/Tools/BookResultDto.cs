using System.Collections.Generic;
using PaginationDemo.Core.Models;

namespace PaginationDemo.Persistence.DTO.Tools
{
    public class BookResultDto
    {
        public IEnumerable<BookListDto> Books { get; set; }
        public int TotalCount { get; set; }
    }
}