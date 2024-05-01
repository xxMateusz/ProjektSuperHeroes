using ApplicationCore.Models;
using AutoMapper;
using Infrastructure.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Mappers
{
    public class SuperheroProfile : Profile
    {
        public SuperheroProfile()
        {
            CreateMap<SuperheroEntity, Superhero>().ReverseMap();
            CreateMap<ColorEntity, Color>().ReverseMap();
            CreateMap<AlignmentEntity, Alignment>().ReverseMap();
            CreateMap<AttributeEntity, ApplicationCore.Models.Attribute>().ReverseMap();
            CreateMap<GenderEntity, Gender>().ReverseMap();
            CreateMap<HeroAttributeEntity, HeroAttribute>().ReverseMap();
            CreateMap<PublisherEntity, Publisher>().ReverseMap();
            CreateMap<RaceEntity, Race>().ReverseMap();
            CreateMap<SuperpowerEntity, Superpower>().ReverseMap();
        }
    }
}
