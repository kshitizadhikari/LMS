namespace LMS.Core.DTOs.FoodDTOs;
public class FoodDTO
{
    public string? Id { get; set; }
    public string Name { get; set; }
    public float Price { get; set; }
    public string FoodType { get; set; }
    // public virtual ICollection<MenuItem> MenuItems { get; set; }
}
