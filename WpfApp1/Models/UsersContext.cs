using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataBase.Models
{
    public class UsersContext : DbContext
    {
        public UsersContext() : base("DefaultConnection")
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
