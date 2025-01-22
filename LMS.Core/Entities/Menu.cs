namespace LMS.Core.Entities
{
    public class Menu : BaseEntity
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public virtual ICollection<MenuItem> MenuItems{ get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
