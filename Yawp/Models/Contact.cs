using System.ComponentModel.DataAnnotations;

namespace Yawp.Models
{
    /// <summary>
    /// A Contact represents a person or service that can receive alerts.
    /// </summary>
    public class Contact
    {
        public int Id { get; set; }

        [Required, Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string Description { get; set; }

        [Required, Display(Name = "Email")]
        public string EmailAddress { get; set; }

        [Required, Display(Name = "Phone")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Owned By")]
        public int OwnedBy { get; set; }

    }
}
