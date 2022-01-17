using _77Diamonds.DAL;
using _77Diamonds.DAL.DbModel;
using _77Diamonds.DAL.Repository;
using _77Diamonds.ViewModel;
using AutoMapper;

namespace _77Diamonds.Services
{
    public class ItemService : IItemService
    {
        private IItemRepository _itemRepository;
        private IItemPictureRepository _itemPictureRepository;
        private IItemDetailRepository _itemDetailRepository;
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;


        public ItemService(ApplicationContext context, IMapper mapper)
        {
            _context = context;
            _itemRepository = new ItemRepository(_context);
            _itemPictureRepository = new ItemPictureRepository(_context);
            _itemDetailRepository = new ItemDetailRepository(_context);
            _mapper = mapper;
        }
        public List<ItemMasterViewModel> GetAll()
        {
            return _mapper.Map<List<ItemMasterViewModel>>(_itemRepository.GetAll());
        }
        public List<ItemDetailsViewModel> GetItemDetailView(int itemId)
        {
            return _mapper.Map<List<ItemDetailsViewModel>>(_itemRepository.GetItemDetailView(itemId));
        }
        public void AddPicture(ItemDetailsViewModel model)
        {
            if (model.ItemDetailId == 0)
            {
                ItemDetail item = new ItemDetail()
                {
                    ItemId = model.ItemId
                    ,
                    ColorId = model.ColorId
                    ,
                    FabricId = model.FabricId
                };
                model.ItemDetailId = _itemDetailRepository.SaveItemDetail(item);
            }
            ItemPicture picture = new ItemPicture() { ItemDetailId = model.ItemDetailId, PictureFile = model.PictureFile };
            _itemPictureRepository.Insert(picture);
            _itemPictureRepository.Save();
        }

    }
}
