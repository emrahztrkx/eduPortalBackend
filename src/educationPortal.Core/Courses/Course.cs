using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using educationPortal.Categories;
using educationPortal.MultiTenancy;

namespace educationPortal.Courses
{
    public class Course : FullAuditedEntity , IMustHaveTenant
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Quota { get; set; }
        public double Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TenantId { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey(nameof(TenantId))]
        public virtual Tenant Tenant { get; set; }
        
        [ForeignKey(nameof(CategoryId))]
        public virtual Category Category { get; set; }
        
        
        private ICollection<GivenCourse> _givingCourses;
        public virtual ICollection<GivenCourse> GivingCourses
        {
            get { return _givingCourses ?? (_givingCourses = new Collection<GivenCourse>()); }
            protected set { _givingCourses = value; }
        }
    }
}