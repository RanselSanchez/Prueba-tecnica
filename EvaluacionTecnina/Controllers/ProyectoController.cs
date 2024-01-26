using CapaDato.Models;
using CapaDato.ViewModel;
using CapaNegocio.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace EvaluacionTecnina.Controllers
{
    public class ProyectoController : Controller
    {
        readonly IServiceProyectos _proyectoServices;
        public ProyectoController(IServiceProyectos proyecto)
        {
            _proyectoServices = proyecto;
        }

         [HttpGet]
        [Route("GetProyectos")]
        public async Task<List<ProyectoViewModel>> Get()
        {

            return await _proyectoServices.GetAssync();

        }

        [HttpPost]
        [Route("PostProyectos")]
        public async Task<Proyectos> Add(Proyectos Proyectos)
        {
            return await _proyectoServices.AddAsync(Proyectos);
        }

        [HttpPut]
        [Route("PutProyectos")]
        public async Task<ProyectoViewModel> update(ProyectoViewModel proyecto)
        {
            return await _proyectoServices.EditAsync(proyecto);
        }

        [HttpDelete]
        [Route("DeleteProyectos/{id}")]
        public async Task<string> Delete(int id)
        {
            return await _proyectoServices.Delete(id);
        }
    }
}