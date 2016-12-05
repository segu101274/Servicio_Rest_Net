using System;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

namespace Secund.DA.Base
{
    public class BaseDalcMySql
    {

        #region Declaración de Variables
        
        protected MySqlConnection Con;
        protected MySqlDataReader Reader;
        private string _cadenaConexion;
        private string _cadenaConexionOriginal;
        private int _deep;
        private string _flagContrasenaEncriptada = string.Empty;

        #endregion

        #region Selección de objetos Command

        protected MySqlCommand ObtenerCommand(String sp)
        {
            var com = new MySqlCommand(sp, Con)
            {
                CommandType = CommandType.StoredProcedure
            };
            return com;
        }

        #endregion

        #region Otros Métodos

        public void AbrirConexionMySql()
        {
            if (_deep == 0)
            {

                Con = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConexionMySQL"].ConnectionString);
                Con.Open();
            }
            _deep++;
        }
        
        public void CerrarConexion()
        {
            _deep--;
            if (_deep <= 0)
            {
                _deep = 0;
                Con.Close();
                Con = null;
            }
            if (Reader == null) return;
            Reader.Close();
            Reader = null;
        }
        
        #endregion

    }
}