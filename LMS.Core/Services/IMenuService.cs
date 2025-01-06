using LMS.Core.DTOs.MenuDTOs;

namespace LMS.Core.Services
{
    public interface IMenuService
    {
        Task<MenuDTO> GetByIdAsync(string id);
        Task<List<MenuDTO>> GetAllAsync();
        Task<MenuDTO> CreateAsync(CreateMenuDTO dto);
        Task<MenuDTO> UpdateAsync(MenuDTO item);
        Task<bool> DeleteAsync(string id);
    }
}
