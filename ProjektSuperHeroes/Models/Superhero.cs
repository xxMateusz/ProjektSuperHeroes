using ApplicationCore.Commons.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class Superhero : IIdentity<int>
    {
        public int Id { get; set; }
        public string SuperheroName { get; set; }
        public string FullName { get; set; }
        public Gender Gender { get; set; }
        public Color EyeColor { get; set; }
        public Color HairColor { get; set; }
        public Color SkinColor { get; set; }
        public Race Race { get; set; }
        public Publisher Publisher { get; set; }
        public Alignment Alignment { get; set; }
        public double HeightCm { get; set; }
        public double WeightKg { get; set; }
        public List<HeroAttribute> HeroAttributes { get; set; } = new List<HeroAttribute>();
        public List<Superpower> HeroPowers { get; set; } = new List<Superpower>();
    }
}
