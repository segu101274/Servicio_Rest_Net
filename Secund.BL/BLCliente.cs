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
    public class BLCliente
    {
        public BECliente LoginSeleccionarUno(string sRucCli, string sClave)
        {
            var oDAClientes = new DACliente();
            var dtClientes = oDAClientes.LoginSeleccionarUno(sRucCli, sClave);

            if (dtClientes != null)
            {
                if (dtClientes.Rows.Count > 0)
                {
                    var oListaClientes = new List<BECliente>();
                    foreach (DataRow dr in dtClientes.Rows)
                    {
                        return new BECliente
                        {
                            codCli = dr["codCli"] != DBNull.Value ? Convert.ToInt32(dr["codCli"]) : 0,
                            rucCli = dr["rucCli"] != DBNull.Value ? Convert.ToString(dr["rucCli"]) : string.Empty,
                            razSocCli = dr["razSocCli"] != DBNull.Value ? Convert.ToString(dr["razSocCli"]) : string.Empty,
                            corCli = dr["corCli"] != DBNull.Value ? Convert.ToString(dr["corCli"]) : string.Empty,
                            pasCli = dr["pasCli"] != DBNull.Value ? Convert.ToString(dr["pasCli"]) : string.Empty,
                            fecRegCli = dr["fecRegCli"] != DBNull.Value ? Convert.ToDateTime(dr["fecRegCli"]) : DateTime.MinValue,
                            tipTarCli = dr["tipTarCli"] != DBNull.Value ? Convert.ToString(dr["tipTarCli"]) : string.Empty,
                            numTarCli = dr["numTarCli"] != DBNull.Value ? Convert.ToString(dr["numTarCli"]) : string.Empty,
                            flgAboCli = dr["flgAboCli"] != DBNull.Value ? Convert.ToInt32(dr["flgAboCli"]) : 0,
                            estCli = dr["estCli"] != DBNull.Value ? Convert.ToInt32(dr["estCli"]) : 0,
                        };
                    }
                }
                return null;
            }
            return null;
        }

        public List<BECliente> SeleccionarTodos()
        {
            var oDAClientes = new DACliente();
            var dtClientes = oDAClientes.SeleccionarTodos();

            if (dtClientes != null)
            {
                if (dtClientes.Rows.Count > 0)
                {
                    var oListaClientes = new List<BECliente>();
                    foreach (DataRow dr in dtClientes.Rows)
                    {
                        oListaClientes.Add(new BECliente
                        {
                            codCli = dr["codCli"] != DBNull.Value ? Convert.ToInt32(dr["codCli"]) : 0,
                            rucCli = dr["rucCli"] != DBNull.Value ? Convert.ToString(dr["rucCli"]) : string.Empty,
                            razSocCli = dr["razSocCli"] != DBNull.Value ? Convert.ToString(dr["razSocCli"]) : string.Empty,
                            corCli = dr["corCli"] != DBNull.Value ? Convert.ToString(dr["corCli"]) : string.Empty,
                            pasCli = dr["pasCli"] != DBNull.Value ? Convert.ToString(dr["pasCli"]) : string.Empty,
                            fecRegCli = dr["fecRegCli"] != DBNull.Value ? Convert.ToDateTime(dr["fecRegCli"]) : DateTime.MinValue,
                            tipTarCli = dr["tipTarCli"] != DBNull.Value ? Convert.ToString(dr["tipTarCli"]) : string.Empty,
                            numTarCli = dr["numTarCli"] != DBNull.Value ? Convert.ToString(dr["numTarCli"]) : string.Empty,
                            flgAboCli = dr["flgAboCli"] != DBNull.Value ? Convert.ToInt32(dr["flgAboCli"]) : 0,
                            estCli = dr["estCli"] != DBNull.Value ? Convert.ToInt32(dr["estCli"]) : 0,
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
