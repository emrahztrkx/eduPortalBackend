using Abp.MultiTenancy;
using educationPortal.Authorization.Users;

namespace educationPortal.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
        
        
        
        
    }
}
