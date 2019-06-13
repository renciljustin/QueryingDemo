namespace PaginationDemo.Core.Models.Tools
{
    public class BookQuery: ObjectQuery
    {
        public string SearchKey { get; set; }
        public int? AuthorId { get; set; }
        public int? GenreId { get; set; }
    }
}