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
    public class AnimalController : ControllerBase
    {
        private readonly ApplicationDbContext _DbContext;
        private readonly IMapper _Mapper;

        public AnimalController(
            ApplicationDbContext DbContext,
            IMapper Mapper
            )
        {
            _DbContext = DbContext;
            _Mapper = Mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Animal>>> Get()
        {
            List<Animal> continents = await _DbContext.Animals.ToListAsync();

            return Ok(continents);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Animal>> Get(int id)
        {
            Animal continent = await _DbContext.Animals.FindAsync(id);

            return Ok(continent);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateAnimalDto newAnimal)
        {
            List<int> continentNumber = newAnimal.Locations.Replace(" ", "").Split(';').Select(int.Parse).ToList();

            //Verifica que los continentes existan en la base de datos
            foreach (int continent in continentNumber)
            {
                bool existContinent = await _DbContext.Continents.AnyAsync(c => c.Id == continent);

                if (!existContinent) 
                {
                    return BadRequest("¡Error! El continente con el codigo: " + continent + " no fue encontrado");   
                }
            }

            Animal animalToSave = _Mapper.Map<Animal>(newAnimal);

            _DbContext.Animals.Add(animalToSave);
            await _DbContext.SaveChangesAsync();

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateAnimalDto updateAnimal)
        {
            if (id != updateAnimal.Id)
            {
                BadRequest("Los id no coinciden");
            }

            //al usar any no traigo la entidad por lo cual no se realiza un seguimiento de la misma
            var existAnimal = await _DbContext.Animals.AnyAsync(animal => animal.Id == id); 
            if (!existAnimal)
            {
                return BadRequest("el Id " + id + " no fue encontrado ");
            }

            Animal mappedAnimal = _Mapper.Map<Animal>(updateAnimal);

            _DbContext.Animals.Update(mappedAnimal);
            await _DbContext.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existAnimal = await _DbContext.Animals.FirstOrDefaultAsync(animal => animal.Id == id);

            if (existAnimal == null)
            {
                return BadRequest("No se encontro el id");
            }

            _DbContext.Animals.Remove(existAnimal);
            await _DbContext.SaveChangesAsync();

            return Ok("El registro fue borrado exitosamente");
        }
    }
}
