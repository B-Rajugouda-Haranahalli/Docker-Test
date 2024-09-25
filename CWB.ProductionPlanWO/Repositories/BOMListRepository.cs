﻿using CWB.CommonUtils.Common.Repositories;
using CWB.ProductionPlanWO.Domain;
using CWB.ProductionPlanWO.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CWB.ProductionPlanWO.Repositories
{
    public class BOMListRepository : Repository<BOMList>, IBOMListRepository
    {
        public BOMListRepository(WODbContext context)
       : base(context)
        {

        }
    }
}
