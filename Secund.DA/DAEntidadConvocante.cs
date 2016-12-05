using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Secund.BE;
using Secund.DA.Base;

namespace Secund.DA
{
    public class DAEntidadConvocante : BaseDalcMySql
    {
        public void Agregar(BEEntidadConvocante oBEEntidadConvocante)
        {
            AbrirConexionMySql();

            try
            {
                var cmd = ObtenerCommand("pEntidadConvocanteAgregar");
                cmd.Parameters.AddWithValue("$rucEnt", oBEEntidadConvocante.rucEnt);
                cmd.Parameters.AddWithValue("$desEnt", oBEEntidadConvocante.desEnt);
                cmd.Parameters.AddWithValue("$dirEnt", oBEEntidadConvocante.dirEnt);

                cmd.ExecuteScalar();
            }
            finally
            {
                CerrarConexion();
            }
        }

        public DataTable SeleccionarTodos()
        {
            AbrirConexionMySql();

            try
            {
                var cmd = ObtenerCommand("pEntidadConvocanteSeleccionarTodos");

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
