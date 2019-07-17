using System;
using Abp.Application.Services.Dto;

namespace educationPortal.Courses.Dto
{
    public class UpdateCourseInput:EntityDto
    {
        public string CourseTitle { get; set; }
        public string CourseDescription { get; set; }
        public int CourseQuato { get; set; }
        public double CoursePrice { get; set; }
        public DateTime CourseStartDate { get; set; }
        public DateTime CourseEndDate { get; set; }
        public int CourseCategoryId { get; set; }
        public int CourseEducatorId { get; set; }
    }
}