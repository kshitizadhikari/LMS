using LMS.Core.DTOs.CustomerDTOs;

namespace LMS.Core.Services
{
    public interface ICustomerService
    {
        Task<CustomerDTO> GetByIdAsync(string id);
        Task<List<CustomerDTO>> GetAllAsync();
        Task<CustomerDTO> CreateAsync(CreateCustomerDTO person);
        Task <CustomerDTO> UpdateAsync(CustomerDTO person);
        Task<bool> DeleteAsync(string id);
    }
}
