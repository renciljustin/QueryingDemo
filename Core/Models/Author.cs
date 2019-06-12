using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PaginationDemo.Core.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}