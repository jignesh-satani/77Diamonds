using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _77Diamonds.DAL.DbModel
{
    public class ItemDetail
    {
        public ItemDetail()
        {
            this.ItemPicture = new HashSet<ItemPicture>();
        }
        [Key]
        public int ItemDetailId { get; set; } = 0;
        
        [ForeignKey("ItemMaster")]
        public int ItemId { get; set; } = 0;
        
        [ForeignKey("FabricMaster")]
        public byte FabricId { get; set; } = 0;
        
        [ForeignKey("ColorMaster")]
        public byte ColorId { get; set; } = 0;

        public virtual ColorMaster? ColorMaster { get; set; }
        public virtual FabricMaster? FabricMaster { get; set; }
        public virtual ItemMaster? ItemMaster { get; set; }
        public virtual ICollection<ItemPicture> ItemPicture { get; set; }
    }
}
