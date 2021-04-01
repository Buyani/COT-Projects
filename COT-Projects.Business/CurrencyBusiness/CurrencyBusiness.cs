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

namespace COT_Projects.Business.CurrencyBusiness
{
    public class CurrencyBusiness : ICurrencyBusiness
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;


        public CurrencyBusiness(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task AddCurrencyAsync(CurrencyModel model)
        {
            var currency = _mapper.Map<Currency>(model);
            await _unitOfWork.Currencies.AddAsync(currency);
            _unitOfWork.Complete();
        }

        public List<CurrencyModelView> GetAllCurrenciesAsync()
        {
            var list =  _unitOfWork.Currencies.GetAll().Include(p => p.Reports);
            return  list.Select(_mapper.Map<Currency, CurrencyModelView>).ToList();
        }
    }
}
