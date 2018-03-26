using ConfigBusinessEntity;
using ConfigUtilitarios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConfigDataAccess.Labor
{
    public class TrabajoEmpleadoDA
    {
        public long InsertarTrabajoEmpleado(LABt07_emp_trabajo obj)
        {
            long id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.LABt07_emp_trabajo.Add(obj);
                    ctx.SaveChanges();
                    id = obj.id_empleado;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Insertar Trabajo Empleado: ", e.Message);
                }
            }
            return id;
        }

        public bool ActualizarTrabajoEmpleado(LABt07_emp_trabajo actualizado)
        {
            bool success = false;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var original = ctx.LABt07_emp_trabajo.Find(actualizado.id_emp_trabajo);
                    if (original != null && original.id_emp_trabajo > 0)
                    {
                        ctx.Entry(original).CurrentValues.SetValues(actualizado);
                        ctx.SaveChanges();
                        success = true;
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Trabajo Empleado: ", e.Message);
                }
            }
            return success;
        }

        public bool DesactivarTrabajoEmpleado(long idTrabajoEmpleado)
        {
            bool success = false;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var original = ctx.LABt07_emp_trabajo.Find(idTrabajoEmpleado);
                    if (original != null && original.id_emp_trabajo > 0)
                    {
                        var actualizado = original;
                        actualizado.id_estado = Estado.IdInactivo;
                        actualizado.txt_estado = Estado.TxtInactivo;
                        ctx.Entry(original).CurrentValues.SetValues(actualizado);
                        ctx.SaveChanges();
                        success = true;
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Desactivar Trabajo Empleado: ", e.Message);
                }
            }
            return success;
        }

        public List<LABt07_emp_trabajo> ListaTrabajoXEmpleado(long idEmpleado)
        {
            var lista = new List<LABt07_emp_trabajo>();
            var estado = Estado.IdActivo;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    lista = ctx.LABt07_emp_trabajo.
                                Include(x => x.LABt06_trabajo).
                                Where(x => x.id_empleado == idEmpleado && x.id_estado == estado).
                                ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Trabajo Empleado: ", e.Message);
                }
            }
            return lista;
        }

        public bool ExisteTrabajoEmpleado(long idEmpleado, int idTrabajo)
        {
            bool exist = true;
            var estado = Estado.IdActivo;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    exist = ctx.LABt07_emp_trabajo.Any(x => x.id_empleado == idEmpleado &&
                                                            x.id_trabajo == idTrabajo &&
                                                            x.id_estado == estado);
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Existe Trabajo Empleado: ", e.Message);
                }
            }
            return exist;
        }

        public LABt07_emp_trabajo GetTrabajoEmpleado(long idEmpleado, int idTrabajo)
        {
            var trabajoEmpleado = new LABt07_emp_trabajo();
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    trabajoEmpleado = ctx.LABt07_emp_trabajo.
                                                            FirstOrDefault(x => x.id_empleado == idEmpleado &&
                                                                                x.id_trabajo == idTrabajo);
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Get Trabajo Empleado: ", e.Message);
                }
            }
            return trabajoEmpleado;
        }

    }
}
