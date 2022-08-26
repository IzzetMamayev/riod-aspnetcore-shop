using Microsoft.EntityFrameworkCore;
using RiodShopCore.Entities;

namespace RiodShopCore.Data
{
    public class RiodDbContext : DbContext
    {
        public RiodDbContext() : base()
        {

        }

        public RiodDbContext(DbSet<Contact> contacts)
        {
            Contacts = contacts;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server = IZZET; Database = RiodWithGit; Trusted_Connection = True;");
            }
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
