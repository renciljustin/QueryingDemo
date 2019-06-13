namespace PaginationDemo.Persistence.DTO.Tools
{
    public class BookQueryDto: ObjectQueryDto
    {
        public string SearchKey { get; set; }
        public int? AuthorId { get; set; }
        public int? GenreId { get; set; }
    }
}