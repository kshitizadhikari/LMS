namespace LMS.Core.Entities
{
    public class LunchDetail : BaseEntity
    {
        public required float CurrentTotal { get; set; }
        public float Due {  get; set; }
        public float Extra { get; set; }
        public float Balance { get; set; }
        public virtual ICollection<Person> Persons { get; set; } = new List<Person>();
    }
}
