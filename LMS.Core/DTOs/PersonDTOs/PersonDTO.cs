using System.ComponentModel.DataAnnotations;

namespace LMS.Core.DTOs.PersonDTOs
{
    public class PersonDTO
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid? LunchDetailId { get; set; }
    }
}
