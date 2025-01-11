using LMS.Core.DTOs.FoodDTOs;

namespace LMS.Core.DTOs.MenuDTOs
{
    public class MenuItemDTO
    {
        public string Id { get; set; }
        public string MenuId { get; set; }
        public MenuDTO MenuDTO { get; set; }
        public string FoodId { get; set; }
        public FoodDTO FoodDTO { get; set; }
    }
}
