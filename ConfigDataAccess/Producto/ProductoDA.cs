using ConfigBusinessEntity;
using ConfigUtilitarios;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ConfigDataAccess
{
    public class ProductoDA
    {
        public List<PROt09_producto> ListaProducto(int? id_estado = null)
        {
            var lista = new List<PROt09_producto>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ? @"SELECT * FROM PROt09_producto"
                                            : @"SELECT * FROM PROt09_producto WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<PROt09_producto>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista de Productos: ", e.Message);
                }
            }
            return lista;
        }
        public long InsertarProducto(PROt09_producto obj)
        {
            long id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.PROt09_producto.Add(obj);
                    ctx.SaveChanges();
                    id = obj.id_producto;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Insertar Producto: ", e.Message);
                }
            }
            return id;

        }
        public void EliminarProducto(long id)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdInactivo;
                    string txt_estado = Estado.TxtInactivo;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE PROt09_producto SET id_estado = @id_estado, txt_estado = @txt_estado Where id_producto=@id";
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
                    log.ArchiveLog("ELiminar Producto: ", e.Message);
                }
            }
        }
        public bool ActivarProducto(long id)
        {
            bool success = false;
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdActivo;
                    string txt_estado = Estado.TxtActivo;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE PROt09_producto SET id_estado = @id_estado, txt_estado = @txt_estado Where id_producto=@id";
                        cmd.Parameters.AddWithValue("@id_estado", id_estado);
                        cmd.Parameters.AddWithValue("@txt_estado", txt_estado);
                        cmd.Parameters.AddWithValue("@id", id);
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        success = true;
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("ELiminar Producto: ", e.Message);
                }
            }
            return success;
        }


        public void ActualizarPrecioProdEnCboVarDtl(long idProducto, decimal? nuevoPrecioConTax, decimal? nuevoPrecioSinTax)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdInactivo;
                    string txt_estado = Estado.TxtInactivo;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE PROt16_combo_variable_dtl SET mto_pvpu_sin_tax = @pvpu_sin_tax, mto_pvpu_con_tax = @pvpu_con_tax Where id_producto=@id_producto";
                        cmd.Parameters.AddWithValue("@pvpu_con_tax", nuevoPrecioConTax);
                        cmd.Parameters.AddWithValue("@pvpu_sin_tax", nuevoPrecioSinTax);
                        cmd.Parameters.AddWithValue("@id_producto", idProducto);
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Precio de Prod. en Cbo. Var. Dtl: ", e.Message);
                }
            }
        }
        public void ActualizarProducto(PROt09_producto prodActualizado)
        {
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var original = ctx.PROt09_producto.Find(prodActualizado.id_producto);
                    if (original != null && original.id_producto > 0)
                    {
                        if (prodActualizado.mto_pvpu_con_igv != original.mto_pvpu_con_igv ||
                            prodActualizado.mto_pvpu_sin_igv != original.mto_pvpu_sin_igv)
                        {
                            //Actualizar precios en los cbo var dtl y cbo dtl
                            ActualizarPrecioProdEnCboVarDtl(prodActualizado.id_producto, prodActualizado.mto_pvpu_con_igv, prodActualizado.mto_pvpu_sin_igv);

                        }
                        ctx.Entry(original).CurrentValues.SetValues(prodActualizado);
                        ctx.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Producto: ", e.Message);
                }
            }
        }
        public PROt09_producto ProductoXId(long id)
        {
            var oProducto = new PROt09_producto();
            string sentencia = "SELECT * FROM PROt09_producto WHERE id_producto=@id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    oProducto = cnn.Query<PROt09_producto>(sentencia, new { id }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Producto por ID: ", e.Message);
                }
            }
            return oProducto;

        }
        public PROt09_producto ProductoXCod(string cod)
        {
            var obj = new PROt09_producto();
            string sentencia = "SELECT * FROM PROt09_producto WHERE cod_producto=@cod";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<PROt09_producto>(sentencia, new { cod }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Producto por COD: ", e.Message);
                }
            }
            return obj;
        }
        public PROt09_producto ProductoXCod2(string cod)
        {
            var obj = new PROt09_producto();
            string sentencia = "SELECT * FROM PROt09_producto WHERE cod_producto2=@cod";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<PROt09_producto>(sentencia, new { cod }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Producto por COD2: ", e.Message);
                }
            }
            return obj;
        }
        public PROt09_producto ProductoXCodBarra(string cod)
        {
            var obj = new PROt09_producto();
            string sentencia = "SELECT * FROM PROt09_producto WHERE cod_barra=@cod";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<PROt09_producto>(sentencia, new { cod }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Producto por Código de Barra: ", e.Message);
                }
            }
            return obj;
        }
        public PROt09_producto ProductoXIdMM(long id)
        {
            var obj = new PROt09_producto();
            obj = ProductoXId(id);
            const string sentencia =
                    @"SELECT * FROM PROt04_subfamilia WHERE id_subfamilia=@id_subfamilia
                    SELECT * FROM SNTt06_unidad_medida WHERE id_um=@id_um
                    SELECT * FROM PROt02_modelo WHERE id_modelo=@id_modelo
                    SELECT * FROM MSTt06_impuesto WHERE id_impuesto=@id_impuesto
                    SELECT * FROM SNTt04_tipo_moneda WHERE id_tipo_moneda=@id_tipo_moneda
                    SELECT * FROM SNTt05_tipo_existencia WHERE id_tipo_existencia=@id_tipo_existencia
                    SELECT * FROM PROt07_tipo_prod WHERE id_tipo_prod=@id_tipo_prod
                    SELECT * FROM PROt06_clase_prod WHERE id_clase_prod=@id_clase_prod
                    SELECT * FROM PROt10_receta WHERE id_receta=@id_receta
                    SELECT * FROM PROt13_combo WHERE id_combo=@id_combo";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    var multi = cnn.QueryMultiple(sentencia, new
                    {
                        id_subfamilia = obj.id_subfamilia,
                        id_um = obj.id_um,
                        id_modelo = obj.id_modelo,
                        id_impuesto = obj.id_impuesto,
                        id_tipo_moneda = obj.id_tipo_moneda,
                        id_tipo_existencia = obj.id_tipo_existencia,
                        id_tipo_prod = obj.id_tipo_prod,
                        id_clase_prod = obj.id_clase_prod,
                        id_receta = obj.id_receta,
                        id_combo = obj.id_combo
                    });

                    var subFam = multi.Read<PROt04_subfamilia>().FirstOrDefault();
                    var um = multi.Read<SNTt06_unidad_medida>().FirstOrDefault();
                    var model = multi.Read<PROt02_modelo>().FirstOrDefault();
                    var imp = multi.Read<MSTt06_impuesto>().FirstOrDefault();
                    var mon = multi.Read<SNTt04_tipo_moneda>().FirstOrDefault();
                    var tipoExis = multi.Read<SNTt05_tipo_existencia>().FirstOrDefault();
                    var tipoProd = multi.Read<PROt07_tipo_prod>().FirstOrDefault();
                    var clase = multi.Read<PROt06_clase_prod>().FirstOrDefault();
                    var recet = multi.Read<PROt10_receta>().FirstOrDefault();
                    var combo = multi.Read<PROt13_combo>().FirstOrDefault();

                    obj.PROt04_subfamilia = subFam;
                    obj.SNTt06_unidad_medida = um;
                    obj.PROt02_modelo = model;
                    obj.MSTt06_impuesto = imp;
                    obj.SNTt04_tipo_moneda = mon;
                    obj.SNTt05_tipo_existencia = tipoExis;
                    obj.PROt07_tipo_prod = tipoProd;
                    obj.PROt06_clase_prod = clase;
                    obj.PROt10_receta = recet;
                    obj.PROt13_combo = combo;

                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Producto MM por ID: ", e.Message);
                }
            }
            return obj;
        }
        public List<PROt09_producto> ListaProductoXNom(string nombre, int? id_estado = null)
        {
            var lista = new List<PROt09_producto>();
            string txt_desc = "%" + nombre.Trim() + "%";
            string sentencia = string.Empty;
            sentencia = id_estado == null ? "SELECT * from PROt09_producto WHERE txt_desc LIKE @txt_desc"
                : "SELECT * from PROt09_producto WHERE txt_desc LIKE @txt_desc AND id_estado=@id_estado";

            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<PROt09_producto>(sentencia, new { txt_desc, id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Producto por Nombre: ", e.Message);
                }
            }
            return lista;
        }
        public List<PROt09_producto> ListaProductoXMod(int id_modelo, int? id_estado = null)
        {
            var lista = new List<PROt09_producto>();
            string sentencia = string.Empty;
            sentencia = id_estado == null ? "SELECT * FROM PROt09_producto WHERE id_modelo=@id_modelo"
                : "SELECT * FROM PROt09_producto WHERE id_modelo=@id_modelo AND id_estado=@id_estado";

            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<PROt09_producto>(sentencia, new { id_modelo, id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Producto por Modelo: ", e.Message);
                }
            }
            return lista;
        }

        public IEnumerable<PROt09_producto> BuscarProductos(string cod, string cod02, string nombre, int? snVenta, int? snCompra, int? idEstado)
        {
            using (IDbConnection cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    return cnn.Query<PROt09_producto>("SP_PROD_CNS_Producto",
                                                        new { cod, cod02, nombre, snVenta, snCompra, idEstado },
                                                        commandType: CommandType.StoredProcedure);
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Buscar Productos: ", e.Message);
                    return new List<PROt09_producto>();
                }
            }
        }

        public decimal GetPvPuConIgvProductoXId(long id)
        {
            decimal pvpuconigv = 0;
            var queryString = @"SELECT mto_pvpu_con_igv from PROt09_producto WHERE id_producto = @id_producto";
            using (var connection =
                new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                var command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@id_producto", id);

                try
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string column = reader["mto_pvpu_con_igv"].ToString();
                            decimal.TryParse(column, out pvpuconigv);
                        }
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Get Precio de venta por unidad con IGV por ID: ", e.Message);
                }
            }
            return pvpuconigv;
        }
    }
}