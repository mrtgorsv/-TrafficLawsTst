using System.Collections.Generic;
using System.Linq;
using TrafficLawsTest.DataSource.Context;
using TrafficLawsTest.DataSource.Models;

namespace TrafficLawsTest.DataSource.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<DomainContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "TrafficLawsTest.DataSource.Context.DomainContext"; 
        }

        protected override void Seed(DomainContext context)
        {
            AddUsers(context);
        }

        private void AddUsers(DomainContext context)
        {
            const string admin = "admin";
            if (context.Users.Any(u => u.Login.Equals(admin)))
            {
                
            }
            var adminUser = new User
            {
                Login = admin,
                Password = admin,
                Roles = new List<Role>()
            };
            var adminRole = new Role
            {
                Name = admin,
                Users = new List<User>()
            };
            adminRole.Users.Add(adminUser);
            adminUser.Roles.Add(adminRole);
            context.Users.Add(adminUser);
            context.Roles.Add(adminRole);
        }
    }
}
