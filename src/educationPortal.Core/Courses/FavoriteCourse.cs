using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using educationPortal.Authorization.Users;

namespace educationPortal.Courses
{
    public class FavoriteCourse :  FullAuditedEntity
    {
        
        public long UserId { get; set; }
        
        public int CourseId { get; set; }
        
        [ForeignKey(nameof(CourseId))]
        public virtual Course Course { get; set; }
        
        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; }
        
    }
}