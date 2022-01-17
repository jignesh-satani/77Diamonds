using _77Diamonds.DAL.DbModel;

namespace _77Diamonds.DAL.Repository
{
    public interface IColorMasterRepository: IRepository<ColorMaster>
    {
        List<ColorMaster> GetAll();
    }
}
