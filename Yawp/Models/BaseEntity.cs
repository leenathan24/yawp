using System;
using System.ComponentModel.DataAnnotations;

namespace Yawp.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public string Description { get; set; }

        [Display(Name = "Created")]
        public DateTime? DateCreated { get; set; }

        [Display(Name = "Modified")]
        public DateTime? DateModified { get; set; }
    }
}
