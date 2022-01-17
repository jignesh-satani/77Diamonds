﻿using _77Diamonds.DAL.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _77Diamonds.DAL.Repository
{
    public interface IFabricMasterRepository: IRepository<FabricMaster>
    {
        List<FabricMaster> GetAll();
    }
}
