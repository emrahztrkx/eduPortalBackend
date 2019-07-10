using Abp.Domain.Entities.Auditing;

namespace educationPortal.Courses
{
    public class CourseAdvertisement  : FullAuditedEntity
    {
        public string Title { get; set; }
        
        // description
        public string Content { get; set; }
        
        public double ExpectedPrice { get; set; }
        
    }
}