using _77Diamonds.DAL.DbModel;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace _77Diamonds.DAL.Repository
{
    public class ItemRepository : Repository<ItemMaster>, IItemRepository
    {
        public ItemRepository(ApplicationContext context)
            : base(context)
        {
        }
        private ApplicationContext myApplicationContext
        {
            get { return context as ApplicationContext; }
        }
        public List<ItemMaster> GetAll()
        {
            return myApplicationContext.ItemMaster
                .Include(a => a.ItemDetail)
                .ThenInclude(a => a.ColorMaster)
                .Include(a => a.ItemDetail)
                .ThenInclude(a => a.FabricMaster)
                .Include(a => a.ItemDetail)
                .ThenInclude(a => a.ItemPicture)
                .ToList();
        }
        public List<ItemDetailsView> GetItemDetailView(int itemId)
        {
            var parameters = new[] {
                new SqlParameter("@ItemId", SqlDbType.Int) { Direction = ParameterDirection.Input, Value = itemId } };

            List<ItemDetailsView> list = myApplicationContext.ItemDetailsView.FromSqlRaw("exec dbo.GetItemDetails @ItemId"
                  , parameters
               ).ToList();

            return list;

        }
    }
}
