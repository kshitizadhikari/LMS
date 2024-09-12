using LMS.Core.DTOs.PersonDTOs;
using LMS.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Api.Controllers
{
    [ApiController]
    public class PersonController : BaseApiController
    {
        private readonly IServiceWrapper _services;

        public PersonController(IServiceWrapper services)
        {
            _services = services;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PersonDTO>> GetPersonById(string id)
        {
            PersonDTO personDto = await _services.PersonService.GetByIdAsync(id);
            return personDto;
        }

        [HttpGet("get-all")]
        public async Task<ActionResult<List<PersonDTO>>> GetAllAsync()
        {
            return await _services.PersonService.GetAllAsync();
        }

        [HttpPost]
        public async Task<PersonDTO> CreatePerson([FromBody] CreatePersonDTO personDto)
        {
            PersonDTO result = await _services.PersonService.CreateAsync(personDto);
            return result;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePerson(string id, PersonDTO personDto)
        {
            await _services.PersonService.UpdateAsync(id, personDto);
            return Ok();
        }
    }
}
