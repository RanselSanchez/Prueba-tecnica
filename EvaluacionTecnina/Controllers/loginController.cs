
using CapaDato.ViewModel;
using CapaNegocio.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EvaluacionTecnina.Controllers
{
    public class loginController : ApiController
    {
        readonly Iserviceslogin _loginServices;
        public loginController(Iserviceslogin log)
        {
            _loginServices = log;
        }

        [HttpGet]
        [Route("login")]
        public string Get(Login model)
        {
            
             return _loginServices.Get(model);
            
        }

    }
}
