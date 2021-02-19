using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Yawp.Models;
using Yawp.Utilities;

namespace Yawp.Data
{
    public class YawpDbContext : IdentityDbContext
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

        /// <summary>
        /// Set DateCreated and DateModified timestamps for entities with those properties.
        /// </summary>
        private void AddTimestamps()
        {
            foreach (var entity in ChangeTracker.Entries())
            {
                if (GeneralUtil.HasTimestamps(entity.Entity) && (entity.State != EntityState.Unchanged))
                {
                    var now = GeneralUtil.Now();
                    var entityType = entity.Entity.GetType();

                    // Always set DateModified, set DateCreated only when adding new objects
                    if (entity.State == EntityState.Added)
                    {
                        PropertyInfo created = entityType.GetProperty("DateCreated");
                        created.SetValue(entity.Entity, now);

                    }
                    PropertyInfo modified = entityType.GetProperty("DateModified");
                    modified.SetValue(entity.Entity, now);
                }
            }
        }
    }
}
