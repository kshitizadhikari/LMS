using LMS.Core.DTOs.FoodDTOs;
using LMS.Core.Entities;
using static LMS.Core.Constants.Enums;

namespace LMS.Application.Helpers.Mappers
{
    public static class FoodMapper
    {
        public static Food MapToFood(this FoodDTO dto)
        {
            return new Food
            {
                Id = string.IsNullOrEmpty(dto.Id) ? Guid.NewGuid() : Guid.Parse(dto.Id),
                Name = dto.Name,
                Price = dto.Price,
                FoodType = Enum.TryParse<FoodType>(dto.FoodType, out var foodType) ? foodType : FoodType.Unknown,
            };
        }

        public static List<Food> MapToFood(this IList<FoodDTO> dtos)
        {
            return dtos.Select(x => x.MapToFood()).ToList();
        }

        public static FoodDTO MapToFoodDTO(this Food entity)
        {
            return new FoodDTO
            {
                Id = entity.Id.ToString(),
                Name = entity.Name,
                Price = entity.Price,
                FoodType = Utils.GetEnumDisplayName(entity.FoodType)
            };
        }

        public static List<FoodDTO> MapToFoodDTO(this IList<Food> entities)
        {
            return entities.Select(x => x.MapToFoodDTO()).ToList();
        }
    }
}
