using WebStore.Domain.Entities.Interfaces;

namespace WebStore.Domain.Entities.Base
{
    public abstract class Entity : IEntity
    {
        public int id { get ; set ; }
    }
}
