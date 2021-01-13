using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yawp.Models
{
    /// <summary>
    /// A Contact represents a person or service that can receive alerts.
    /// </summary>
    public class Contact
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Description { get; set; }

        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }

        public int OwnedBy { get; set; }

    }
}
