namespace Yawp.Models
{
    /// <summary>
    /// A Team contains member Contacts that can be alerted.
    /// </summary>
    public class Team
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Owner { get; set; }
    }
}
