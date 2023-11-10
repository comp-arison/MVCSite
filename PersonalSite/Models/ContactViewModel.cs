using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PersonalSite.Models
{
    [Keyless]
    public class ContactViewModel
    {
        [Required(ErrorMessage = "*Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "*Email is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "*Subject is required")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "*Message is required")]
        public string Message { get; set; }
    }
}
