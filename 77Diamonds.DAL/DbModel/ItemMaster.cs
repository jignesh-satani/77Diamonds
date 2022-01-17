using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _77Diamonds.DAL.DbModel
{

    public class ItemMaster
    {
        public ItemMaster()
        {
            this.ItemDetail = new HashSet<ItemDetail>();
        }
        [Key]
        public int ItemId { get; set; } = 0;
        public string ItemCode { get; set; } = string.Empty;
        public string ItemName { get; set; } = string.Empty;

        public virtual ICollection<ItemDetail> ItemDetail { get; set; }

    }
}
