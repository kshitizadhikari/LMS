using LMS.Core.DTOs.CustomerDTOs;
using LMS.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Api.Controllers
{
    [ApiController]
    public class CustomerController : BaseApiController
    {
        private readonly IServiceWrapper _services;

        public CustomerController(IServiceWrapper services)
        {
            _services = services;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerDTO>> GetCustomerById(string id)
        {
            CustomerDTO customerDto = await _services.CustomerService.GetByIdAsync(id);
            return customerDto;
        }

        [HttpGet]
        public async Task<ActionResult<List<CustomerDTO>>> GetAllAsync()
        {
            return await _services.CustomerService.GetAllAsync();
        }

        [HttpPost]
        public async Task<CustomerDTO> CreateCustomer([FromBody] CreateCustomerDTO dto)
        {
            CustomerDTO result = await _services.CustomerService.CreateAsync(dto);
            return result;
        }

        [HttpPut("{id}")]
        public async Task<CustomerDTO> UpdateCustomer(string id, CustomerDTO dto)
        {
            CustomerDTO result = await _services.CustomerService.UpdateAsync(id, dto);
            return result;
        }

        [HttpDelete("{id}")]
        public async Task DeleteCustomer(string id)
        {
            await _services.CustomerService.DeleteAsync(id);
        }
    }
}
