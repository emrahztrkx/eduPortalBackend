using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using educationPortal.Configuration;

namespace educationPortal.Web.Host.Startup
{
    [DependsOn(
       typeof(educationPortalWebCoreModule))]
    public class educationPortalWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public educationPortalWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(educationPortalWebHostModule).GetAssembly());
        }
    }
}
