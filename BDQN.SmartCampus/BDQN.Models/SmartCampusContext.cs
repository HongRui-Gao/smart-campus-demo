using System.Data.Entity;

namespace BDQN.Models
{
    public class SmartCampusContext : DbContext
    {
        public SmartCampusContext()
            :base("name=DbCon")
        {

        }

        public DbSet<Roles> Roles { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<SystemMenus> SystemMenus { get; set; }

    }
}
