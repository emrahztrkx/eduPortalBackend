using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace educationPortal.EntityFrameworkCore
{
    public static class educationPortalDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<educationPortalDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<educationPortalDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
