using System.ComponentModel.DataAnnotations;
using Yawp.Utilities;

namespace Yawp.Models
{
    /**
     * <summary>An entity that can receive alerts.</summary>
     */
    public class Contact : BaseEntity
    {
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
        [Display(Name = "Email")]
        [RegularExpression(ValidationUtil.EmailAddressRegex, ErrorMessage = "Please enter a valid email address.")]
        public string EmailAddress { get; set; }

        [Display(Name = "Phone")]
        [RegularExpression(ValidationUtil.PhoneNumberRegex, ErrorMessage = "Please enter a valid North American phone number.")]
        public string PhoneNumber { get; set; }

    }
}
