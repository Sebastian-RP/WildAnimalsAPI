using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WildAnimalsAPI.Models;
using WildAnimalsAPI.Models.DTO;
using WildAnimalsAPI.Persistence;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WildAnimalsAPI.Controllers
{
    [Route("api/[controller]")]
    //[Authorize]
    [ApiController]
    public class AnimalContinentController : ControllerBase
    {
        private readonly ApplicationDbContext _DbContext;
        private readonly IMapper _Mapper;

        public AnimalContinentController(
            ApplicationDbContext DbContext,
            IMapper Mapper
            )
        {

        }
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<AnimalContinent>>> Get()
        //{
        //    List<AnimalContinent> continents = await _DbContext.AnimalContinents.ToListAsync();

        //    return Ok(continents);
        //}

        //[HttpGet("{id}")]
        //public async Task<ActionResult<AnimalContinent>> Get(int id)
        //{
        //    AnimalContinent continent = await _DbContext.AnimalContinents.FindAsync(id);

        //    return Ok(continent);
        //}

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Animal animal)
        {
            // Verifica que los continentes existan en la base de datos
            //var continents = await _DbContext.Continents
            //    .Where(c => animal.Continents.Select(ac => ac.ContinentId).Contains(c.Id))
            //    .ToListAsync();

            //if (continents.Count != animal.Continents.Count)
            //{
            //    return BadRequest("Uno o más continentes no existen en la base de datos.");
            //}

            // Agrega el animal a la base de datos
            _DbContext.Animals.Add(animal);
            await _DbContext.SaveChangesAsync();

            //foreach (var continent in continents)
            //{
            //    var animalContinent = new AnimalContinent
            //    {
            //        AnimalId = animal.Id,
            //        ContinentId = continent.Id
            //    };
            //    _DbContext.AnimalContinents.Add(animalContinent);
            //}

            // Guarda los cambios en la base de datos
            await _DbContext.SaveChangesAsync();

            return Ok();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
