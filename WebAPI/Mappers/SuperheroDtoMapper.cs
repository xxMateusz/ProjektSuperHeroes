using ApplicationCore.Models;
using AutoMapper;
using WebAPI.Dto;

namespace WebAPI.Mappers
{
    public class SuperheroDtoMapper : Profile
    {
        public SuperheroDtoMapper()
        {
            CreateMap<Superhero, SuperheroDto>().ReverseMap();
            CreateMap<Gender, GenderDto>().ReverseMap();
            CreateMap<Color, ColorDto>().ReverseMap();
            CreateMap<Race, RaceDto>().ReverseMap();
            CreateMap<Publisher, PublisherDto>().ReverseMap();
            CreateMap<Alignment, AlignmentDto>().ReverseMap();
            CreateMap<HeroAttribute, HeroAttributeDto>().ReverseMap();
            CreateMap<Superpower, SuperpowerDto>().ReverseMap();
        }
    }
}
