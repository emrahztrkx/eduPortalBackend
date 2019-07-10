using Abp.Domain.Entities.Auditing;

namespace educationPortal.Courses
{
    public class CourseContent : FullAuditedEntity
    {
        // Video veya gorsel olabilir.
        public string ContentPath { get; set; }
        
        // video, pdf, image
        public ContentType ContentType { get; set; }
    }
}