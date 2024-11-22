namespace LMS.Core.DTOs.FoodDTOs;
public class FoodDTO
{
    public string? Id { get; set; }
    public required string Name { get; set; }
    public required float Price { get; set; }
    public required string Type { get; set; }
    // public virtual ICollection<MenuItem> MenuItems { get; set; }
}
