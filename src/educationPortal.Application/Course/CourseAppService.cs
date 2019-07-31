using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.UI;
using educationPortal.Categories;
using educationPortal.Courses.Dto;
using Microsoft.EntityFrameworkCore;

namespace educationPortal.Courses
{
    public class CourseAppService:educationPortalAppServiceBase,ICourseAppService
    {
        private readonly IRepository<Course> _courseRepository;
        private readonly IRepository<GivenCourse> _givenCourseRepository;
        private readonly IRepository<CourseContent> _courseContentRepository;
        private readonly IRepository<Categories.Category> _categoryRepository;




        public CourseAppService(
            IRepository<Course> courseRepository,
            IRepository<GivenCourse> givenCourseRepository,
            IRepository<CourseContent> courseContentRepository,  
            IRepository<Categories.Category> categoryRepository

        )

        {
            _courseRepository = courseRepository;
            _givenCourseRepository = givenCourseRepository;
            _courseContentRepository = courseContentRepository;
            _categoryRepository = categoryRepository;
        }

        public async Task<CourseDto> Create(CreateCourseInputDto input)
        {
            var courseContentId =  _courseContentRepository.InsertAndGetId(new CourseContent
            {
                ContentType = input.ContentType,
                ContentPath = ""
            });
                
            var courseId =  _courseRepository.InsertAndGetId(new Course
            {
                Title = input.CourseTitle,
                Description = input.CourseDescription,
                Quota = input.CourseQuato,
                StartDate = input.CourseStartDate,
                EndDate = input.CourseStartDate,
                Price = input.CoursePrice,
                CategoryId = input.CourseCategoryId,
                CourseContentId = courseContentId
            });

            await _givenCourseRepository.InsertAsync(new GivenCourse
            {
                EducatorId = input.CourseEducatorId,
                CourseId = courseId
            });
            return new CourseDto();
        }

        public async Task<List<CourseDto>>  GetAll()
        {
            var allCourses = await _courseRepository.GetAll().Include(p=>p.Category).Select(p=>new CourseDto
            {
                Id = p.Id,
                CoursePrice = p.Price,
                CourseStartDate = p.StartDate,
                CourseEndDate = p.EndDate,
                CourseDescription = p.Description,
                CourseTitle = p.Title,
                CourseCategoryName = p.Category.DisplayName,
                CourseQuato = p.Quota,
                CourseContentPath = p.CourseContent.ContentPath
            }).ToListAsync();
            return allCourses;
        }
        
        public async Task<List<GetCategoryOutput>> GetAllCategories()
        {
            var categories = await _categoryRepository.GetAll().Select(x => new GetCategoryOutput
            {
                Id = x.Id,
                DisplayName = x.DisplayName,
                Description = x.Description,
                ParentCategoryId = x.ParentCategoryId
            }).ToListAsync();

            return categories;
        }
        

        public async Task Update(UpdateCourseInput input)
        {
            var isExistCourse = await _courseRepository.GetAll().AnyAsync(x => x.Id == input.Id);
            if (!isExistCourse)
                throw new UserFriendlyException(L("DontExistCourse"));

            var course = await _courseRepository.GetAll().FirstAsync(x => x.Id == input.Id);
            
            course.CategoryId = input.CourseCategoryId;
            course.Description = input.CourseDescription;
            course.Title = input.CourseTitle;
            course.Price = input.CoursePrice;
            course.Quota = input.CourseQuato;
            course.StartDate = input.CourseStartDate;
            course.EndDate = input.CourseEndDate;
            
            await _courseRepository.UpdateAsync(course);
        }

        public async Task Delete(EntityDto input)
        { 
            var course = await _courseRepository.GetAsync(input.Id);
            await _courseRepository.DeleteAsync(course);
            
        }

      
        
    }
}