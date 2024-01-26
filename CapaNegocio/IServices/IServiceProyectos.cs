using CapaDato.Models;
using CapaDato.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.IServices
{
    public interface IServiceProyectos
    {
        Task<List<ProyectoViewModel>> GetAssync();
        Task<Proyectos> AddAsync(Proyectos model);
        Task<ProyectoViewModel> EditAsync(ProyectoViewModel model);
        Task<string> Delete(int id);
    }
}
