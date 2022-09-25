using Microsoft.EntityFrameworkCore;
using EmpresaTec.App.Dominio;

namespace EmpresaTec.App.Persistencia
{
    public class ApplicationContext : DbContext
    {
        public DbSet<ActualState> ActualStates { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Services> services { get; set; }
        public DbSet<User> users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=TECPRODES");    
                
            }
        }

    
    }

}