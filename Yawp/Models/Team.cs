﻿using System;
using System.ComponentModel.DataAnnotations;
using Yawp.Utilities;

namespace Yawp.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }

        public string Description { get; set; }

        [Display(Name = "Created")]
        public DateTime? DateCreated { get; set; }

        [Display(Name = "Modified")]
        public DateTime? DateModified { get; set; }

        [Required]
        public string Name { get; set; }

        public int Owner { get; set; }
    }
}
