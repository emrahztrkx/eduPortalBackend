using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using educationPortal.Authorization.Users;

namespace educationPortal.Courses
{
    public class GivenCourse : FullAuditedEntity
    {
        
        public int CourseId { get; set; }
        
        public int EducatorId { get; set; }
        
        
        [ForeignKey(nameof(CourseId))]
        public virtual Course Course { get; set; }
        
        [ForeignKey(nameof(EducatorId))]
        public virtual  User Educator { get; set; }
    }
}