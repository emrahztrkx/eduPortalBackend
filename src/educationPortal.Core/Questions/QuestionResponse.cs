using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;

namespace educationPortal.Tickets
{
    public class QuestionResponse : FullAuditedEntity
    {
        public string Content { get; set; }
        
        public int QuestionId { get; set; }
        
        [ForeignKey(nameof(QuestionId))]
        public virtual  Question Question { get; set; }
    }
}