using System.Collections.Generic;

namespace PaginationDemo.Core.Models.Tools
{
    public class BookResult
    {
        public IEnumerable<Book> Books { get; set; }
        public int TotalCount { get; set; }
    }
}