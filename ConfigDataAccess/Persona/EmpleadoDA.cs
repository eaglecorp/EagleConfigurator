using ConfigBusinessEntity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ConfigUtilitarios;

namespace ConfigDataAccess.Persona
{
    public class EmpleadoDA
    {
        public List<PERt04_empleado> ListaEmpleado(int? id_estado = null)
        {
            var lista = new List<PERt04_empleado>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ? @"SELECT * FROM PERt04_empleado"
                                            : @"SELECT * FROM PERt04_empleado WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<PERt04_empleado>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista de Empleados: ", e.Message);
                }
            }
            return lista;
        }
        public long InsertarEmpleado(PERt04_empleado obj)
        {
            long id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.PERt04_empleado.Add(obj);
                    ctx.SaveChanges();
                    id = obj.id_empleado;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Insertar Empleado: ", e.Message);
                }
            }
            return id;

        }
        public void EliminarEmpleado(long id)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdInactivo;
                    string txt_estado = Estado.TxtInactivo;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE PERt04_empleado SET id_estado = @id_estado, txt_estado = @txt_estado Where id_empleado=@id";
                        cmd.Parameters.AddWithValue("@id_estado", id_estado);
                        cmd.Parameters.AddWithValue("@txt_estado", txt_estado);
                        cmd.Parameters.AddWithValue("@id", id);
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Eliminar Empleado: ", e.Message);
                }
            }
        }
        public void ActualizarEmpleado(PERt04_empleado actualizado)
        {
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var original = ctx.PERt04_empleado.Find(actualizado.id_empleado);
                    if (original != null && original.id_empleado > 0)
                    {
                        ctx.Entry(original).CurrentValues.SetValues(actualizado);
                        ctx.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Empleado: ", e.Message);
                }
            }
        }
        public PERt04_empleado EmpleadoXId(long id)
        {
            var obj = new PERt04_empleado();
            const string sentencia = "SELECT * FROM PERt04_empleado WHERE id_empleado=@id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<PERt04_empleado>(sentencia, new { id }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Empleado por ID: ", e.Message);
                }
            }
            return obj;
        }
        public PERt04_empleado EmpleadoXCod(string cod)
        {
            var obj = new PERt04_empleado();
            string sentencia = "SELECT * FROM PERt04_empleado WHERE cod_empleado=@cod";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<PERt04_empleado>(sentencia, new { cod }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Empleado por COD: ", e.Message);
                }
            }
            return obj;
        }
        public PERt04_empleado EmpleadoXIdMM(long id)
        {

            var obj = new PERt04_empleado();
            obj = EmpleadoXId(id);
            const string sentencia =
                    @"SELECT * FROM SNTt02_tipo_doc_identidad WHERE id_tipo_doc_identidad=@id_tipo_doc_identidad
                    SELECT * FROM MSTt07_estado_civil WHERE id_estado_civil=@id_estado_civil
                    SELECT * FROM SNTt15_via WHERE id_via=@id_via
                    SELECT * FROM SNTt16_zona WHERE id_zona=@id_zona
                    SELECT * FROM SNTt14_nacionalidad WHERE id_nacionalidad=@id_nacionalidad
                    SELECT * FROM SNTt33_distrito WHERE id_dist=@id_dist
                    SELECT * FROM SNTt03_entidad_financiera WHERE id_entidad_financiera=@id_entidad_financiera
                    SELECT * FROM SNTt17_tipo_trabajador WHERE id_tipo_trabajador=@id_tipo_trabajador
                    SELECT * FROM SNTt18_situacion_educativa WHERE id_situacion_educativa=@id_situacion_educativa
                    SELECT * FROM SNTt19_ocupacion WHERE id_ocupacion=@id_ocupacion
                    SELECT * FROM SNTt20_regimen_pensionario WHERE id_regimen_pensionario=@id_regimen_pensionario
                    SELECT * FROM SNTt21_condicion_laboral WHERE id_condicion_laboral=@id_condicion_laboral
                    SELECT * FROM SNTt22_periodo_remuneracion WHERE id_periodo_remuneracion=@id_periodo_remuneracion
                    SELECT * FROM SNTt23_salud_eps WHERE id_salud_eps=@id_salud_eps
                    SELECT * FROM SNTt24_situacion WHERE id_situacion=@id_situacion
                    SELECT * FROM SNTt25_motivo_baja WHERE id_motivo_baja=@id_motivo_baja
                    SELECT * FROM SNTt26_modalidad_formativa WHERE id_modalidad_formativa=@id_modalidad_formativa
                    SELECT * FROM SNTt28_suspencion_laboral WHERE id_suspencion_laboral=@id_suspencion_laboral
                    SELECT * FROM SNTt29_regimen_salud WHERE id_regimen_salud=@id_regimen_salud
                    SELECT * FROM SNTt30_regimen_laboral WHERE id_regimen_laboral=@id_regimen_laboral
                    SELECT * FROM CLIt07_especialidad_medica WHERE id_especialidad_medica=@id_especialidad_medica";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    var multi = cnn.QueryMultiple(sentencia, new
                    {
                        id_tipo_doc_identidad = obj.id_tipo_doc_identidad,
                        id_estado_civil = obj.id_estado_civil,
                        id_via = obj.id_via,
                        id_zona = obj.id_zona,
                        id_nacionalidad = obj.id_nacionalidad,
                        id_dist = obj.id_dist,
                        id_entidad_financiera = obj.id_entidad_financiera,
                        id_tipo_trabajador = obj.id_tipo_trabajador,
                        id_situacion_educativa = obj.id_situacion_educativa,
                        id_ocupacion = obj.id_ocupacion,
                        id_regimen_pensionario = obj.id_regimen_pensionario,
                        id_condicion_laboral = obj.id_condicion_laboral,
                        id_periodo_remuneracion = obj.id_periodo_remuneracion,
                        id_salud_eps = obj.id_salud_eps,
                        id_situacion = obj.id_situacion,
                        id_motivo_baja = obj.id_motivo_baja,
                        id_modalidad_formativa = obj.id_modalidad_formativa,
                        id_suspencion_laboral = obj.id_suspencion_laboral,
                        id_regimen_salud = obj.id_regimen_salud,
                        id_regimen_laboral = obj.id_regimen_laboral,
                        id_especialidad_medica = obj.id_especialidad_medica
                    });

                    var tipoDocIden = multi.Read<SNTt02_tipo_doc_identidad>().FirstOrDefault();
                    var estadoCivil = multi.Read<MSTt07_estado_civil>().FirstOrDefault();
                    var via = multi.Read<SNTt15_via>().FirstOrDefault();
                    var zona = multi.Read<SNTt16_zona>().FirstOrDefault();
                    var nacionalidad = multi.Read<SNTt14_nacionalidad>().FirstOrDefault();
                    var distrito = multi.Read<SNTt33_distrito>().FirstOrDefault();
                    var entFinan = multi.Read<SNTt03_entidad_financiera>().FirstOrDefault();
                    var tipTrab = multi.Read<SNTt17_tipo_trabajador>().FirstOrDefault();
                    var situacionEdu = multi.Read<SNTt18_situacion_educativa>().FirstOrDefault();
                    var ocupacion = multi.Read<SNTt19_ocupacion>().FirstOrDefault();
                    var regPen = multi.Read<SNTt20_regimen_pensionario>().FirstOrDefault();
                    var condLabor = multi.Read<SNTt21_condicion_laboral>().FirstOrDefault();
                    var periodoRem = multi.Read<SNTt22_periodo_remuneracion>().FirstOrDefault();
                    var saludEps = multi.Read<SNTt23_salud_eps>().FirstOrDefault();
                    var situacion = multi.Read<SNTt24_situacion>().FirstOrDefault();
                    var motivoBaja = multi.Read<SNTt25_motivo_baja>().FirstOrDefault();
                    var modFormativa = multi.Read<SNTt26_modalidad_formativa>().FirstOrDefault();
                    var suspLaboral = multi.Read<SNTt28_suspencion_laboral>().FirstOrDefault();
                    var regSalud = multi.Read<SNTt29_regimen_salud>().FirstOrDefault();
                    var regLaboral = multi.Read<SNTt30_regimen_laboral>().FirstOrDefault();
                    var espcMedica = multi.Read<CLIt07_especialidad_medica>().FirstOrDefault();

                    obj.SNTt02_tipo_doc_identidad = tipoDocIden;
                    obj.MSTt07_estado_civil = estadoCivil;
                    obj.SNTt15_via = via;
                    obj.SNTt16_zona = zona;
                    obj.SNTt14_nacionalidad = nacionalidad;
                    obj.SNTt33_distrito = distrito;
                    obj.SNTt03_entidad_financiera = entFinan;
                    obj.SNTt17_tipo_trabajador = tipTrab;
                    obj.SNTt18_situacion_educativa = situacionEdu;
                    obj.SNTt19_ocupacion = ocupacion;
                    obj.SNTt20_regimen_pensionario = regPen;
                    obj.SNTt21_condicion_laboral = condLabor;
                    obj.SNTt22_periodo_remuneracion = periodoRem;
                    obj.SNTt23_salud_eps = saludEps;
                    obj.SNTt24_situacion = situacion;
                    obj.SNTt25_motivo_baja = motivoBaja;
                    obj.SNTt26_modalidad_formativa = modFormativa;
                    obj.SNTt28_suspencion_laboral = suspLaboral;
                    obj.SNTt29_regimen_salud = regSalud;
                    obj.SNTt30_regimen_laboral = regLaboral;
                    obj.CLIt07_especialidad_medica = espcMedica;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Empleado MM por ID: ", e.Message);
                }
            }
            return obj;
        }
        public PERt04_empleado EmpleadoXEmail(string email)
        {
            var obj = new PERt04_empleado();
            string sentencia = "SELECT * FROM PERt04_empleado WHERE txt_email1=@email OR txt_email2=@email";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<PERt04_empleado>(sentencia, new { email }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Empleado por Email: ", e.Message);
                }
            }
            return obj;
        }
    }
}
