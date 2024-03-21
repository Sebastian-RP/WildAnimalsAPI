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
    public class ContinentController : ControllerBase
    {
        private readonly ApplicationDbContext _DbContext;
        private readonly IMapper _Mapper;

        public ContinentController(
            ApplicationDbContext DbContext,
            IMapper Mapper
            )
        {

        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Continent>>> Get()
        {
            List<Continent> continents = await _DbContext.Continents.ToListAsync();

            return Ok(continents);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Continent>> Get(int id)
        {
            Continent continent = await _DbContext.Continents.FindAsync(id);

            return Ok(continent);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Continent data)
        {
            if (data == null)
            {
                return BadRequest();
            }

            //if (data.Animals == null)
            //{
            //    data.Animals = new ICollection<Animal>();
            //}
            //Continent newContinentMapped = _Mapper.Map<Continent>(data);

            var animalContient = new AnimalContinent();

            data.Animals.Add(animalContient);

            _DbContext.Continents.Add(data);
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
