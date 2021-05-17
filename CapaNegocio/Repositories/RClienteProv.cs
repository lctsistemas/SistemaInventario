using CapaDatos.Contracts;
using CapaDatos.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Repositories
{
    public class RClienteProv : IClienteProv
    {
        private SqlCommand cmd;
        private string result = "";
        private bool estado=true;
        public string Add(DClienteProv Entity)
        {
            using (SqlConnection connect = Dconexion.Getconectar())
            {
                connect.Open();
                try
                {
                    using (cmd = new SqlCommand())
                    {
                        cmd.Connection = connect;
                        cmd.CommandText = "manto.SP_AddCliProv";
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@nom_prov", Entity.Nom_prov);
                        cmd.Parameters.AddWithValue("@ruc", Entity.Ruc);

                        result = cmd.ExecuteNonQuery() == 1 ? "Registrado Correctamente!" : "Error al Regsitrar";

                        cmd.Parameters.Clear();
                    }
                }
                catch (Exception ex)
                {
                    SqlException sqlex = ex as SqlException;
                    if (sqlex != null && sqlex.Number == 2627)
                    {
                        result = "EL RUC "+Entity.Ruc+" INGRESADO YA SE ENCUENTRA REGISTRADO";
                        
                    }
                    else
                        result = ex.Message;


                }
            } //aqui esta cerrando la conexion.
            return result;
        }

        public string Delete(DClienteProv Entity)
        {
            throw new NotImplementedException();
        }

        public string Edit(DClienteProv Entity)
        {
            throw new NotImplementedException();
        }

        public List<DClienteProv> Getdata(DClienteProv Entity)
        {
            throw new NotImplementedException();
        }
    }
}
