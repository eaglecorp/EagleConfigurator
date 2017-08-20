﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigBusinessEntity;
using Dapper;
using ConfigUtilitarios;

namespace ConfigDataAccess.Sunat
{
    public class SituacionDA
    {
        public List<SNTt24_situacion> ListaSituacion(int? id_estado = null)
        {
            var lista = new List<SNTt24_situacion>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM SNTt24_situacion"
                : @"SELECT * FROM SNTt24_situacion WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<SNTt24_situacion>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista de Situaciones: ", e.Message);
                }
            }
            return lista;
        }
    }
}
