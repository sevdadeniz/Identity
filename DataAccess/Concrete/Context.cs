using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=SEVDENIZ;Database= WebSite;Trusted_Connection=True");

        }


        public DbSet<Admin> Admins { get; set; }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Personel> Personels { get; set; }

    }
}
