using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _77Diamonds.DAL.DbModel
{
    public class ColorMaster
    {
        public ColorMaster()
        {
            this.ItemDetail = new HashSet<ItemDetail>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte ColorId { get; set; } = 0;
        public string ColorName { get; set; } = string.Empty;
        public virtual ICollection<ItemDetail> ItemDetail { get; set; }
    }
}
