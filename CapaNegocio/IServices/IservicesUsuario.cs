
using CapaDato.Models;
using CapaDato.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.IServices
{
    public interface IservicesUsuario
    {
        Task<List<UsuarioViewModel>> GetAssync();
        Task<Usuario> AddAsync(Usuario model);
        Task<UsuarioViewModel> EditAsync(UsuarioViewModel model);
        Task<string> Delete(int id);
       
    }
}
