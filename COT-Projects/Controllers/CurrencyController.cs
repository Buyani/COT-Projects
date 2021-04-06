using COT_Projects.Business.CurrencyBusiness;
using COT_Projects.Business.ReportBusiness;
using COT_Projects.Model.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace COT_Projects.Controllers
{
    [Authorize]
    public class CurrencyController : Controller
    {
        // GET: CurrencyController
        private readonly ICurrencyBusiness _currencybusiness;
        private readonly IReportBusiness _reportbusiness;

        public CurrencyController(IReportBusiness reportbusiness, ICurrencyBusiness currencybusiness)
        {
            this._currencybusiness = currencybusiness;
            this._reportbusiness = reportbusiness;
        }
        [Authorize(Roles = "Admin")]
        public ActionResult Currencies()
        {
            var currencieslist = _currencybusiness.GetAllCurrenciesAsync();
            return View(currencieslist);
        }
        public ActionResult Reports(int currencyid)
        {
            dynamic mymodel = new ExpandoObject();
            mymodel.Currencies = _currencybusiness.GetAllCurrenciesAsync();
            return View(mymodel);
        }
        public JsonResult GetReportDataJson(int currencyid)
        {
            var data = _reportbusiness.GetAllReportsAsyncByCurrency(currencyid);

            return Json(data);
        }
        // GET: ReportsController/Create
        [Authorize(Roles = "Admin")]
        public ActionResult CreateCurrnecy()
        {
            var currency = new CurrencyModel();
            return View(currency);
        }

        // POST: ReportsController/Create
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateCurrnecy(CurrencyModel model)
        {
            try
            {
                if (model != null)
                {
                    await _currencybusiness.AddCurrencyAsync(model);
                }
                return RedirectToAction(nameof(Currencies));
            }
            catch
            {
                return View();
            }
        }
    }
}
