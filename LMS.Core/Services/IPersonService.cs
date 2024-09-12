using LMS.Core.DTOs.PersonDTOs;

namespace LMS.Core.Services
{
    public interface IPersonService
    {
        Task<PersonDTO> GetByIdAsync(string id);
        Task<List<PersonDTO>> GetAllAsync();
        Task<PersonDTO> CreateAsync(CreatePersonDTO person);
        Task UpdateAsync(string id, PersonDTO person);
        Task<bool> DeleteAsync(string id);
    }
}
