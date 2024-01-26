using CapaNegocio.IServices;
using CapaDato.Models;
using CapaDato.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Services
{
    public class RoleServices : IservicesRole
    {
        private readonly EvaluacionTecnicaDBContext _db;
        public RoleServices(EvaluacionTecnicaDBContext db)
        {
            _db = db;
        }

        public async Task<List<RoleViewModel>> GetAsync()
        {
            try
            {
                var lst = await (from d in _db.Roles
                                 where d.RoleId == d.RoleId
                                 select new RoleViewModel
                                 {
                                     RoleId = d.RoleId,
                                     nombre = d.nombre,
                                     Usuario_transaccion = d.Usuario_transaccion,
                                     Fecha_Transaccionn = d.Fecha_Transaccionn
                                 }).ToListAsync();

                return lst;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
           
        }

        public async Task<Role>AddAsync( Role model)
        {
            try
            {
                model.Usuario_transaccion = "USER";
                model.Fecha_Transaccionn = DateTime.Now;
                _db.Roles.Add(model);
                await _db.SaveChangesAsync();
                return model;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
           

        }

        public async Task<RoleViewModel> Edit(RoleViewModel model)
        {
            try
            {
                
                Role role = _db.Roles.Find(model.RoleId);
                role.RoleId = model.RoleId;
                role.nombre = model.nombre;
                role.Usuario_transaccion = "USER";
                role.Fecha_Transaccionn = DateTime.Now;

                _db.Entry(role).State = EntityState.Modified;
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
                Role role = _db.Roles.Find(id);
                _db.Roles.Remove(role);
                await _db.SaveChangesAsync();
                return "se han eliminado los datos";

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

           
        }
    }
}
