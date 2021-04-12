using WebStore.Domain.Entities.Interfaces;

namespace WebStore.Domain.Entities.Base
{
    public class Brand : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }
    }
}
