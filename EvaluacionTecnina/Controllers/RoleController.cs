
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
    public class RoleController : ApiController
    {
        readonly IservicesRole _roleServices;
        public RoleController(IservicesRole role)
        {
            _roleServices = role;
        }

        [HttpGet]
        [Route("GetRole")]
        public async Task<List<RoleViewModel>> Get()
        {
            return await _roleServices.GetAsync();
        }

        [HttpPost]
        [Route("PostRole")]
        public async Task<Role> Add(Role model)
        {
            return await _roleServices.AddAsync(model);
        }

        [HttpPut]
        [Route("PutRole")]
        public async Task<RoleViewModel> Edit(RoleViewModel model)
        {
            return await _roleServices.Edit(model);
        }

        [HttpDelete]
        [Route("DeleteRole/{id}")]
        public async Task<string> Delete(int id)
        {
            return await _roleServices.Delete(id);
        }

    }
}
