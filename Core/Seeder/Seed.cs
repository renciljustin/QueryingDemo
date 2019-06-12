using System.Collections.Generic;
using System.Linq;
using PaginationDemo.Core.Models;
using PaginationDemo.Persistence;

namespace PaginationDemo.Core.Seeder
{
    public class Seed
    {
        private readonly AppDbContext _context;
        public Seed(AppDbContext context)
        {
            _context = context;
        }

        public void BeginSeeding()
        {
            SeedAuthor();
            SeedGenres();
            SeedBooks();
        }

        private void SeedAuthor()
        {
            if (_context.Authors.Count() == 0)
            {
                var authors = new List<Author>()
                {
                    new Author { Name = "J.K. Rowling" },
                    new Author { Name = "Stephenie Meyer" },
                    new Author { Name = "Suzanne Collins" }
                };

                _context.Authors.AddRange(authors);
                _context.SaveChanges();
            }
        }

        private void SeedGenres()
        {
            if (_context.Genres.Count() == 0)
            {
                var genres = new List<Genre>()
                {
                    new Genre { Name = "Action" },
                    new Genre { Name = "Adventure" },
                    new Genre { Name = "Fantasy" },
                    new Genre { Name = "Romance" },
                    new Genre { Name = "Comedy" },
                    new Genre { Name = "Horror" },
                    new Genre { Name = "Sci-Fi"},
                    new Genre { Name = "Mistery" }
                };

                _context.Genres.AddRange(genres);
                _context.SaveChanges();
            }
        }

        private void SeedBooks()
        {
            if (_context.Books.Count() == 0)
            {
                var books = new List<Book>()
                {
                    new Book
                    {
                        Title = "Harry Potter: Sorcerer's Stone", 
                        Price = 2250,
                        YearReleased = 1997,
                        AuthorId = _context.Authors.SingleOrDefault(a => a.Name == "J.K. Rowling").Id,
                        Genres = new List<BookGenre>
                        {
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Adventure").Id },
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Action").Id },
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Fantasy").Id }
                        }
                    },
                    new Book
                    {
                        Title = "Harry Potter: Chamber of Secrets", 
                        Price = 2250,
                        YearReleased = 1998,
                        AuthorId = _context.Authors.SingleOrDefault(a => a.Name == "J.K. Rowling").Id,
                        Genres = new List<BookGenre>
                        {
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Adventure").Id },
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Action").Id },
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Fantasy").Id }
                        }
                    },
                    new Book
                    {
                        Title = "Harry Potter: Prisoner of Azkaban", 
                        Price = 2250,
                        YearReleased = 1999,
                        AuthorId = _context.Authors.SingleOrDefault(a => a.Name == "J.K. Rowling").Id,
                        Genres = new List<BookGenre>
                        {
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Adventure").Id },
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Action").Id },
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Fantasy").Id }
                        }
                    },
                    new Book
                    {
                        Title = "Harry Potter: Goblet of Fire", 
                        Price = 2250,
                        YearReleased = 2000,
                        AuthorId = _context.Authors.SingleOrDefault(a => a.Name == "J.K. Rowling").Id,
                        Genres = new List<BookGenre>
                        {
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Adventure").Id },
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Action").Id },
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Fantasy").Id }
                        }
                    },
                    new Book
                    {
                        Title = "Harry Potter: Order of the Phoenix", 
                        Price = 2250,
                        YearReleased = 2003,
                        AuthorId = _context.Authors.SingleOrDefault(a => a.Name == "J.K. Rowling").Id,
                        Genres = new List<BookGenre>
                        {
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Adventure").Id },
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Action").Id },
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Fantasy").Id }
                        }
                    },
                    new Book
                    {
                        Title = "Harry Potter: Half-Blood Prince", 
                        Price = 2250,
                        YearReleased = 2005,
                        AuthorId = _context.Authors.SingleOrDefault(a => a.Name == "J.K. Rowling").Id,
                        Genres = new List<BookGenre>
                        {
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Adventure").Id },
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Action").Id },
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Fantasy").Id }
                        }
                    },
                    new Book
                    {
                        Title = "Harry Potter: Death Hollows", 
                        Price = 2250,
                        YearReleased = 2007,
                        AuthorId = _context.Authors.SingleOrDefault(a => a.Name == "J.K. Rowling").Id,
                        Genres = new List<BookGenre>
                        {
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Adventure").Id },
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Action").Id },
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Fantasy").Id }
                        }
                    },
                    new Book
                    {
                        Title = "Harry Potter: Cursed Child", 
                        Price = 2250,
                        YearReleased = 2016,
                        AuthorId = _context.Authors.SingleOrDefault(a => a.Name == "J.K. Rowling").Id,
                        Genres = new List<BookGenre>
                        {
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Adventure").Id },
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Action").Id },
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Fantasy").Id }
                        }
                    },
                    new Book
                    {
                        Title = "Twilight", 
                        Price = 2000,
                        YearReleased = 2005,
                        AuthorId = _context.Authors.SingleOrDefault(a => a.Name == "Stephenie Meyer").Id,
                        Genres = new List<BookGenre>
                        {
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Adventure").Id },
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Action").Id },
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Fantasy").Id },
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Romance").Id },
                        }
                    },
                    new Book
                    {
                        Title = "Twilight: New Moon", 
                        Price = 2000,
                        YearReleased = 2006,
                        AuthorId = _context.Authors.SingleOrDefault(a => a.Name == "Stephenie Meyer").Id,
                        Genres = new List<BookGenre>
                        {
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Adventure").Id },
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Action").Id },
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Fantasy").Id },
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Romance").Id },
                        }
                    },
                    new Book
                    {
                        Title = "Twilight: Eclipse", 
                        Price = 2000,
                        YearReleased = 2007,
                        AuthorId = _context.Authors.SingleOrDefault(a => a.Name == "Stephenie Meyer").Id,
                        Genres = new List<BookGenre>
                        {
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Adventure").Id },
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Action").Id },
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Fantasy").Id },
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Romance").Id },
                        }
                    },
                    new Book
                    {
                        Title = "Twilight: Breaking Dawn", 
                        Price = 2000,
                        YearReleased = 2008,
                        AuthorId = _context.Authors.SingleOrDefault(a => a.Name == "Stephenie Meyer").Id,
                        Genres = new List<BookGenre>
                        {
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Adventure").Id },
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Action").Id },
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Fantasy").Id },
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Romance").Id },
                        }
                    },
                    new Book
                    {
                        Title = "The Hunger Games", 
                        Price = 1750,
                        YearReleased = 2008,
                        AuthorId = _context.Authors.SingleOrDefault(a => a.Name == "Suzanne Collins").Id,
                        Genres = new List<BookGenre>
                        {
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Adventure").Id },
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Action").Id },
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Fantasy").Id },
                        }
                    },
                    new Book
                    {
                        Title = "The Hunger Games: Catching Fire", 
                        Price = 1750,
                        YearReleased = 2009,
                        AuthorId = _context.Authors.SingleOrDefault(a => a.Name == "Suzanne Collins").Id,
                        Genres = new List<BookGenre>
                        {
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Adventure").Id },
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Action").Id },
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Fantasy").Id },
                        }
                    },
                    new Book
                    {
                        Title = "The Hunger Games: Mocking Jay", 
                        Price = 1750,
                        YearReleased = 2010,
                        AuthorId = _context.Authors.SingleOrDefault(a => a.Name == "Suzanne Collins").Id,
                        Genres = new List<BookGenre>
                        {
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Adventure").Id },
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Action").Id },
                            new BookGenre { GenreId = _context.Genres.SingleOrDefault(g => g.Name == "Fantasy").Id },
                        }
                    }
                };

                _context.Books.AddRange(books);
                _context.SaveChanges();
            }
        }
    }
}