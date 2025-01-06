using LMS.Core.DTOs.MenuDTOs;
using LMS.Core.Entities;

namespace LMS.Application.Helpers.Mappers
{
    public static class MenuMapper
    {
        public static Menu MapFromCreateDTOToEntity(this CreateMenuDTO dto)
        {
            return new Menu
            {
                Id = Guid.NewGuid(),
                Name = dto.Name,
                Date = dto.Date
            };
        }

        public static Menu MapToMenu(this MenuDTO dto)
        {
            return new Menu
            {
                Id = Guid.Parse(dto.Id),
                Name = dto.Name,
                Date = dto.Date
            };
        }

        public static List<Menu> MapToMenu(this IList<MenuDTO> dto)
        {
            return dto.Select(x => x.MapToMenu()).ToList();
        }

        public static MenuDTO MapToMenuDTO(this Menu entity)
        {
            return new MenuDTO
            {
                Id = entity.Id.ToString(),
                Name = entity.Name,
                Date = entity.Date
            };
        }

        public static List<MenuDTO> MapToMenuDTO(this IList<Menu> entities)
        {
            return entities.Select(x => x.MapToMenuDTO()).ToList();
        }
    }
}
