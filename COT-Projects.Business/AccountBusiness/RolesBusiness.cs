using COT_Projects.Model.Models;
using COT_Projects.Model.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COT_Projects.Business.AccountBusiness
{
    public class RolesBusiness : IRolesBusiness
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public RolesBusiness(RoleManager<IdentityRole> roleManager)
        {

            _roleManager = roleManager;
        }
        public async Task AddRole(RoleModel model)
        {
            if (model.Name != null)
            {
                await _roleManager.CreateAsync(new IdentityRole(model.Name.Trim()));
            }
        }

        public async Task<ICollection<RoleViewModel>> RolesList()
        {
            var list= await _roleManager.Roles.ToListAsync();
            return list.Select(p => new RoleViewModel { Name = p.Name,Id=p.Id }).ToList();
        }
    }
}
