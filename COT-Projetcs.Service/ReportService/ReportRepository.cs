using COT_Projects.Data.Entities;
using COT_Projects.Data.Persistance;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COT_Projetcs.Service.ReportService
{
    public class ReportRepository : Repository<Report>, IReportRepository
    {
        public ReportRepository(COT_ProjectDataContext context) 
            : base(context)
        {
        }

    }
}
