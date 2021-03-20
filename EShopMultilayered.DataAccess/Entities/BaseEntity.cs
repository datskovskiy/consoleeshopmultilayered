using EShopMultilayered.DataAccess.Interfaces;

namespace EShopMultilayered.DataAccess.Entities
{
    public abstract class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
    }
}