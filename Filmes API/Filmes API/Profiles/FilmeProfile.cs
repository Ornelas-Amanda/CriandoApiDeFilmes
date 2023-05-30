using Filme_API.Models;
using Filmes_API.Data.Dtos;
using AutoMapper;

namespace Filmes_API.Profiles;

public class FilmeProfile : Profile
{
    public FilmeProfile() 
    {
        CreateMap<CreateFilmeDto, Filme>();
        CreateMap<UpdateFilmeDto, Filme>(); 
        CreateMap<Filme, UpdateFilmeDto>();
        CreateMap<Filme, ReadFilmeDto>().
            ForMember(filmeDto =>filmeDto.Sessoes,
            opt => opt.MapFrom(filme => filme.Sessoes));
    }
}
