using System;
using System.ComponentModel.DataAnnotations;
using Yawp.Utilities;

namespace Yawp.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        public string Description { get; set; }

        [Display(Name = "Created")]
        public DateTime? DateCreated { get; set; }

        [Display(Name = "Modified")]
        public DateTime? DateModified { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        /*
         * LastName is not required for Contacts because a Contact may not
         * correspond to an actual person. It could be used by/for a
         * service, for example.
         */
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [RegularExpression(ValidationUtil.EmailAddressRegex, ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }

        [Display(Name = "Phone")]
        [RegularExpression(ValidationUtil.PhoneNumberRegex, ErrorMessage = "Please enter a valid North American phone number.")]
        public string PhoneNumber { get; set; }

    }
}
