using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PaginationDemo.Core.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public short YearReleased { get; set; }

        [Required]
        public int AuthorId { get; set; }

        public Author Author { get; set; }
        
        public ICollection<BookGenre> Genres { get; set; }
    }
}