using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yawp.Models
{
    public class Team
    {
        public Team(string name, User owner)
        {
            Name = name;
            Owner = owner;
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public User Owner { get; set; }

        public List<User> Managers { get; set; }

        public int Id { get; }
    }
}
