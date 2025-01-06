using LMS.Core.Entities;

namespace LMS.Core.DTOs.MenuDTOs
{
    public class MenuDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateOnly Date { get; set; }
        public ICollection<MenuItemDTO>? MenuItems { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
