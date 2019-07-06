using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using educationPortal.Roles.Dto;
using educationPortal.Users.Dto;

namespace educationPortal.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
