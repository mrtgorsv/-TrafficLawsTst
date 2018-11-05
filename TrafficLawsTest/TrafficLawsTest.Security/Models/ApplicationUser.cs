using System.Collections.Generic;

namespace TrafficLawsTest.Security.Models
{
    public class ApplicationUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<ApplicationRole> Roles { get; set; }

        public ApplicationUser()
        {
            Roles = new List<ApplicationRole>();
        }
    }
}
