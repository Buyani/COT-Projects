using COT_Projects.Data.Entities;
using COT_Projects.Model.Models;
using COT_Projects.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace COT_Projects.Business.CurrencyBusiness
{
    public interface ICurrencyBusiness
    {
        List<CurrencyModelView> GetAllCurrenciesAsync();
        Task AddCurrencyAsync(CurrencyModel model);
    }
}
