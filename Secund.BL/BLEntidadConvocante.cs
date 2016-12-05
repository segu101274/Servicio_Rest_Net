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
    public class BLEntidadConvocante
    {
        public void Agregar(BEEntidadConvocante oBEEntidadConvocante)
        {
            var oDAEntidadConvocante = new DAEntidadConvocante();
            oDAEntidadConvocante.Agregar(oBEEntidadConvocante);
        }

        public List<BEEntidadConvocante> SeleccionarTodos()
        {
            var oDAEntidadConvocante = new DAEntidadConvocante();
            var dtEntidadConvocante = oDAEntidadConvocante.SeleccionarTodos();

            if (dtEntidadConvocante != null)
            {
                if (dtEntidadConvocante.Rows.Count > 0)
                {
                    var oListaClientes = new List<BEEntidadConvocante>();
                    foreach (DataRow dr in dtEntidadConvocante.Rows)
                    {
                        oListaClientes.Add(new BEEntidadConvocante
                        {
                            codEnt = dr["codEnt"] != DBNull.Value ? Convert.ToInt32(dr["codEnt"]) : 0,
                            rucEnt = dr["rucEnt"] != DBNull.Value ? Convert.ToString(dr["rucEnt"]) : string.Empty,
                            desEnt = dr["desEnt"] != DBNull.Value ? Convert.ToString(dr["desEnt"]) : string.Empty,
                            dirEnt = dr["dirEnt"] != DBNull.Value ? Convert.ToString(dr["dirEnt"]) : string.Empty,
                            estEnt = dr["estEnt"] != DBNull.Value ? Convert.ToInt32(dr["estEnt"]) : 0,
                        });
                    }

                    return oListaClientes;
                }
                return null;
            }
            return null;
        }
    }
}
