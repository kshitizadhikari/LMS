using static LMS.Core.Constants.Enums;

namespace LMS.Core.Entities
{
    public class Food : BaseEntity
    {
        public required string Name { get; set; }
        public required float Price { get; set; }
        public required FoodType FoodType{ get; set; }
        public virtual ICollection<MenuItem> MenuItems { get; set; }
    }
}