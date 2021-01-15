using System;
using System.ComponentModel.DataAnnotations;

namespace Yawp.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateModified { get; set; }
    }
}
