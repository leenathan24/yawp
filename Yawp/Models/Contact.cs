using System.ComponentModel.DataAnnotations;

namespace Yawp.Models
{
    /**
     * <summary>An entity that can receive alerts.</summary>
     */
    public class Contact : BaseEntity
    {
        [Required, Display(Name = "First Name")]
        public string FirstName { get; set; }

        /*
         * LastName is not required for Contacts because a Contact may not
         * correspond to an actual person. It could be used by/for a
         * service, for example.
         */
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required, Display(Name = "Email")]
        public string EmailAddress { get; set; }

        [Required, Display(Name = "Phone")]
        public string PhoneNumber { get; set; }

        public int Owner { get; set; }

    }
}
