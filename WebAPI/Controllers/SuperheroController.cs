using Microsoft.AspNetCore.Mvc;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Services;
using ApplicationCore.Models;
using WebAPI.Dto;
using AutoMapper;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("/api/v1/superhero")]
    public class SuperheroController : ControllerBase
    {
        private readonly ISuperheroService _service;
        private readonly IMapper _mapper;

        public SuperheroController(ISuperheroService service, IMapper mapper) 
        {
            _service = service;
            this._mapper = mapper;
        }

        [HttpGet]
        public List<SuperheroDto> GetAll()
        {
            return _mapper.Map<List<SuperheroDto>>(_service.FindAllSuperHero());
        }
        [HttpGet("{id}")]
        public ActionResult<SuperheroDto> GetById(int id)
        {
            var superhero = _service.FindSuperHeroById(id);
            if (superhero == null)
            {
                return NotFound();
            }

            var superheroDto = _mapper.Map<SuperheroDto>(superhero);
            return Ok(superheroDto);
        }

        //[HttpGet]
        //[Route("{id}")]
        //public ActionResult<SuperheroDto> FindById(int id)
        //{
        //    var result = SuperheroDto.of(_service.FindQuizById(id));
        //    return result is null ? NotFound() : Ok(result);
        //}


        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
