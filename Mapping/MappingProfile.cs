using System.Linq;
using AutoMapper;
using PaginationDemo.Core.Models;
using PaginationDemo.Core.Models.Tools;
using PaginationDemo.Persistence.DTO;
using PaginationDemo.Persistence.DTO.Tools;

namespace PaginationDemo.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BookListDto>()
                .ForMember(
                    dst => dst.AuthorName,
                    opt => opt.MapFrom(res => res.Author.Name))
                .ForMember(
                    dst => dst.GenreNames,
                    opt => opt.MapFrom(res => res.Genres.Select(g => g.Genre.Name))
                );
            CreateMap<BookResult, BookResultDto>();
            
            CreateMap<ObjectQueryDto, ObjectQuery>();
            CreateMap<BookQueryDto, BookQuery>();
            CreateMap<BookResultDto, BookResult>();
        }
    }
}