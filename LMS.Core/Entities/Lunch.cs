namespace LMS.Core.Entities
{
    public class Lunch : BaseEntity
    {
        public required string Name { get; set; }
        public required float Price { get; set; }
    }
}
