using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaginationDemo.Core;
using PaginationDemo.Core.Models;
using PaginationDemo.Core.Models.Tools;
using PaginationDemo.Persistence;
using PaginationDemo.Persistence.DTO;
using PaginationDemo.Persistence.DTO.Tools;

namespace PaginationDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _repo;
        private readonly IMapper _mapper;
        public BooksController(IBookRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<BookResultDto> GetBooks([FromQuery] BookQueryDto bookQueryDto)
        {
            var bookQuery = _mapper.Map<BookQuery>(bookQueryDto);

            var books = await _repo.GetBooksAsync(bookQuery);

            var booksToReturn = _mapper.Map<BookResultDto>(books);

            return booksToReturn;
        }
    }
}
