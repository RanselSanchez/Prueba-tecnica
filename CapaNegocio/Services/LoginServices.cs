
using CapaDato.Models;
using CapaDato.ViewModel;
using CapaNegocio.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Services
{
    public class LoginServices : Iserviceslogin
    {
        private readonly EvaluacionTecnicaDBContext _db;
        public LoginServices(EvaluacionTecnicaDBContext db)
        {
            _db = db;
        }

        public string Get(Login model)
        {
            try
            {
                var log = _db.Usuarios.Where(s => s.Usuario_nombre.Equals(model.usuario) && s.Contrasena.Equals(model.contrasena));
                if (log.Count() > 0)
                {
                    return "Inicio de seccion, Bienvendio al home";

                }
                else
                {
                    throw new Exception("Credenciales incorrectas");

                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            

        }
    }
}
