using System;
using Abp.Application.Services.Dto;

namespace educationPortal.Courses.Dto
{
    public class CourseDto:EntityDto
    {
        public string CourseTitle { get; set; }
        public string CourseDescription { get; set; }
        public int CourseQuato { get; set; }
        public double CoursePrice { get; set; }
        public DateTime CourseStartDate { get; set; }
        public DateTime CourseEndDate { get; set; }
        public string CourseCategoryName { get; set; }
        public string CourseContentPath { get; set; }
        
    }
}