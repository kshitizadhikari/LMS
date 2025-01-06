using LMS.Core.DTOs.MenuDTOs;

namespace LMS.Core.Services
{
    public interface IMenuItemService
    {
        Task<MenuItemDTO> GetByIdAsync(string id);
        Task<List<MenuItemDTO>> GetAllAsync();
        Task<MenuItemDTO> CreateAsync(MenuItemDTO item);
        Task<MenuItemDTO> UpdateAsync(MenuItemDTO item);
        Task<bool> DeleteAsync(string id);
    }
}
