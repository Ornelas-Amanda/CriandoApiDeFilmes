using AutoMapper;
using Filmes_API.Data.Dtos;
using Filmes_API.Models;


namespace Filmes_API.Profiles
{
    public class CinemaProfile : Profile
    {
        public CinemaProfile()
        {
            CreateMap<CreateCinemaDto, Cinema>();
            CreateMap<Cinema, ReadCinemaDto>().
                ForMember(cinemaDto => cinemaDto.ReadEnderecoDto,
                opt => opt.MapFrom(cinema => cinema.Endereco));
            CreateMap<UpdateCinemaDto, Cinema>();
        }
    }
}