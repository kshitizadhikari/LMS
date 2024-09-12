using LMS.Core.DTOs.PersonDTOs;
using LMS.Core.Entities;
using System;

namespace LMS.Application.Helpers.Mappers
{
    public static class PersonMapper
    {
        // Mapping from CreatePersonDTO to Person entity
        public static Person MapToPerson(this CreatePersonDTO dto)
        {
            return new Person
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Phone = dto.Phone,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };
        }

        // Mapping from PersonDTO to Person entity
        public static Person MapToPerson(this PersonDTO dto)
        {
            return new Person
            {
                Id = Guid.Parse(dto.Id),
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Phone = dto.Phone,
                CreatedAt = dto.CreatedAt,
                UpdatedAt = dto.UpdatedAt,
                LunchDetailId = dto.LunchDetailId
            };
        }

        public static List<Person> MapToPerson(this IList<PersonDTO> dtos)
        {
            return dtos.Select(x => x.MapToPerson()).ToList();
        }

        // Mapping from Person entity to PersonDTO
        public static PersonDTO MapToPersonDTO(this Person person)
        {
            return new PersonDTO
            {
                Id = person.Id.ToString(),
                FirstName = person.FirstName,
                LastName = person.LastName,
                Phone = person.Phone,
                CreatedAt = person.CreatedAt,
                UpdatedAt = person.UpdatedAt,
                LunchDetailId = person.LunchDetailId
            };
        }

        public static List<PersonDTO> MapToPersonDTO(this IList<Person> persons)
        {
            return persons.Select(x => x.MapToPersonDTO()).ToList();
        }
    }
}
