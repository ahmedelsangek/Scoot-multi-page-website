using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer__DAL_
{
    public class AppIdentityUser : IdentityUser
    {
    }

    public class AppUserStore : UserStore<AppIdentityUser>
    {
        public AppUserStore() : base(new ApplicationDBContext()) { }
        public AppUserStore(DbContext d) : base(d) { }
    }

    

    public class AppUserManager : UserManager<AppIdentityUser>
    {
        public AppUserManager() : base(new AppUserStore()) { }
        public AppUserManager(DbContext d) : base(new AppUserStore(d)) { }
    }

    public class AppRoleManager : RoleManager<IdentityRole>
    {
        public AppRoleManager() : base(new RoleStore<IdentityRole>(new ApplicationDBContext()))
        {

        }
        public AppRoleManager(DbContext db)
            : base(new RoleStore<IdentityRole>(db))
        {

        }
    }

    public class Order
    {
        public int Id { get; set; }
        public string date { get; set; }
        public string Description { get; set; }
        public int totalPrice { get; set; }
        public int discount { get; set; }
        public virtual AppIdentityUser appUser { get; set; }
    }

    public class type { }

    public class ApplicationDBContext : IdentityDbContext<AppIdentityUser>
    {

        public ApplicationDBContext() : base("Data Source=.;Initial Catalog=ECommDB; Integrated Security=True")
        {

        }
        public virtual DbSet<Order> Orders { get; set; }
    }
}                    
