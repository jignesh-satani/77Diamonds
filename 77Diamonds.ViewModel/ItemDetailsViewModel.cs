namespace _77Diamonds.ViewModel
{
    public class ItemDetailsViewModel
    {
        public string ColorName { get; set; } = string.Empty;
        public string FabricName { get; set; } = string.Empty;
        public string PictureFile { get; set; } = string.Empty;
        public string ItemCode { get; set; } = string.Empty;
        public string ItemName { get; set; } = string.Empty;

        public int ItemDetailId { get; set; } = 0;
        public int ItemId { get; set; } = 0;
        public byte ColorId { get; set; } = 0;
        public byte FabricId { get; set; } = 0;

        public int ColorTotal { get; set; } = 0;
        public int FabricTotal { get; set; } = 0;
        public int PictureTotal { get; set; } = 0;

    }
}
