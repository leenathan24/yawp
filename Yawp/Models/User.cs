using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Yawp.Utilities;

namespace Yawp.Models
{
    public class User : IdentityUser
    {
        public string Description { get; set; }

        [Display(Name = "Created")]
        public DateTime? DateCreated { get; } = GeneralUtil.Now();

        [Display(Name = "Modified")]
        [ConcurrencyCheck]
        public DateTime? DateModified { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

    }
}
