using AutoMapper;
using Domain.Dtos;
using Domain.Entities;


namespace Infrastructure.MapperProfiles;

public class InfrastructureProfile : Profile
{ 
    public InfrastructureProfile()
    {
        CreateMap<Book, BookDto>().ReverseMap();
        CreateMap<AddBookDto, Book>().ReverseMap();
     }
}