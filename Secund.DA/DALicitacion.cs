using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Secund.BE;
using Secund.DA.Base;

namespace Secund.DA
{
    public class DALicitacion : BaseDalcMySql
    {
        public DataTable SeleccionarTodosxFiltros(int iIdCategoria)
        {
            AbrirConexionMySql();

            try
            {
                var cmd = ObtenerCommand("pLicitacionSeleccionarTodosxFiltros");
                cmd.Parameters.AddWithValue("$IdCategoria", iIdCategoria);

                var adapter = new MySqlDataAdapter(cmd);

                // Fill the DataSet.
                DataSet ds = new DataSet();
                adapter.Fill(ds, "dt");

                if (ds.Tables.Count > 0)
                {
                    return ds.Tables[0];
                }

                return null;
            }
            finally
            {
                CerrarConexion();
            }
        }
    }
}
