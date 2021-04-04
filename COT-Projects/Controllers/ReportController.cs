using COT_Projects.Business.CurrencyBusiness;
using COT_Projects.Business.ReportBusiness;
using COT_Projects.Model.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COT_Projects.Controllers
{
    [Authorize]
    public class ReportController : Controller
    {
        private readonly IReportBusiness _reportbusiness;
        private readonly ICurrencyBusiness _currencybusiness;

        public ReportController(IReportBusiness reportbusiness, ICurrencyBusiness currencybusiness)
        {
            this._reportbusiness = reportbusiness;
            this._currencybusiness = currencybusiness;
        }
        // GET: ReportController/Create
        public ActionResult Create()
        {
            var report = new ReportModel
            {
                Currencies = _currencybusiness.GetAllCurrenciesAsync()
            };
            return View(report);
        }

        // POST: ReportController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ReportModel model)
        {
            model.Currencies = _currencybusiness.GetAllCurrenciesAsync();
            try
            {
                if (model != null)
                {
                    await _reportbusiness.AddReportAsync(model);
                }
                return RedirectToAction("Reports", "Currency",new {currencyid=1 });
            }
            catch
            {
                model.Currencies = _currencybusiness.GetAllCurrenciesAsync();
                return View(model);
            }
        }
    }
}
