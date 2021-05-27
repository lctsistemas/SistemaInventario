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
        //private bool estado=true;
        private List<DClienteProv> listclienteprov;
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
           
            using (SqlConnection conn = Dconexion.Getconectar())
            {
                conn.Open();
                cmd = null;
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "manto.SP_DeleteCliProv";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idcliprov", Entity.Idprov);
                    cmd.Parameters.AddWithValue("@nom_prov", Entity.Nom_prov);
                    cmd.Parameters.AddWithValue("@ruc", Entity.Ruc);

                    result = cmd.ExecuteNonQuery() == 1 ? "Se Modifico Correctamente!" : "Error al Modificar";

                    cmd.Parameters.Clear();

                }
            }
            return result;
        }

        public string Edit(DClienteProv Entity)
        {
            result = "";
            using (SqlConnection connect = Dconexion.Getconectar())
            {
                connect.Open();
                try
                {
                    using (cmd = new SqlCommand())
                    {
                        cmd.Connection = connect;
                        cmd.CommandText = "manto.SP_EditCliProv";
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@idcliprov", Entity.Idprov);
                        cmd.Parameters.AddWithValue("@nom_prov", Entity.Nom_prov);
                        cmd.Parameters.AddWithValue("@ruc", Entity.Ruc);


                        result = cmd.ExecuteNonQuery() == 1 ? "Se Modifico Correctamente!" : "Error al Modificar";

                        cmd.Parameters.Clear();
                    }
                }
                catch (Exception ex)
                {
                    result = ex.Message;
                }
            }
            return result;
        }

        public List<DClienteProv> Getdata(DClienteProv Entity)
        {
            using (SqlConnection connect = Dconexion.Getconectar())
            {
                connect.Open();
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = connect;
                    cmd.CommandText = "manto.SP_ShowCliProv";
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader dtr = cmd.ExecuteReader();
                    using (DataTable dt = new DataTable())
                    {
                        dt.Load(dtr);
                        dtr.Dispose();

                        listclienteprov = new List<DClienteProv>();
                        foreach (DataRow item in dt.Rows)
                        {
                            listclienteprov.Add(new DClienteProv()
                            {
                                Idprov = Convert.ToInt32(item[0]),
                                Nom_prov = item[1].ToString(),
                                Ruc = item[2].ToString()
                            });
                        }
                    }
                }


            }

            return listclienteprov;
        }

        //BUSCAR Cliente Proveedor
        public IEnumerable<DClienteProv> Search(string filter)
        {
            return listclienteprov.FindAll(e => e.Nom_prov.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0 || e.Ruc.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0);
        }
    }
}
