namespace PaginationDemo.Core.Models.Tools
{
    public class ObjectQuery
    {
        public string SortBy { get; set; }
        public bool IsSortDescending { get; set; }
        public int Page { get; set; }
        public byte PageSize { get; set; }
    }
}