using System.Threading.Tasks;
using Abp.Application.Services;
using educationPortal.Authorization.Accounts.Dto;

namespace educationPortal.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
