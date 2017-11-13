using ConfigBusinessEntity;
using ConfigUtilitarios;
using ConfigUtilitarios.ViewModels;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigDataAccess.Producto
{
    public class ComboVariableDetalleDA
    {

        public List<ComboItem> ListaDetalleXCboVar(long id_cbo_var)
        {
            string sentencia = @"select dtl.cantidad, prod.txt_desc txt_desc_item, dtl.id_estado 
                                    from PROt16_combo_variable_dtl dtl
                                    inner join PROt09_producto prod on dtl.id_producto = prod.id_producto
                                    where dtl.id_combo_variable = @id_cbo_var";
            var lista = new List<ComboItem>();
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<ComboItem>(sentencia, new { id_cbo_var }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Detalle x ID CBO. VAR: ", e.Message);
                }
            }
            return lista;
        }



    }
}
