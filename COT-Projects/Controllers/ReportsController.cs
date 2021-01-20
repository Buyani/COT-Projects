

//Remove this
using COT_Projects.Business.ReportBusiness;
using COT_Projects.Data.Entities;
using COT_Projects.Data.Persistance;
using COT_Projects.Model.Models;
using COT_Projetcs.Service.ReportRepository;
//*



using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COT_Projects.Controllers
{
    public class ReportsController : Controller
    {
        // GET: ReportsController

        private readonly IReportBusiness reportbusiness;

        public ReportsController(IReportBusiness reportbusiness)
        {
            this.reportbusiness = reportbusiness;
        }
        public async Task<ActionResult> Index()
        {
            var list = await reportbusiness.GetAllReportsAsync();
            return View(list);
        }
        // GET: ReportsController/Create
        public ActionResult CreateReport()
        {
            var report = new ReportModel();
            return View(report);
        }

        // POST: ReportsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateReport(Report data)
        {
            try
            {
                if(data!=null)
                {
                    await reportbusiness.AddReportAsync(data);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
