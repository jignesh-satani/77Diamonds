using _77Diamonds.DAL.DbModel;

namespace _77Diamonds.DAL.Repository
{
    public class ItemPictureRepository: Repository<ItemPicture>, IItemPictureRepository
    {
        public ItemPictureRepository(ApplicationContext context) : base(context)
        {
        }
        private ApplicationContext myApplicationContext
        {
            get { return context as ApplicationContext; }
        }
    }
}
