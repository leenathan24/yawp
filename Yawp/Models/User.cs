using System.ComponentModel.DataAnnotations;

namespace Yawp.Models
{
    /// <summary>
    /// A simple User object for end users of the application.
    /// </summary>
    public class User
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Phone")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Email")]
        public string EmailAddress { get; set; }

        public string Username { get; set; }

        [Display(Name = "Linked Contact")]
        public int LinkedContact { get; set; }

    }
}
