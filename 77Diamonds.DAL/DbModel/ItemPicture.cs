using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _77Diamonds.DAL.DbModel
{
    public class ItemPicture
    {
        [Key]
        public int ItemPictureId { get; set; } = 0;
        
        [ForeignKey("ItemDetail")]
        public int ItemDetailId { get; set; } = 0;
        public string PictureFile { get; set; } = string.Empty;
        
        public virtual ItemDetail? ItemDetail { get; set; }
    }
}
