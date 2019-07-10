using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace educationPortal.Categories
{
    public class Category : Entity
    {
        // localization icin gerekebilir.
        public string DisplayName { get; set; }

        public string Description { get; set; }
        
        public int? ParentCategoryId { get; set; }
        
        
        [ForeignKey(nameof(ParentCategoryId))]
        public virtual Category ParentCategory { get; set; }
        
    }
}