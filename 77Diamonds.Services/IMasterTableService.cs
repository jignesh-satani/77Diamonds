using _77Diamonds.ViewModel;

namespace _77Diamonds.Services
{
    public interface IMasterTableService
    {
        List<ColorMasterViewModel> GetColors();
        List<FabricMasterViewModel> GetFabrics();
    }
}
