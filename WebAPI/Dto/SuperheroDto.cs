using ApplicationCore.Commons.Repository;
using ApplicationCore.Models;

namespace WebAPI.Dto
{
    public class SuperheroDto : IIdentity<int>
    {
        public int Id { get; set; }
        public string SuperheroName { get; set; }
        public string FullName { get; set; }
        public GenderDto Gender { get; set; }
        public ColorDto EyeColor { get; set; }
        public ColorDto HairColor { get; set; }
        public ColorDto SkinColor { get; set; }
        public RaceDto Race { get; set; }
        public PublisherDto Publisher { get; set; }
        public AlignmentDto Alignment { get; set; }
        public double HeightCm { get; set; }
        public double WeightKg { get; set; }
        public List<HeroAttributeDto> HeroAttributes { get; set; } = new List<HeroAttributeDto>();
        public List<SuperpowerDto> HeroPowers { get; set; } = new List<SuperpowerDto>();
    }

    public class GenderDto
    {
        public int Id { get; set; }
        public string GenderName { get; set; }
    }

    public class ColorDto
    {
        public int Id { get; set; }
        public string ColourName { get; set; }
    }

    public class RaceDto
    {
        public int Id { get; set; }
        public string RaceName { get; set; }
    }

    public class PublisherDto
    {
        public int Id { get; set; }
        public string PublisherName { get; set; }
    }

    public class AlignmentDto
    {
        public int Id { get; set; }
        public string AlignmentName { get; set; }
    }

    public class HeroAttributeDto
    {
        public int Id { get; set; }
        public string AttributeName { get; set; }
    }

    public class SuperpowerDto
    {
        public int Id { get; set; }
        public string SuperpowerName { get; set; }
    }
}
