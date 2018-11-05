using System.Data.Entity;
using TrafficLawsTest.DataSource.Models;

namespace TrafficLawsTest.DataSource.Context
{
    public class DomainContext : DbContext , IDomainContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<TestPart> TestParts { get; set; }
        public virtual DbSet<TestPartAnswer> TestPartAnswers { get; set; }
        public virtual DbSet<UserTest> UserTests { get; set; }
    }
}