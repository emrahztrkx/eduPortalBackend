using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using educationPortal.MultiTenancy;

namespace educationPortal.Tickets
{
    public class Question: FullAuditedEntity
    {
        
        public string Title { get; set; }
        
        public string Content { get; set; }
        
        public QuestionType Type { get; set; }
        
        public int TenantId { get; set; }
        
        [ForeignKey(nameof(TenantId))]
        public virtual Tenant Tenant { get; set; }
        
        
        private ICollection<QuestionResponse> _responses;
        public virtual ICollection<QuestionResponse> Responses
        {
            get { return _responses ?? (_responses = new Collection<QuestionResponse>()); }
            protected set { _responses = value; }
        }
    }
}