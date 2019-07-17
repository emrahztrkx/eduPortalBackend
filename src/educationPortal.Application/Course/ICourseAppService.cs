using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using educationPortal.Courses.Dto;

namespace educationPortal.Courses
{
    public interface ICourseAppService
    {
        Task<List<CourseDto>> GetAll();
        Task<CourseDto> Create(CreateCourseInputDto input);
        Task Update(UpdateCourseInput input);
        Task Delete(EntityDto input);
    }
}