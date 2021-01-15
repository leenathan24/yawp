using System.ComponentModel.DataAnnotations;

namespace Yawp.Models
{
    /// <summary>
    /// A Team contains member Contacts that can be alerted.
    /// </summary>
    public class Team : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public int Owner { get; set; }
    }
}
