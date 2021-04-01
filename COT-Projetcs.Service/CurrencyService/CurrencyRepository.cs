using COT_Projects.Data.Entities;
using COT_Projects.Data.Persistance;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COT_Projetcs.Service.CurrencyService
{
    public class CurrencyRepository : Repository<Currency>, ICurrencyRepository
    {
        public CurrencyRepository(COT_ProjectDataContext context)
            : base(context)
        {
        }
    }
}
