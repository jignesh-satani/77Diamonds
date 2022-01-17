using _77Diamonds.ViewModel;

namespace _77Diamonds.Services
{
    public interface IItemService
    {
        List<ItemMasterViewModel> GetAll();
        List<ItemDetailsViewModel> GetItemDetailView(int itemId);
        void AddPicture(ItemDetailsViewModel model);
    }
}
