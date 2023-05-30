using AutoMapper;
using Filmes_API.Data.Dtos;
using Filmes_API.Models;

namespace Filmes_API.Profiles
{
    public class SessaoProfile : Profile
    {
        public SessaoProfile()
        {
            CreateMap<CreateSessaoDto, Sessao>();
            CreateMap<Sessao, ReadSessaoDto>();
        }
    }
}
