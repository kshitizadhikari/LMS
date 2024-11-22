using LMS.Core.DTOs.FoodDTOs;

namespace LMS.Core.Services
{
    public interface IFoodService
    {
        Task<FoodDTO> GetByIdAsync(string id);
        Task<List<FoodDTO>> GetAllAsync();
        Task<FoodDTO> CreateAsync(FoodDTO item);
        Task<FoodDTO> UpdateAsync(FoodDTO item);
        Task<bool> DeleteAsync(string id);
    }
}
