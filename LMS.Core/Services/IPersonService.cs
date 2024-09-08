using LMS.Core.Entities;

namespace LMS.Core.Services
{
    public interface IPersonService
    {
        Task<Person> GetById(string id);
        Task<List<Person>> GetAll();
        Task<Person> CreateAsync(Person person);
        Task UpdateAsync(Person person);
        Task<bool> DeleteAsync(string id);
    }
}
