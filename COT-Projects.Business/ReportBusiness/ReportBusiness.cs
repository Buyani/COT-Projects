using AutoMapper;
using COT_Projects.Data.Entities;
using COT_Projects.Model.Models;
using COT_Projetcs.Service.ReportRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace COT_Projects.Business.ReportBusiness
{
    public class ReportBusiness : IReportBusiness
    {
        private readonly IMapper _mapper;
        private readonly IReportRepository _reportRepository;

        public ReportBusiness(IReportRepository reportRepository,IMapper mapper)
        {
            this._reportRepository = reportRepository;
            this._mapper = mapper;
        }
        public async Task<Report> AddReportAsync(Report model)
        {
            var report = _mapper.Map<Report>(model);       
            return await _reportRepository.AddAsync(report); 
        }
        public async Task<List<Report>> GetAllReportsAsync()
        {
            return await _reportRepository.GetAllReportsAsync();
        }
        public async Task<Report> GetReportByIdAsync(int id)
        {
            return await _reportRepository.GetReportByIdAsync(id);
        }
    }
}
