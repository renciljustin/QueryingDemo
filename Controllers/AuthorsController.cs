using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaginationDemo.Core.Models;
using PaginationDemo.Persistence;

namespace PaginationDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorsController : ControllerBase
    {
        private readonly AppDbContext _context;
        public AuthorsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Author>> GetAuthors()
        {
            return await _context.Authors.ToListAsync();
        }
    }
}