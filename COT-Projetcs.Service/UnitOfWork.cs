using COT_Projects.Data.Persistance;
using COT_Projetcs.Service.CurrencyService;
using COT_Projetcs.Service.ReportService;
using System;
using System.Collections.Generic;
using System.Text;

namespace COT_Projetcs.Service
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly COT_ProjectDataContext _context;
        public UnitOfWork(COT_ProjectDataContext context)
        {
            _context = context;
            Currencies = new CurrencyRepository(_context);
            Reports = new ReportRepository(_context);
        }
        public ICurrencyRepository Currencies { get; private set; }
        public IReportRepository Reports { get; private set; }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
