using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using TrafficLawsTest.DataSource.Models;

namespace TrafficLawsTest.DataSource.Context
{
    public interface IDomainContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Role> Roles { get; set; }
        DbSet<Test> Tests { get; set; }
        DbSet<TestPart> TestParts { get; set; }
        DbSet<TestPartAnswer> TestPartAnswers{ get; set; }
        DbSet<UserTest> UserTests{ get; set; }

        DbEntityEntry<T> Entry<T>(T entity) where T : class;

        int SaveChanges();


    }
}