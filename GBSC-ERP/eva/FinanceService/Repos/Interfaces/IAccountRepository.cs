﻿using ErpCore.Entities.Finance;
using FinanceService.Repos.Base;
using FinanceService.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceService.Repos.Interfaces
{
    public interface IAccountRepository : IRepo<Account>
    {
        string ConfigureComanyFinanceDetails(CompanyFinanceConfigurationViewModel model);
    }
}
