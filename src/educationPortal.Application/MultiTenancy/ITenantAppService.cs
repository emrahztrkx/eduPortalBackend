using Abp.Application.Services;
using Abp.Application.Services.Dto;
using educationPortal.MultiTenancy.Dto;

namespace educationPortal.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

