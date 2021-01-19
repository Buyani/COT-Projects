using COT_Projects.Data.Entities;
using COT_Projects.Data.Persistance;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace COT_Projetcs.Service.ReportRepository
{
    public interface IReportRepository : IRepository<Report>
    {
        Task<Report> GetReportByIdAsync(int id);
        Task<List<Report>> GetAllReportsAsync();
    }
}
