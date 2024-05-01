using ApplicationCore.Commons.Specification;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Specifications
{
    public class SuperheroByName : BaseSpecification<Superhero>
    {
        public SuperheroByName(string superheroName) : base(item => item.SuperheroName == superheroName)
        {
            AddInclude(item => item.HeroAttributes);
            AddInclude(item => item.HeroPowers);
            AddInclude(item => item.EyeColor);
            AddInclude(item => item.HairColor);
            AddInclude(item => item.SkinColor);
            AddInclude(item => item.Publisher);
            AddInclude(item => item.Race);
            AddInclude(item => item.Alignment);
            AddInclude(item => item.Gender);
        }
    }
}
