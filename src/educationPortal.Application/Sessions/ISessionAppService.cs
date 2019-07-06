using System.Threading.Tasks;
using Abp.Application.Services;
using educationPortal.Sessions.Dto;

namespace educationPortal.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
