using Abp.Domain.Entities.Auditing;

namespace educationPortal.Configuration
{
    public class Comment : FullAuditedEntity
    {

        // tenant, user,  vs vs...
        public string EntityName { get; set; }

        public long EntityId { get; set; }
        
        public string Comment { get; set; }
        
        
        // oylama icin kullanilir. 5 uzerinden. B
        // baska kullaniclar bu yoruma puan verirken de + 4 gibi deger girilerek Rate/RateCount 
        public double Rate { get; set; }
        
        // kac kisinin buraya oy verdigini yazar. Ilk comment yapilirken 1 ile baslar kendisi oy verir.
        public double RateCount { get; set; }
        
        
        
    }
}