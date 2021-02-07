using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using Yawp.Data;

namespace Yawp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new YawpDbContext
                (serviceProvider.GetRequiredService<DbContextOptions<YawpDbContext>>());

            // Do not seed if entries already exist
            if (context.Users.Any() || context.Contacts.Any() || context.Teams.Any())
            {
                return;
            }

            // Seed Users first
            var users = new List<User>
                {
                    new User
                    {
                        FirstName = "John",
                        LastName = "Doe",
                        Username = "johndoe",
                        EmailAddress = "johndoe@example.com",
                        PhoneNumber = "1234567890"
                    },
                    new User
                    {
                        FirstName = "Jane",
                        LastName = "Doe",
                        Username = "janedoe",
                        EmailAddress = "janedoe@example.com",
                        PhoneNumber = "0123456789"
                    },
                    new User
                    {
                        FirstName = "Sergei",
                        LastName = "Prokofiev",
                        Username = "prokoserg",
                        EmailAddress = "prokoserg@example.com",
                        PhoneNumber = "9012345678"
                    }
                };

            // Seed Contacts and link to Users
            var contacts = new List<Contact>();
            foreach (var user in users)
            {
                var contact = new Contact
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    EmailAddress = user.EmailAddress,
                    PhoneNumber = user.PhoneNumber,
                    Owner = user.Id
                };
                user.LinkedContact = contact.Id;
                contacts.Add(contact);
            };

            // Seed a Team
            var team = new Team
            {
                Name = "First Team",
                Description = "The very first team, ever.",
                Owner = users[0].Id
            };


            // Added seeded Users, Contacts, and Teams to DB context
            context.Users.AddRange(users);
            context.Contacts.AddRange(contacts);
            context.Teams.Add(team);

            context.SaveChanges();
        }
    }
}
