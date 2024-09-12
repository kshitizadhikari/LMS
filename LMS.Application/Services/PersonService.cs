using LMS.Application.Helpers.Mappers;
using LMS.Core.DTOs.PersonDTOs;
using LMS.Core.Entities;
using LMS.Core.Interfaces;
using LMS.Core.Services;

namespace LMS.Application.Services
{
    public class PersonService(IRepositoryWrapper repo) : IPersonService
    {
        private readonly IRepositoryWrapper _repo = repo;

        public async Task<PersonDTO> CreateAsync(CreatePersonDTO dto)
        {
            Person person = dto.MapToPerson();
            Person result = await _repo.PersonRepository.CreateAsync(person);
            return result.MapToPersonDTO();
        }

        public async Task<bool> DeleteAsync(string id)
        {
            var result = await _repo.PersonRepository.DeleteAsync(Guid.Parse(id));
            if (!result) throw new Exception("Couldn't delete person");
            return result;
        }

        public async Task<List<PersonDTO>> GetAllAsync()
        {
            List<Person> result = ( await _repo.PersonRepository.GetAllAsync()).ToList();
            return result.MapToPersonDTO();
        }

        public async Task<PersonDTO> GetByIdAsync(string id)
        {
            Person person = await _repo.PersonRepository.GetByIdAsync(Guid.Parse(id));
            return person.MapToPersonDTO();
        }

        public async Task UpdateAsync(string id, PersonDTO personDto)
        {
            Person person = await _repo.PersonRepository.GetByIdAsync(Guid.Parse(id)) ?? throw new Exception("Invalid person object");
            person.FirstName = personDto.FirstName;
            person.LastName = personDto.LastName;
            person.Phone = personDto.Phone;
            person.UpdatedAt = DateTime.UtcNow;
            await _repo.PersonRepository.UpdateAsync(person);
        }

    }
}
