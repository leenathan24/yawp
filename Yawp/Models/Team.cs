using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Yawp.Models
{
    /// <summary>
    /// A Team contains member Contacts that can be alerted.
    /// </summary>
    public class Team
    {
        public Team(string name, User owner)
        {
            Name = name;
            Owner = owner;
        }

        public string Name { get; set; }

        public string Description { get; set; }

        /// <summary>
        /// The owning User object. Owners and Managers have modification privileges over a Team.
        /// </summary>
        public User Owner { get; set; }

        /// <summary>
        /// A list of non-owning Users to manage the Team. Owners and Managers have modification privileges over a Team.
        /// </summary>
        public List<User> Managers { get; set; }

        /// <summary>
        /// Members of the Team. Alerts sent to the Team will route to one or more member Contacts.
        /// </summary>
        public List<Contact> Members { get; set; }

        public int Id { get; }
    }
}
