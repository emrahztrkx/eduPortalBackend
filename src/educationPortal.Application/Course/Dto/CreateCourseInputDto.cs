using System;

namespace educationPortal.Courses.Dto
{
    public class CreateCourseInputDto
    {
        public string CourseTitle { get; set; }
        public string CourseDescription { get; set; }
        public int CourseQuato { get; set; }
        public double CoursePrice { get; set; }
        public DateTime CourseStartDate { get; set; }
        public DateTime CourseEndDate { get; set; }

        public ContentType ContentType { get; set; }
        public int CourseCategoryId { get; set; }
        public long CourseEducatorId { get; set; }
    }
}