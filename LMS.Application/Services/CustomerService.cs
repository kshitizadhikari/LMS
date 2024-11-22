using LMS.Application.Helpers.Mappers;
using LMS.Core.DTOs.CustomerDTOs;
using LMS.Core.Entities;
using LMS.Core.Interfaces;
using LMS.Core.Services;

namespace LMS.Application.Services
{
    public class CustomerService(IRepositoryWrapper repo) : ICustomerService
    {
        private readonly IRepositoryWrapper _repo = repo;

        public async Task<CustomerDTO> CreateAsync(CreateCustomerDTO dto)
        {
            Customer customer = dto.MapToCustomer();
            Customer result = await _repo.CustomerRepository.CreateAsync(customer);
            return result.MapToCustomerDTO();
        }

        public async Task<bool> DeleteAsync(string id)
        {
            var result = await _repo.CustomerRepository.DeleteAsync(Guid.Parse(id));
            if (!result) throw new Exception("Couldn't delete customer");
            return result;
        }

        public async Task<List<CustomerDTO>> GetAllAsync()
        {
            List<Customer> result = ( await _repo.CustomerRepository.GetAllAsync()).ToList();
            return result.MapToCustomerDTO();
        }

        public async Task<CustomerDTO?> GetByIdAsync(string id)
        {
            Customer? person = await _repo.CustomerRepository.GetByIdAsync(Guid.Parse(id));
            if (person is null) return null;
            return person.MapToCustomerDTO();
        }

        public async Task<CustomerDTO> UpdateAsync(CustomerDTO dto)
        {
            Customer customer = await _repo.CustomerRepository.GetByIdAsync(Guid.Parse(dto.Id)) ?? throw new Exception("Invalid customer object");
            customer.FirstName = dto.FirstName;
            customer.LastName = dto.LastName;
            customer.Email = dto.Email;
            customer.Phone = dto.Phone;
            customer.UpdatedAt = DateTime.UtcNow;
            await _repo.CustomerRepository.UpdateAsync(customer);
            return customer.MapToCustomerDTO();
        }

    }
}
