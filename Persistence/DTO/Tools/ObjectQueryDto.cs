namespace PaginationDemo.Persistence.DTO.Tools
{
    public class ObjectQueryDto
    {
        public string SortBy { get; set; }
        public bool IsSortDescending { get; set; }
        public int Page { get; set; }
        public byte PageSize { get; set; }
    }
}