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
        public User(string firstName, string lastName, string username)
        {
            FirstName = firstName;
            LastName = lastName;
            Username = username;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string EmailAddress { get; set; }

        public string Username { get; set; }

        /// <summary>
        /// The Contact object linked to this User. By default all Users have an associated Contact with matching information.
        /// </summary>
        public Contact LinkedContact { get; set; }

        public int Id { get; }

    }
}
