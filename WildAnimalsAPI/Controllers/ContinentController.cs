using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WildAnimalsAPI.Models;
using WildAnimalsAPI.Models.DTO;
using WildAnimalsAPI.Persistence;

namespace WildAnimalsAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class ContinentController : ControllerBase
    {
        private readonly ApplicationDbContext _DbContext;
        private readonly IMapper _Mapper;

        public ContinentController(
            ApplicationDbContext Dbcontext,
            IMapper Mapper
            )
        {
            _DbContext = Dbcontext;
            _Mapper = Mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<Continent>>> Get()
        {
            List<Continent> allContinents = await _DbContext.Continents.ToListAsync();

            return Ok(allContinents);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Continent>> Get(int id)
        {
            Continent currentContinent = await _DbContext.Continents.FindAsync(id);

            if (currentContinent == null)
            {
                return BadRequest("el continente no fue encontrado");
            }

            return Ok(currentContinent);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateContinentDto newContinent)
        {
            Continent continentMapped = _Mapper.Map<Continent>(newContinent);

            _DbContext.Continents.Add(continentMapped);
            await _DbContext.SaveChangesAsync();

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateContinentDto updateContinent)
        {
            if (id != updateContinent.Id)
            {
                BadRequest("Los id no coinciden");
            }

            //al usar any no traigo la entidad por lo cual no se realiza un seguimiento de la misma
            var existContinent = await _DbContext.Continents.AnyAsync(continent => continent.Id == id);
            if (!existContinent)
            {
                return BadRequest("el Id " + id + " no fue encontrado ");
            }

            Continent mappedContinent= _Mapper.Map<Continent>(updateContinent);

            _DbContext.Continents.Update(mappedContinent);
            await _DbContext.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existContinent = await _DbContext.Continents.FirstOrDefaultAsync(continent => continent.Id == id);

            if (existContinent == null)
            {
                return BadRequest("No se encontro el id");
            }

            _DbContext.Continents.Remove(existContinent);
            await _DbContext.SaveChangesAsync();

            return Ok("El registro fue borrado exitosamente");
        }
    }
}
