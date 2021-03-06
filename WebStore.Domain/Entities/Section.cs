using WebStore.Domain.Entities.Interfaces;

namespace WebStore.Domain.Entities.Base
{
    public class Section : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }

        public int? ParentId { get; set; }
    }
}
