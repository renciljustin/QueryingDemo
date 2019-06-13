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
    public class GenresController : ControllerBase
    {
        private readonly AppDbContext _context;
        public GenresController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Genre>> GetAuthors()
        {
            return await _context.Genres.ToListAsync();
        }
    }
}