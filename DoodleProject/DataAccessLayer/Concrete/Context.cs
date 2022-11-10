using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context: DbContext
    {
        public Context()
        {
            Database.Connection.ConnectionString = "Server=PC;Database=DoodleDb;integrated security=True";
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
