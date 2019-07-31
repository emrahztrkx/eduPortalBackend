using Abp.Application.Services.Dto;

namespace educationPortal.Courses.Dto
{
    public class GetCategoryOutput:EntityDto
    {
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public int? ParentCategoryId { get; set; }
    }
}