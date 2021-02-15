using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Yawp.Models;

namespace Yawp.Data
{
    public class YawpDbContext : DbContext
    {
        public YawpDbContext(DbContextOptions<YawpDbContext> options) : base(options) { }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Team> Teams { get; set; }

        /*
         * AddTimestamps and the overrides for SaveChanges and SaveChangesAsync have been
         * adapted for this software from the following post on adding creation and modification
         * timestamps: https://benjii.me/2014/03/track-created-and-modified-fields-automatically-with-entity-framework-code-first/
         */
        public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            AddTimestamps();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            AddTimestamps();
            return base.SaveChangesAsync(cancellationToken);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            AddTimestamps();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        private void AddTimestamps()
        {
            foreach (var entity in ChangeTracker.Entries())
            {
                if (entity.Entity is BaseEntity && (entity.State != EntityState.Unchanged))
                {
                    DateTime? created = ((BaseEntity)entity.Entity).DateCreated;
                    var now = DateTime.UtcNow;

                    // Always set DateModified, set DateCreated only when adding new objects
                    if (entity.State == EntityState.Added)
                    {
                        ((BaseEntity)entity.Entity).DateCreated = now;

                    }
                    ((BaseEntity)entity.Entity).DateModified = now;
                }
            }
        }
    }
}
