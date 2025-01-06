namespace LMS.Core.DTOs.MenuDTOs
{
    public class CreateMenuDTO
    {
        public string Name { get; set; }
        public DateOnly Date { get; set; }
        public string[] FoodIds { get; set; }
    }
}
