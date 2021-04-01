using COT_Projects.Model.Models;
using COT_Projects.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace COT_Projects.Business.ReportBusiness
{
    public interface IReportBusiness
    {
        List<ReportViewModel> GetAllReportsAsyncByCurrency(int currencyid);
        Task AddReportAsync(ReportModel model);
    }
}
