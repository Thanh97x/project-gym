using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Demotht.Authorization.Roles;
using Demotht.Authorization.Users;
using Demotht.MultiTenancy;
using NewProject.DbEntities;
using Demotht.DbEntities;
using Demotht.Models;

namespace Demotht.EntityFrameworkCore
{
    public class DemothtDbContext : AbpZeroDbContext<Tenant, Role, User, DemothtDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Student> Student { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }



        public DemothtDbContext(DbContextOptions<DemothtDbContext> options)
            : base(options)
        {
        }
    }
}
