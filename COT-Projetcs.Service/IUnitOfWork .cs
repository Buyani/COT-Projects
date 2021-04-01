using COT_Projetcs.Service.CurrencyService;
using COT_Projetcs.Service.ReportService;
using System;
using System.Collections.Generic;
using System.Text;

namespace COT_Projetcs.Service
{
    public interface IUnitOfWork: IDisposable
    {
        ICurrencyRepository Currencies { get; }
        IReportRepository Reports { get; }
        int Complete();
    }
}
