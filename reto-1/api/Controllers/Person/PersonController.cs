using DoublePartnersAPI.DTO;
using DoublePartnersAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DoublePartnersAPI.Controllers.Person
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository personRepository;

        public PersonController(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonDTO>>> Get()
        {
            var result = await personRepository.GetPersons(1, 100);

            return Ok(result);
        }

        [HttpGet("{page}/{registersPerPage}")]
        public async Task<ActionResult<IEnumerable<PersonDTO>>> Get(int page, int registersPerPage = 10)
        {
            var result = await personRepository.GetPersons(page, registersPerPage);

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<bool>> Post([FromBody] PersonDTO person)
        {
            bool result = await personRepository.SavePerson(person);

            return result ? Ok() : Conflict();
        }
    }
}
