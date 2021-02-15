using System.ComponentModel.DataAnnotations;

namespace Yawp.Models
{
    /**
     * <summary>
     * An entity used to group Contacts together. 
     * Teams cannot contain the same Contact twice, but a Contact may be a member of multiple Teams.
     * </summary>
     */
    public class Team : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public int Owner { get; set; }
    }
}
