using System;
using Microsoft.EntityFrameworkCore;
using PeopleApi.Model;

namespace PeopleApi
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> dbContextOption) : base(dbContextOption)
        {
        }

        public DbSet<People> Persons { get; set; }

        // Use this in case you want to use PstgreSQL
        //protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        //    => dbContextOptionsBuilder.UseNpgsql("{ connection string }");
    }
}
