using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using educationPortal.MultiTenancy;

namespace educationPortal.Courses
{
    public class CourseAdvertisementReply : FullAuditedEntity, IMustHaveTenant
    {
        // kurs ilanina karsi yazilan yorum/icerik
        public string Content { get; set; }
        
        // fiyat teklifi
        public double Bid { get; set; }


        public int TenantId { get; set; }
        
        [ForeignKey(nameof(TenantId))]
        public virtual  Tenant Tenant { get; set; }
    }
}