using _77Diamonds.DAL.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _77Diamonds.DAL.Repository
{
    public class FabricMasterRepository : Repository<FabricMaster>, IFabricMasterRepository
    {
        public FabricMasterRepository(ApplicationContext context) : base(context)
        {
        }
        public List<FabricMaster> GetAll()
        {
            return context.FabricMaster.ToList();
        }
    }
}
