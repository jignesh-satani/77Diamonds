using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _77Diamonds.DAL.DbModel
{
    public class FabricMaster
    {
        public FabricMaster()
        {
            this.ItemDetail = new HashSet<ItemDetail>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte FabricId { get; set; } = 0;
        public string FabricName { get; set; } = string.Empty;
        public virtual ICollection<ItemDetail> ItemDetail { get; set; }
    }
}
