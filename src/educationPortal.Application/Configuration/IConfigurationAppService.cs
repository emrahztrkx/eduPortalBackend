using System.Threading.Tasks;
using educationPortal.Configuration.Dto;

namespace educationPortal.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
