using LMS.Application.Exceptions;
using LMS.Application.Helpers.Mappers;
using LMS.Core.DTOs.FoodDTOs;
using LMS.Core.Entities;
using LMS.Core.Interfaces;
using LMS.Core.Services;
using static LMS.Core.Constants.Enums;

namespace LMS.Application.Services
{
    public class FoodService(IRepositoryWrapper repo) : IFoodService
    {
        private readonly IRepositoryWrapper _repo = repo;

        public async Task<FoodDTO> CreateAsync(FoodDTO dto)
        {
            Food food = dto.MapToFood();
            Food result = await _repo.FoodRepository.CreateAsync(food);
            return result.MapToFoodDTO();
        }

        public async Task<bool> DeleteAsync(string id)
        {
            var result = await _repo.FoodRepository.DeleteAsync(Guid.Parse(id));
            if (!result) throw new Exception("Couldn't delete food");
            return result;
        }

        public async Task<List<FoodDTO>> GetAllAsync()
        {
            List<Food> result = ( await _repo.FoodRepository.GetAllAsync()).ToList();
            return result.MapToFoodDTO();
        }

        public async Task<FoodDTO> GetByIdAsync(string id)
        {
            Food? food = await _repo.FoodRepository.GetByIdAsync(Guid.Parse(id));

            if (food is null)
            {
                throw new NotFoundException("Food not found");
            }
            return food.MapToFoodDTO();
        }

        public async Task<FoodDTO?> UpdateAsync(FoodDTO dto)
        {
            Food? food = await _repo.FoodRepository.GetByIdAsync(Guid.Parse(dto.Id));

            if (food is null) return null;

            food.Name = dto.Name;
            food.Price = dto.Price;
            food.FoodType = Enum.TryParse<FoodType>(dto.FoodType, out var foodType) ? foodType : FoodType.Unknown;

            await _repo.FoodRepository.UpdateAsync(food);
            return food.MapToFoodDTO();
        }
    }
}
