using LMS.Core.DTOs.CustomerDTOs;
using LMS.Core.Entities;

namespace LMS.Application.Helpers.Mappers
{
    public static class CustomerMapper
    {
        // Mapping from CreateCustomerDTO to Customer entity
        public static Customer MapToCustomer(this CreateCustomerDTO dto)
        {
            return new Customer
            {
                Id = Guid.NewGuid(),
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                Phone = dto.Phone,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };
        }

        // Mapping from CustomerDTO to Customer entity
        public static Customer MapToCustomer(this CustomerDTO dto)
        {
            return new Customer
            {
                Id = Guid.Parse(dto.Id),
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                Phone = dto.Phone,
                CreatedAt = dto.CreatedAt,
                UpdatedAt = dto.UpdatedAt,
            };
        }

        public static List<Customer> MapToCustomer(this IList<CustomerDTO> dtos)
        {
            return dtos.Select(x => x.MapToCustomer()).ToList();
        }

        // Mapping from Customer entity to CustomerDTO
        public static CustomerDTO MapToCustomerDTO(this Customer entity)
        {
            return new CustomerDTO
            {
                Id = entity.Id.ToString(),
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Email = entity.Email,
                Phone = entity.Phone,
                CreatedAt = entity.CreatedAt,
                UpdatedAt = entity.UpdatedAt,
            };
        }

        public static List<CustomerDTO> MapToCustomerDTO(this IList<Customer> entities)
        {
            return entities.Select(x => x.MapToCustomerDTO()).ToList();
        }
    }
}
