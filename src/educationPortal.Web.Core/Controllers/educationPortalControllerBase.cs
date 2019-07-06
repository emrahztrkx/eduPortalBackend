using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace educationPortal.Controllers
{
    public abstract class educationPortalControllerBase: AbpController
    {
        protected educationPortalControllerBase()
        {
            LocalizationSourceName = educationPortalConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
