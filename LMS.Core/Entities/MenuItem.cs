namespace LMS.Core.Entities
{
    public class MenuItem : BaseEntity
    {
        public Guid MenuId { get; set; }
        public virtual Menu Menu { get; set; }
        public Guid FoodId { get; set; }
        public virtual Food Food { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
