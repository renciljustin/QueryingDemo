using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PaginationDemo.Core;
using PaginationDemo.Core.Models;
using PaginationDemo.Core.Models.Tools;
using PaginationDemo.Shared.Extensions;

namespace PaginationDemo.Persistence
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _context;
        public BookRepository(AppDbContext context)
        {
            _context = context;

        }

        public async Task<BookResult> GetBooksAsync(BookQuery bookQuery)
        {
            var books = _context.Books
                .Include(b => b.Author)
                .Include(b => b.Genres)
                    .ThenInclude(bg => bg.Genre)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(bookQuery.SearchKey))
            {
                books = books.Where(b => b.Title.Contains(bookQuery.SearchKey));
            }

            if (bookQuery.AuthorId != null)
            {
                books = books.Where(b => b.AuthorId == bookQuery.AuthorId);
            }

            if (bookQuery.GenreId != null)
            {
                books = books.Where(b => b.Genres.Any(bg => bg.GenreId == bookQuery.GenreId));
            }

            var columnsMap = new Dictionary<string, Expression<Func<Book, object>>>()
            {
                ["Title"] = book => book.Title,
                ["Price"] = book => book.Price,
                ["YearReleased"] = book => book.YearReleased,
                ["Author"] = book => book.Author.Name
            };
            books = books.ApplyOrdering(bookQuery, columnsMap);

            var totalCount = await books.CountAsync();

            books = books.ApplyPaging(bookQuery);

            return new BookResult
            {
                Books = await books.ToListAsync(),
                TotalCount = totalCount
            };
        }
    }
}