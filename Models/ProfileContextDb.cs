using App.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace App.Models
{

    public class ProfileContextDb : IdentityDbContext<ApplicationUser>
    {
        public ProfileContextDb(DbContextOptions<ProfileContextDb> options) : base(options)
        {

        }

       
       
        public DbSet<ApplicationUser> User { get; set; }

    }
}

