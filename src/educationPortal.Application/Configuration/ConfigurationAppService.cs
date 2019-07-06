using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using educationPortal.Configuration.Dto;

namespace educationPortal.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : educationPortalAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
