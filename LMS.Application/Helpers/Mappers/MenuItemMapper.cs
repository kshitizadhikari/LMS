using LMS.Core.DTOs.FoodDTOs;
using LMS.Core.DTOs.MenuDTOs;
using LMS.Core.Entities;

namespace LMS.Application.Helpers.Mappers
{
    public static class MenuItemMapper
    {
        public static MenuItem MapToMenuItem(this MenuItemDTO dto)
        {
            ArgumentNullException.ThrowIfNull(dto);

            return new MenuItem
            {
                Id = string.IsNullOrEmpty(dto.Id) ? Guid.NewGuid() : Guid.Parse(dto.Id),
                MenuId = Guid.Parse(dto.MenuId),
                FoodId = Guid.Parse(dto.FoodId)

            };
        }

        public static List<MenuItem> MapToMenuItem(this IList<MenuItemDTO> items)
        {
            ArgumentNullException.ThrowIfNull(items);

            return items.Select(x => x.MapToMenuItem()).ToList();
        }

        public static MenuItemDTO MapToMenuItemDTO(this MenuItem entity)
        {
            ArgumentNullException.ThrowIfNull(entity);

            var foodDto = entity.Food?.MapToFoodDTO();

            return new MenuItemDTO
            {
                Id = entity.Id.ToString(),
                MenuId = entity.MenuId.ToString(),
                FoodId = entity.FoodId.ToString(),
                Food = foodDto
            };
        }

        public static List<MenuItemDTO> MapToMenuItemDTO(this IList<MenuItem> entities)
        {
            ArgumentNullException.ThrowIfNull(entities);

            return entities.Select(x => x.MapToMenuItemDTO()).ToList();
        }
    }
}
