using LMS.Core.DTOs.FoodDTOs;
using LMS.Core.DTOs.MenuDTOs;
using LMS.Core.Entities;

namespace LMS.Application.Helpers.Mappers
{
    public static class MenuItemMapper
    {
        public static MenuItem MapToMenuItem(this MenuItemDTO dto)
        {
            return new MenuItem
            {
                Id = string.IsNullOrEmpty(dto.Id) ? Guid.NewGuid() : Guid.Parse(dto.Id),
                MenuId = Guid.Parse(dto.MenuId),
                FoodId = Guid.Parse(dto.FoodId)

            };
        }

        public static List<MenuItem> MapToMenuItem(this IList<MenuItemDTO> items)
        {
            return items.Select(x => x.MapToMenuItem()).ToList();
        }

        public static MenuItemDTO MapToMenuItemDTO(this MenuItem entity)
        {
            FoodDTO foodDto = new FoodDTO();

            if (entity.Food != null)
            {
                foodDto = entity.Food.MapToFoodDTO();
            }
            return new MenuItemDTO
            {
                Id = entity.Id.ToString(),
                MenuId = entity.MenuId.ToString(),
                MenuDTO = entity.Menu.MapToMenuDTO(),
                FoodId = entity.FoodId.ToString(),
                FoodDTO = foodDto
            };
        }

        public static List<MenuItemDTO> MapToMenuItemDTO(this IList<MenuItem> entities)
        {
            return entities.Select(x => x.MapToMenuItemDTO()).ToList();
        }
    }
}
