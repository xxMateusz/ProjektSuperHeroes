using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Interfaces.Services;
using ApplicationCore.Models;
using AutoMapper;

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
            return _mapper.Map<List<Superhero>>(_context.Superheroes.ToList());
        }
    }
}
