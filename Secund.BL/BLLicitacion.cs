using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Secund.BE;
using Secund.DA;

namespace Secund.BL
{
    public class BLLicitacion
    {
        public List<BELicitacion> SeleccionarTodosxFiltros(int iIdCategoria)
        {
            var oDALicitacion = new DALicitacion();
            var dtLicitacion = oDALicitacion.SeleccionarTodosxFiltros(iIdCategoria);

            if (dtLicitacion != null)
            {
                if (dtLicitacion.Rows.Count > 0)
                {
                    var oListaLicitacion = new List<BELicitacion>();
                    foreach (DataRow dr in dtLicitacion.Rows)
                    {
                        oListaLicitacion.Add(new BELicitacion
                        {
                            codLic = dr["codLic"] != DBNull.Value ? Convert.ToInt32(dr["codLic"]) : 0,
                            nomLic = dr["nomLic"] != DBNull.Value ? Convert.ToString(dr["nomLic"]) : string.Empty,
                            desLic = dr["desLic"] != DBNull.Value ? Convert.ToString(dr["desLic"]) : string.Empty,
                            norAplLic = dr["norAplLic"] != DBNull.Value ? Convert.ToString(dr["norAplLic"]) : string.Empty,
                            valRef = dr["valRef"] != DBNull.Value ? Convert.ToDouble(dr["valRef"]) : 0,
                            fecPubLic = dr["fecPubLic"] != DBNull.Value ? Convert.ToDateTime(dr["fecPubLic"]) : DateTime.MinValue,
                            fecTerLic = dr["fecTerLic"] != DBNull.Value ? Convert.ToDateTime(dr["fecTerLic"]) : DateTime.MinValue,
                            monLic = dr["monLic"] != DBNull.Value ? Convert.ToString(dr["monLic"]) : string.Empty,
                            verSeaLic = dr["verSeaLic"] != DBNull.Value ? Convert.ToInt32(dr["verSeaLic"]) : 0,
                            estLic = dr["estLic"] != DBNull.Value ? Convert.ToInt32(dr["estLic"]) : 0,
                            desEnt = dr["desEnt"] != DBNull.Value ? Convert.ToString(dr["desEnt"]) : string.Empty,
                            desCat = dr["desCat"] != DBNull.Value ? Convert.ToString(dr["desCat"]) : string.Empty,
                        });
                    }

                    return oListaLicitacion;
                }
                return null;
            }
            return null;
        }
    }
}
