using ApplicationCore.Commons.Repository;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.Services
{
    public class SuperheroService : ISuperheroService
    {
        private readonly IGenericRepository<Superhero, int> _superheroRepository;

        public SuperheroService(IGenericRepository<Superhero, int> superheroRepository)
        {
            this._superheroRepository = superheroRepository;
        }

        public List<Superhero> FindAllSuperHero()
        {
            return _superheroRepository.FindAll();
        }
    }
}
