using System.ComponentModel.DataAnnotations;

namespace LMS.Core.DTOs.PersonDTOs
{
    public class CreatePersonDTO
    {
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        public string Phone { get; set; }
    }
}
