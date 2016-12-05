using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Secund.DA.Base
{
    ///<summary>
    /// Clase Base de la capa de datos a través de la cual se establecen los procedimientos de apertura y cierre de conexiones hacia las bases de datos.
    /// Actualmente existen varias bases de datos comunes como todos los sistemas como son: ERP, Seguridad y Mensajeria.
    ///</summary>
    public class BaseDalcSql
    {

        #region Declaración de Variables

        protected SqlConnection Con;
        protected SqlDataReader Reader;
        private string _cadenaConexion;
        private string _cadenaConexionOriginal;
        private int _deep;
        private string _flagContrasenaEncriptada = string.Empty;

        #endregion

        #region Selección de objetos Command

        ///<summary>
        /// Crea un objeto command en base a un procedimiento almacenado.
        ///</summary>
        protected SqlCommand ObtenerCommand(String sp)
        {
            var com = new SqlCommand(sp, Con)
            {
                CommandType = CommandType.StoredProcedure
            };
            return com;
        }

        #endregion

        #region Otros Métodos

        ///<summary>
        /// Abre la conexión principal de la aplicación.
        ///</summary>
        public void AbrirConexionPrincipal()
        {
            if (_deep == 0)
            {
                Con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionPrincipal"].ConnectionString);
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