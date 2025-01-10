using LMS.Application.Exceptions;
using LMS.Application.Helpers.Mappers;
using LMS.Core.DTOs.MenuDTOs;
using LMS.Core.Entities;
using LMS.Core.Interfaces;
using LMS.Core.Parameters;
using LMS.Core.Services;

namespace LMS.Application.Services
{
    public class MenuService(IRepositoryWrapper repo, IMenuItemService menuItemService) : IMenuService
    {
        private readonly IRepositoryWrapper _repo = repo;
        private readonly IMenuItemService _menuItemService = menuItemService;

        public async Task<MenuDTO> CreateAsync(CreateMenuDTO dto)
        {
            // Map dto to Menu entity and create it
            Menu menu = dto.MapFromCreateDTOToEntity();
            menu.CreatedAt = DateTime.UtcNow;
            Menu result = await _repo.MenuRepository.CreateAsync(menu);

            // Map result to MenuDTO
            MenuDTO resultDTO = result.MapToMenuDTO();
            resultDTO.MenuItems = new List<MenuItemDTO>();

            // Create menu items
            foreach (var foodId in dto.FoodIds)
            {
                MenuItemDTO menuItem = new MenuItemDTO
                {
                    MenuId = result.Id.ToString(),
                    FoodId = foodId
                };

                // Create menu item and map to DTO
                MenuItemDTO itemResult = await _menuItemService.CreateAsync(menuItem);

                // Add to MenuItems list
                resultDTO.MenuItems.Add(itemResult);
            }

            return resultDTO;
        }


        public async Task<bool> DeleteAsync(string id)
        {
            var result = await _repo.MenuRepository.DeleteAsync(Guid.Parse(id));
            if (!result) throw new Exception("Couldn't delete food");
            return result;
        }

        public async Task<List<MenuDTO>> GetAllAsync(IncludeQP? includeQP)
        {
            List<Menu> result = new List<Menu>();
            if (includeQP == null || includeQP.MenuItems == null)
            {
                result = (await _repo.MenuRepository.GetAllAsync()).ToList();
            }
            else
            {
                var expression = PredicateBuilder.True<Menu>();
                result = (await _repo.MenuRepository.GetAllInclude(expression, includeQP)).ToList();
            }
            return result.MapToMenuDTO();
        }

        public async Task<MenuDTO> GetByIdAsync(string id)
        {
            Menu? menu = await _repo.MenuRepository.GetByIdAsync(Guid.Parse(id));

            if (menu is null)
            {
                throw new NotFoundException("Menu not found");
            }
            return menu.MapToMenuDTO();
        }

        public async Task<MenuDTO?> UpdateAsync(MenuDTO dto)
        {
            Menu? menu = await _repo.MenuRepository.GetByIdAsync(Guid.Parse(dto.Id));

            if (menu is null) return null;

            menu.Name = dto.Name;
            menu.Date = dto.Date;
            menu.UpdatedAt = DateTime.UtcNow;

            await _repo.MenuRepository.UpdateAsync(menu);
            return menu.MapToMenuDTO();
        }

    }
}
