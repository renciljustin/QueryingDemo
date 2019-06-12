using System.Collections.Generic;

namespace PaginationDemo.Persistence.DTO
{
    public class BookListDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }

        public short YearReleased { get; set; }

        public string AuthorName { get; set; }

        public ICollection<string> GenreNames { get; set; }
    }
}