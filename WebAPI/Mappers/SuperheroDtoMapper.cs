using ApplicationCore.Models;
using AutoMapper;

namespace WebAPI.Mappers
{
    public class SuperheroDtoMapper : Profile
    {
        public SuperheroDtoMapper()
        {
            CreateMap<Superhero, SuperheroDtoMapper>().ReverseMap();
        }
    }
}
