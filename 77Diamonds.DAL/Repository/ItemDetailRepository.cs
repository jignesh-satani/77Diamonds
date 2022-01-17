using _77Diamonds.DAL.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _77Diamonds.DAL.Repository
{
    public class ItemDetailRepository : Repository<ItemDetail>, IItemDetailRepository
    {
        public ItemDetailRepository(ApplicationContext context) : base(context)
        {
        }
        private ApplicationContext myApplicationContext
        {
            get { return context as ApplicationContext; }
        }

        public int SaveItemDetail(ItemDetail model)
        {
            myApplicationContext.ItemDetail.Add(model);
            myApplicationContext.SaveChanges();
            return model.ItemDetailId;
        }
    }
}
