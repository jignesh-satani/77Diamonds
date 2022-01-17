using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _77Diamonds.ViewModel
{
    public class ItemDetailViewModel
    {
        public ItemDetailViewModel()
        {
            this.ItemPictureViewModel = new HashSet<ItemPictureView>();
        }
        public int ItemDetailId { get; set; } = 0;

        public int ItemId { get; set; } = 0;

        public byte FabricId { get; set; } = 0;

        public byte ColorId { get; set; } = 0;


        public virtual ColorMasterViewModel? ColorMasterViewModel { get; set; }

        public virtual FabricMasterViewModel? FabricMasterViewModel { get; set; }

        public virtual ItemMasterViewModel? ItemMasterViewModel { get; set; }
        public virtual ICollection<ItemPictureView> ItemPictureViewModel { get; set; }
    }
}
