using App.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.Entities
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        public ApplicationDbContext()
        {
        }

        public DbSet<Person> Persons { get; set; }

        public DbSet<Address> Address { get; set; }
    }
}