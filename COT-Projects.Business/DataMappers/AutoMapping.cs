using AutoMapper;
using COT_Projects.Data.Entities;
using COT_Projects.Model.Models;
using COT_Projects.Model.ViewModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace COT_Projects.Business.DataMappers
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Report, ReportModel>(); // means you want to map from User to UserDTO
            CreateMap<ReportModel,Report > ();
            CreateMap<Report, ReportViewModel>();

            CreateMap<CurrencyModel, Currency>();

            CreateMap<Currency, CurrencyModelView>();


            CreateMap<ApplicationUser, UserViewModel>();
        }
    }
}
