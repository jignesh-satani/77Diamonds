using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _77Diamonds.DAL.DbModel
{
    public class ItemDetailsView
    {
        public string ColorName { get; set; }=string.Empty;
        public string FabricName { get; set; } = string.Empty;
        public string PictureFile { get; set; } = string.Empty;

        public string ItemCode { get; set; } = string.Empty;
        public string ItemName { get; set; } = string.Empty;

        public int ItemDetailId { get; set; } = 0;
        public int ItemId { get; set; } = 0;
        public byte ColorId { get; set; } = 0;
        public byte FabricId { get; set; } = 0;



    }
}
