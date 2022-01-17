using _77Diamonds.DAL.DbModel;

namespace _77Diamonds.DAL.Repository
{
    public interface IItemDetailRepository : IRepository<ItemDetail>
    {
        int SaveItemDetail(ItemDetail model);
    }
}
