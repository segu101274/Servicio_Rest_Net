using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Secund.BE;
using Secund.DA.Base;

namespace Secund.DA 
{
    public class DACliente : BaseDalcMySql
    {
        public DataTable LoginSeleccionarUno(string sRucCli, string sClave)
        {
            AbrirConexionMySql();

            try
            {
                var cmd = ObtenerCommand("pClienteLoginSeleccionarUno");
                cmd.Parameters.AddWithValue("$rucCli", sRucCli);
                cmd.Parameters.AddWithValue("$Clave", sClave);

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

        public DataTable SeleccionarTodos()
        {
            AbrirConexionMySql();

            try
            {
                var cmd = ObtenerCommand("pClienteSeleccionarTodos");

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

        //public DataTable LoginSeleccionarUno(string sCodigo, string sClave)
        //{
        //    AbrirConexionPrincipal();

        //    try
        //    {
        //        var cmd = ObtenerCommand("pClienteLoginSeleccionarUno");
        //        cmd.Parameters.AddWithValue("@Codigo", sCodigo);
        //        cmd.Parameters.AddWithValue("@Clave", sClave);

        //        var adapter = new SqlDataAdapter(cmd);

        //        // Fill the DataSet.
        //        DataSet ds = new DataSet();
        //        adapter.Fill(ds, "dt");

        //        if (ds.Tables.Count > 0)
        //        {
        //            return ds.Tables[0];
        //        }

        //        return null;
        //    }
        //    finally
        //    {
        //        CerrarConexion();
        //    }
        //}

        //public DataTable SeleccionarTodos()
        //{
        //    AbrirConexionPrincipal();

        //    try
        //    {
        //        var cmd = ObtenerCommand("pClienteSeleccionarTodos");

        //        var adapter = new SqlDataAdapter(cmd);

        //        // Fill the DataSet.
        //        DataSet ds = new DataSet();
        //        adapter.Fill(ds, "dt");

        //        if (ds.Tables.Count > 0)
        //        {
        //            return ds.Tables[0];
        //        }

        //        return null;
        //    }
        //    finally
        //    {
        //        CerrarConexion();
        //    }
        //}
    }
}
