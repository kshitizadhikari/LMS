using LMS.Core.DTOs.MenuDTOs;
using LMS.Core.Entities;

namespace LMS.Application.Helpers.Mappers
{
    public static class MenuMapper
    {
        public static Menu MapFromCreateDTOToEntity(this CreateMenuDTO dto)
        {
            ArgumentNullException.ThrowIfNull(dto);

            return new Menu
            {
                Id = Guid.NewGuid(),
                Name = dto.Name,
                Date = dto.Date
            };
        }

        public static Menu MapToMenu(this MenuDTO dto)
        {
            ArgumentNullException.ThrowIfNull(dto);

            return new Menu
            {
                Id = Guid.Parse(dto.Id),
                Name = dto.Name,
                Date = dto.Date
            };
        }

        public static List<Menu> MapToMenu(this IList<MenuDTO> dto)
        {
            ArgumentNullException.ThrowIfNull(dto);

            return dto.Select(x => x.MapToMenu()).ToList();
        }

        public static MenuDTO MapToMenuDTO(this Menu entity)
        {
            ArgumentNullException.ThrowIfNull(entity);

            var menuItemDtoList = entity.MenuItems?.ToList().MapToMenuItemDTO() ?? new List<MenuItemDTO>();

            return new MenuDTO
            {
                Id = entity.Id.ToString(),
                Name = entity.Name,
                Date = entity.Date,
                MenuItems = menuItemDtoList,
            };
        }

        public static List<MenuDTO> MapToMenuDTO(this IList<Menu> entities)
        {
            ArgumentNullException.ThrowIfNull(entities);

            return entities.Select(x => x.MapToMenuDTO()).ToList();
        }
    }
}
