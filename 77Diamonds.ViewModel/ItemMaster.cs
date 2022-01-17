
namespace _77Diamonds.ViewModel
{
    public class ItemMasterViewModel
    {
        public ItemMasterViewModel()
        {
            this.ItemDetailViewModel = new HashSet<ItemDetailViewModel>();
        }
        public int ItemId { get; set; } = 0;
        public string ItemCode { get; set; } = string.Empty;
        public string ItemName { get; set; } = string.Empty;
        public int ColorTotal { get; set; } = 0;
        public int FabricTotal { get; set; } = 0;
        public int PictureTotal { get; set; } = 0;


        public virtual ICollection<ItemDetailViewModel> ItemDetailViewModel { get; set; }

    }
}
