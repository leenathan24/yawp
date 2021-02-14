﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yawp.Models
{
    /**
     * <summary>
     * An entity for end users to login to the application as.
     * This class is used purely for end user authentication and cannot receive alerts.
     * </summary>
     */
    public class User : BaseEntity
    {

        [Required, Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required, Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Phone")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Email")]
        public string EmailAddress { get; set; }

        [Required]
        public string Username { get; set; }

        public int ContactId { get; set; }

        [Display(Name = "Linked Contact")]
        [ForeignKey("ContactId")]
        public Contact Contact { get; set; }

    }
}
