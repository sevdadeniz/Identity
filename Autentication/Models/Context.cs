using Microsoft.EntityFrameworkCore;

namespace Autentication.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=SEVDENIZ;Database= Auth;Trusted_Connection=True");
            
        }


        public  DbSet<Admin>Admins { get; set; }

    }
}
