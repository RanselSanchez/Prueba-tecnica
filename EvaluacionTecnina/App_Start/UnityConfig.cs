
using CapaDato.Models;
using CapaNegocio.IServices;
using CapaNegocio.Services;
using System.Data.Entity;
using System.Web.Http;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace EvaluacionTecnina
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<DbContext, EvaluacionTecnicaDBContext>();
            container.RegisterType<IservicesUsuario, UsuarioServices>();
            container.RegisterType<IservicesRole, RoleServices>();
            container.RegisterType<Iserviceslogin, LoginServices>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }
    }
}