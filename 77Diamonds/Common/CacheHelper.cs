using _77Diamonds.DAL.DbModel;
using _77Diamonds.Services;
using _77Diamonds.ViewModel;
using Microsoft.Extensions.Caching.Memory;

namespace _77Diamonds.Common
{
    public interface ICacheHelper
    {
        IEnumerable<ColorMasterViewModel> GetColors();
        IEnumerable<FabricMasterViewModel> GetFabrics();
    }
    public class CacheHelper: ICacheHelper
    {
        private readonly IMemoryCache _memoryCache;
        private readonly IMasterTableService _masterTableService;
        private readonly string _cachedColors = "cachedColors";
        private readonly string _cachedFabrics = "cachedFabrics";


        public CacheHelper(IMemoryCache memoryCache, IMasterTableService iMasterTableService)
        {
            _memoryCache = memoryCache;
            _masterTableService = iMasterTableService;
        }
        public IEnumerable<ColorMasterViewModel> GetColors()
        {
            if (!_memoryCache.TryGetValue(_cachedColors, out IEnumerable<ColorMasterViewModel> colorList))
            {
                //calling the server
                colorList = _masterTableService.GetColors();

                //setting up cache options
                var cacheExpiryOptions = new MemoryCacheEntryOptions()
                                         .SetSlidingExpiration(TimeSpan.FromSeconds(3600));
                _memoryCache.Set(_cachedColors, colorList.ToList(), cacheExpiryOptions);
            }
            return colorList;
        }
        public IEnumerable<FabricMasterViewModel> GetFabrics()
        {
            if (!_memoryCache.TryGetValue(_cachedFabrics, out IEnumerable<FabricMasterViewModel> fabricList))
            {
                //calling the server
                fabricList = _masterTableService.GetFabrics();

                //setting up cache options
                var cacheExpiryOptions = new MemoryCacheEntryOptions()
                                         .SetSlidingExpiration(TimeSpan.FromSeconds(3600));
                _memoryCache.Set(_cachedFabrics, fabricList.ToList(), cacheExpiryOptions);
            }
            return fabricList;
        }
    }
}
