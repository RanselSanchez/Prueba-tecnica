using CapaDato.Models;
using CapaDato.ViewModel;
using CapaNegocio.IServices;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Services
{
    public class ProyectoService : IServiceProyectos
    {
        private readonly EvaluacionTecnicaDBContext _db;
        public ProyectoService(EvaluacionTecnicaDBContext db)
        {
            _db = db;
        }

        public async Task<List<ProyectoViewModel>> GetAssync()
        {
            try
            {
                var lst = await (from d in _db.proyectos
                                 where d.Id == d.Id
                                 select new ProyectoViewModel
                                 {
                                     Id = d.Id,
                                     Proyecto = d.Proyecto,
                                     Descripcion = d.Descripcion,
                                     Usuario_transaccion = d.Usuario_transaccion,
                                     Fecha_Transaccionn = d.Fecha_Transaccionn,
                                     usuarioId = d.usuarioId
                                 }).ToListAsync();

                return lst;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public async Task<Proyectos> AddAsync(Proyectos model)
        {
            try
            {
                model.Usuario_transaccion = "USER";
                model.Fecha_Transaccionn = DateTime.Now;
                _db.proyectos.Add(model);
                await _db.SaveChangesAsync();
                return model;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }


        }

        public async Task<ProyectoViewModel> EditAsync(ProyectoViewModel model)
        {
            try
            {


                Proyectos proyecto = _db.proyectos.Find(model.Id);

                proyecto.Proyecto = model.Proyecto;
                proyecto.Descripcion = model.Descripcion;
                proyecto.Usuario_transaccion = "USER";
                proyecto.Fecha_Transaccionn = DateTime.Now;
                proyecto.usuarioId = model.usuarioId;


                _db.Entry(proyecto).State = EntityState.Modified;
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
                Proyectos proyecto = _db.proyectos.Find(id);
                _db.proyectos.Remove(proyecto);
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
