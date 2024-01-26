using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDato.Models;
using CapaDato.ViewModel;
using CapaNegocio.IServices;

namespace CapaNegocio.Services
{
    public class UsuarioServices : IservicesUsuario
    {
         private readonly EvaluacionTecnicaDBContext _db;
        public UsuarioServices(EvaluacionTecnicaDBContext db)
        {
            _db = db;
        }

        public async Task<List<UsuarioViewModel>> GetAssync()
        {
            try
            {
                var lst = await (from d in _db.Usuarios
                                 where d.Id == d.Id
                                 select new UsuarioViewModel
                                 {
                                     Id=d.Id,
                                     Nombre = d.Nombre,
                                     apellido = d.apellido,
                                     Cedula = d.Cedula,
                                     Usuario_nombre = d.Usuario_nombre,
                                     Contrasena = d.Contrasena,
                                     Fecha_Nacimiento = d.Fecha_Nacimiento,
                                     Usuario_transaccion = d.Usuario_transaccion,
                                     Fecha_Transaccionn = d.Fecha_Transaccionn,
                                     RoleId = d.RoleId
                                 }).ToListAsync();

                return lst;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
           
        }

        public async Task<Usuario> AddAsync(Usuario model)
        {
            try
            {
                model.Usuario_transaccion = "USER";
                model.Fecha_Transaccionn = DateTime.Now;
                _db.Usuarios.Add(model);
                await _db.SaveChangesAsync();
                return model;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
           
            
        }

        public async Task<UsuarioViewModel> EditAsync(UsuarioViewModel model)
        {
            try
            {


                Usuario usuario = _db.Usuarios.Find(model.Id);

                usuario.Nombre = model.Nombre;
                usuario.apellido = model.apellido;
                usuario.Cedula = model.Cedula;
                usuario.Usuario_nombre = model.Usuario_nombre;
                usuario.Contrasena = model.Contrasena;
                usuario.Fecha_Nacimiento = model.Fecha_Nacimiento;
                usuario.Usuario_transaccion = "USER";
                usuario.Fecha_Transaccionn = DateTime.Now;
                usuario.RoleId = model.RoleId;


                _db.Entry(usuario).State = EntityState.Modified;
                await _db.SaveChangesAsync();

                return model;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public async Task<string> Delete(int id)
        {
            try
            {
                Usuario usuario = _db.Usuarios.Find(id);
                _db.Usuarios.Remove(usuario);
                await _db.SaveChangesAsync();
                return "los Datos se han eliminado";
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
           
        }


    }
}
