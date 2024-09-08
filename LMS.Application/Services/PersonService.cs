using LMS.Core.Entities;
using LMS.Core.Interfaces;
using LMS.Core.Services;

namespace LMS.Application.Services
{
    public class PersonService(IRepositoryWrapper repo) : IPersonService
    {
        private readonly IRepositoryWrapper _repo = repo;

        public async Task<Person> CreateAsync(Person person)
        {
            Person result = await _repo.PersonRepository.CreateAsync(person);
            return result;
        }

        public async Task<bool> DeleteAsync(string id)
        {
            var result = await _repo.PersonRepository.DeleteAsync(id);
            if (!result) throw new Exception("Couldn't delete person");
            return result;
        }

        public async Task<List<Person>> GetAll()
        {
            List<Person> result = (List<Person>)await _repo.PersonRepository.GetAllAsync();
            return result;
        }

        public async Task<Person> GetById(string id)
        {
            return await _repo.PersonRepository.GetById(id);
        }

        public async Task UpdateAsync(Person person)
        {
            await _repo.PersonRepository.UpdateAsysnc(person);
        }
    }
}
