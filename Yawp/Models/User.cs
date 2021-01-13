using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yawp.Models
{
    /// <summary>
    /// A simple User object for end users of the application.
    /// </summary>
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string EmailAddress { get; set; }

        public string Username { get; set; }

        public int LinkedContact { get; set;  }

    }
}
