using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yawp.Models
{
    public class Contact
    {
        public Contact(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Description { get; set; }

        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }

        public User LinkedUser { get; set; }

        public int Id { get; }

    }
}
