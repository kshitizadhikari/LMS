using LMS.Application.Exceptions;
using LMS.Application.Helpers.Mappers;
using LMS.Core.DTOs.MenuDTOs;
using LMS.Core.Entities;
using LMS.Core.Interfaces;
using LMS.Core.Services;

namespace LMS.Application.Services
{
    public class MenuItemService(IRepositoryWrapper repo) : IMenuItemService
    {
        private readonly IRepositoryWrapper _repo = repo;

        public async Task<MenuItemDTO> CreateAsync(MenuItemDTO item)
        {
            MenuItem menuItem = item.MapToMenuItem();
            menuItem.CreatedAt = DateTime.UtcNow;
            MenuItem result = await _repo.MenuItemRepository.CreateAsync(menuItem);
            return result.MapToMenuItemDTO();
        }

        public async Task<bool> DeleteAsync(string id)
        {
            var result = await _repo.MenuItemRepository.DeleteAsync(Guid.Parse(id));
            if (!result) throw new Exception("Couldn't delete menu item");
            return result;
        }

        public async Task<List<MenuItemDTO>> GetAllAsync()
        {
            List<MenuItem> result = (await _repo.MenuItemRepository.GetAllAsync()).ToList();
            return result.MapToMenuItemDTO();
        }

        public async Task<MenuItemDTO> GetByIdAsync(string id)
        {
            MenuItem? menuItem = await _repo.MenuItemRepository.GetByIdAsync(Guid.Parse(id));

            if (menuItem is null)
            {
                throw new NotFoundException("Menu item not found");
            }
            return menuItem.MapToMenuItemDTO();
        }

        public async Task<MenuItemDTO?> UpdateAsync(MenuItemDTO dto)
        {
            MenuItem? menuItem = await _repo.MenuItemRepository.GetByIdAsync(Guid.Parse(dto.Id));

            if (menuItem is null) return null;

            menuItem.MenuId= Guid.Parse(dto.MenuId);
            menuItem.FoodId = Guid.Parse(dto.FoodId);
            menuItem.UpdatedAt = DateTime.UtcNow;

            await _repo.MenuItemRepository.UpdateAsync(menuItem);
            return menuItem.MapToMenuItemDTO();
        }
    }
}
