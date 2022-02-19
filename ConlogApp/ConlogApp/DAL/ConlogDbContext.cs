using ConlogApp.DAL.EntityModels;
using Microsoft.EntityFrameworkCore;

namespace ConlogApp.DAL
{
    public class ConlogDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=ConlogDb; User ID=AdminUser;Password=P@55word;MultipleActiveResultSets=True");
        }

        public virtual DbSet<Customer> Customers { get; set; }
    }
}
