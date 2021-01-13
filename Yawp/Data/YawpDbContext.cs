using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Yawp.Models;

namespace Yawp.Data
{
    public class YawpDbContext : DbContext
    {
        public YawpDbContext(DbContextOptions<YawpDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Team> Teams { get; set; }
    }
}
