using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _77Diamonds.ViewModel
{
    public class ItemPictureViewModel
    {
        public int ItemPictureId { get; set; } = 0;
        public int ItemDetailId { get; set; } = 0;
        public string PictureFile { get; set; } = string.Empty;
        public virtual ItemDetailViewModel? ItemDetailViewModel { get; set; }

    }
}
