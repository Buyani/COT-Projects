using COT_Projects.Data.Entities;
using COT_Projects.Data.Persistance;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COT_Projetcs.Service.ReportRepository
{
    public class ReportRepository : Repository<Report>, IReportRepository
    {
        public ReportRepository(COT_ProjectDataContext context) 
            : base(context)
        {
        }
        public async Task<List<Report>> GetAllReportsAsync()
        {
            return await GetAll().ToListAsync();
        }
        public async Task<Report> GetReportByIdAsync(int id)
        {
            return await GetAll().FirstOrDefaultAsync(p => p.Id.Equals(id));
        }
    }
}
