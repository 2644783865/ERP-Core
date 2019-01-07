﻿using ErpCore.Entities;
using InventoryService.Repos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.Repos.Interfaces
{
    public interface IPurchaseReturnRepository : IRepo<PurchaseReturn>
    {
        IEnumerable<PurchaseReturn> GetPurchaseReturnsByMonth(DateTime date);
    }
}
