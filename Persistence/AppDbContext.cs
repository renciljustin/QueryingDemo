using System.Linq;
using Microsoft.EntityFrameworkCore;
using PaginationDemo.Core.Models;

namespace PaginationDemo.Persistence
{
    public class AppDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        
        public AppDbContext(DbContextOptions<AppDbContext> opt): base(opt)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<BookGenre>()
                .HasKey(bg => new { bg.BookId, bg.GenreId });

            builder.Entity<BookGenre>()
                .HasOne(bg => bg.Book)
                .WithMany(b => b.Genres);

            builder.Entity<BookGenre>()
                .HasOne(bg => bg.Genre)
                .WithMany(g => g.Books);

            foreach (var property in builder.Model.GetEntityTypes()
                .SelectMany(t => t.GetProperties())
                .Where(p => p.ClrType == typeof(decimal)))
            {
                property.Relational().ColumnType = "decimal(18, 6)";
            }
        }
    }
}