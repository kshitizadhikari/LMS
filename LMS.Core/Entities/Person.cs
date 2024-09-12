
namespace LMS.Core.Entities
{
    public class Person : BaseEntity
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Phone { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; }
        public Guid? LunchDetailId { get; set; }
        public virtual LunchDetail? LunchDetail { get; set; }

    }
}
