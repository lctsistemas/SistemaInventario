using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaDatos.Entities;

namespace CapaNegocio.Repositories
{
    public class RLogin : IDisposable
    {       

        public int GetIdPeriodo(int desc_periodo)
        {
            int cod_periodo;
            using (SqlConnection cnn = Dconexion.Getconectar())
            {
                cnn.Open();              
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "manto.ShowPeriodo";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@periodo", desc_periodo);
                    cmd.Parameters.Add("@idperiodo", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.ExecuteScalar();
                    cod_periodo = Convert.ToInt32(cmd.Parameters["@idperiodo"].Value);

                }
            }
            return cod_periodo;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

    }
}
