using CapaDato.Models;
using CapaDato.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.IServices
{
    public interface IservicesRole
    {
        Task<List<RoleViewModel>> GetAsync();
        Task<Role> AddAsync(Role model);
        Task<RoleViewModel> Edit(RoleViewModel model);
        Task<string> Delete(int id);
    }
}
