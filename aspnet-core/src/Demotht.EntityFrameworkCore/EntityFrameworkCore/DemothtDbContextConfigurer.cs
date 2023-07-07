using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Demotht.EntityFrameworkCore
{
    public static class DemothtDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DemothtDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DemothtDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
