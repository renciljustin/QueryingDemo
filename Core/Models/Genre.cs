using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PaginationDemo.Core.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
    
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public ICollection<BookGenre> Books { get; set; }
    }
}