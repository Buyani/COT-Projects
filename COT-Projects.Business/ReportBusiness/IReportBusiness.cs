using COT_Projects.Data.Entities;
using COT_Projects.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace COT_Projects.Business.ReportBusiness
{
    public interface IReportBusiness 
    {
        Task<List<Report>> GetAllReportsAsync();
        Task<Report> GetReportByIdAsync(int id);
        Task<Report> AddReportAsync(Report newreport);
    }
}
