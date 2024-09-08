using LMS.Core.Entities;
using LMS.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IServiceWrapper _services;

        public PersonController(IServiceWrapper services)
        {
            _services = services;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Person>> GetPersonById(string id)
        {
            Person person = await _services.PersonService.GetById(id);
            return person;
        }

        [HttpGet("get-all")]
        public async Task<ActionResult<List<Person>>> GetAll()
        {
            return await _services.PersonService.GetAll();
        }

        [HttpPost]
        public async Task<Person> CreatePerson([FromBody] Person entity)
        {
            Person person = await _services.PersonService.CreateAsync(entity);
            return person;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdatePersonById(Person person)
        {
            await _services.PersonService.UpdateAsync(person);
            return Ok();
        }
    }
}
