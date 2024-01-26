
using CapaDato.Models;
using CapaDato.ViewModel;
using CapaNegocio.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace EvaluacionTecnina.Controllers
{
    public class UsuarioController : ApiController
    {
        readonly IservicesUsuario _usuarioServices;
        public UsuarioController(IservicesUsuario usuario)
        {
            _usuarioServices = usuario;
        }

        [HttpGet]
        [Route("GetUsuario")]
        public async Task<List<UsuarioViewModel>> Get()
        {
           
            return await _usuarioServices.GetAssync();
            
        }

        [HttpPost]
        [Route("PostUsuario")]
        public async Task<Usuario> Add(Usuario usuario)
        {
            return await _usuarioServices.AddAsync(usuario);
        }

        [HttpPut]
        [Route("PutUsuario")]
        public async Task<UsuarioViewModel> update(UsuarioViewModel usuario)
        {
            return await _usuarioServices.EditAsync(usuario);
        }

        [HttpDelete]
        [Route("DeleteUsuario/{id}")]
        public async Task<string> Delete(int id)
        {
            return await _usuarioServices.Delete(id);
        }







    }
}
