using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EF.Entities
{
    public class SuperheroEntity
    {
        public int Id { get; set; }
        public string SuperheroName { get; set; }
        public string FullName { get; set; }
        public GenderEntity Gender { get; set; }
        public ColorEntity EyeColor { get; set; }
        public ColorEntity HairColor { get; set; }
        public ColorEntity SkinColor { get; set; }    
        public RaceEntity Race { get; set; }
        public PublisherEntity Publisher { get; set; }
        public AlignmentEntity Alignment { get; set; }
        public double HeightCm { get; set; }
        public double WeightKg { get; set; }
        public List<HeroAttributeEntity> HeroAttributes { get; set; } = new List<HeroAttributeEntity>();
        public List<SuperpowerEntity> HeroPowers { get; set; } = new List<SuperpowerEntity>();
    }
}
