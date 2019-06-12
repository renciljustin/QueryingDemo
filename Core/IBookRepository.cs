using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using PaginationDemo.Core.Models;
using PaginationDemo.Core.Models.Tools;

namespace PaginationDemo.Core
{
    public interface IBookRepository
    {
        Task<BookResult> GetBooksAsync(BookQuery bookQuery);
    }
}