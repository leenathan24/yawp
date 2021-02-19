using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using Yawp.Models;
using Yawp.Data;

namespace Yawp.Utilities
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            YawpDbContext context = new YawpDbContext
                (serviceProvider.GetRequiredService<DbContextOptions<YawpDbContext>>());

            // Do not seed if entries already exist
            if (context.Contacts.Any() || context.Teams.Any())
            {
                return;
            }

            var contacts = new List<Contact>
                {
                    new Contact
                    {
                        FirstName = "John",
                        LastName = "Doe",
                        Email = "johndoe@example.com",
                        PhoneNumber = "5234567890"
                    },
                    new Contact
                    {
                        FirstName = "Jane",
                        LastName = "Doe",
                        Email = "janedoe@example.com",
                        PhoneNumber = "2123456789"
                    },
                    new Contact
                    {
                        FirstName = "Sergei",
                        LastName = "Prokofiev",
                        Email = "prokoserg@example.com",
                        PhoneNumber = "9212345678"
                    }
                };

            var team = new Team
            {
                Name = "First Team",
                Description = "The very first team, ever.",
            };


            // Add seeded Contacts, and Teams to DB context
            context.Contacts.AddRange(contacts);
            context.Teams.Add(team);

            context.SaveChanges();
        }
    }
}
