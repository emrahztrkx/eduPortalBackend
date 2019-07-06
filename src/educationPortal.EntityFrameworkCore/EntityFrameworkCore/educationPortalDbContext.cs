using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using educationPortal.Authorization.Roles;
using educationPortal.Authorization.Users;
using educationPortal.MultiTenancy;

namespace educationPortal.EntityFrameworkCore
{
    public class educationPortalDbContext : AbpZeroDbContext<Tenant, Role, User, educationPortalDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public educationPortalDbContext(DbContextOptions<educationPortalDbContext> options)
            : base(options)
        {
        }
    }
}
