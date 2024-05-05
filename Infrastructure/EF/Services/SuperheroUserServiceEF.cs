using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Interfaces.Services;
using ApplicationCore.Models;
using AutoMapper;
using Infrastructure.EF.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EF.Services
{
    public class SuperheroUserServiceEF : ISuperheroService
    {
        private readonly SuperheroDbContext _context;
        private readonly IMapper _mapper;
 
        public SuperheroUserServiceEF(SuperheroDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;

        }
      
        public List<Superhero> FindAllSuperHero()
        {
            return _mapper.Map<List<Superhero>>(Superheroes.ToList());
        }

        public Superhero FindSuperHeroById(int id)
        {
            var entity = Superheroes.FirstOrDefault(h => h.Id == id);
            return _mapper.Map<Superhero>(entity);
        }

        private IQueryable<SuperheroEntity> Superheroes =>
             _context.Superheroes
                .Include(x => x.Gender)
                .Include(x => x.EyeColor)
                .Include(x => x.SkinColor)
                .Include(x => x.HairColor)
                .Include(x => x.Alignment)
                .Include(x => x.Publisher)
                //.Include(x => x.HeroAttributes)
                .Include(x => x.Race);
    }
}
