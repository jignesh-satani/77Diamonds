using _77Diamonds.DAL.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _77Diamonds.DAL.Repository
{
    public class ColorMasterRepository : Repository<ColorMaster>, IColorMasterRepository
    {
        public ColorMasterRepository(ApplicationContext context) : base(context)
        {
        }
        private ApplicationContext myApplicationContext
        {
            get { return context as ApplicationContext; }
        }
        public List<ColorMaster> GetAll()
        {
            return context.ColorMaster.ToList();
        }
    }
}
