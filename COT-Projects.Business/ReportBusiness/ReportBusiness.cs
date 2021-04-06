using AutoMapper;
using COT_Projects.Data.Entities;
using COT_Projects.Model.Models;
using COT_Projects.Model.ViewModels;
using COT_Projetcs.Service;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COT_Projects.Business.ReportBusiness
{
    public class ReportBusiness : IReportBusiness
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ReportBusiness(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task AddReportAsync(ReportModel model)
        {
            var report = _mapper.Map<Report>(model);
            report.Netpositions = GetNetPositions(model.Long, model.Short);
            await _unitOfWork.Reports.AddAsync(report);
            _unitOfWork.Complete();
        }
        public List<ReportViewModel> GetAllReportsAsyncByCurrency(int currencyid)
        {
            var list = _unitOfWork.Reports.GetAll();
            return list.Where(p=>p.CurrencyId.Equals(currencyid)).Select(_mapper.Map<Report, ReportViewModel>).ToList();
        }

        private static int GetNetPositions(int longp,int shortp)
        {
            return longp - shortp;
        }
    }
}
