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
    public class RMoneda : IMoneda
    {
        private SqlCommand cmd;
        private string result = "";
        private List<DMoneda> listmoneda;
        public string Add(DMoneda Entity)
        {
            using (SqlConnection connect = Dconexion.Getconectar())
            {
                connect.Open();
                try
                {
                    using (cmd = new SqlCommand())
                    {
                        cmd.Connection = connect;
                        cmd.CommandText = "manto.SP_AddMoneda";
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@codigo", Entity.Codigo);
                        cmd.Parameters.AddWithValue("@nom_moneda", Entity.Nom_moneda);
                        cmd.Parameters.AddWithValue("@abrev", Entity.Abrev);
                        cmd.Parameters.AddWithValue("@simbolo", Entity.Simbolo);
                        cmd.Parameters.AddWithValue("@descripcion", Entity.Descripcion);

                        result = cmd.ExecuteNonQuery() == 1 ? "Registrado Correctamente!" : "Error al Regsitrar";

                        cmd.Parameters.Clear();
                    }
                }
                catch (Exception ex)
                {
                    SqlException sqlex = ex as SqlException;
                    if (sqlex != null && sqlex.Number == 2627)
                    {
                        result = "EL CODIGO INGRESADO YA SE ENCUENTRA REGISTRADO";
                    }
                    else
                        result = ex.Message;


                }
            } //aqui esta cerrando la conexion.
            return result;
        }

        public string Delete(DMoneda Entity)
        {
            using (SqlConnection conn = Dconexion.Getconectar())
            {
                conn.Open();
                cmd = null;
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "manto.SP_DeleteMoneda";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idmoneda", Entity.Idmoneda);


                    result = cmd.ExecuteNonQuery() == 1 ? "Se Elimino Correctamente!" : "Error al Eliminar";

                    cmd.Parameters.Clear();

                }
            }
            return result;
        }

        public string Edit(DMoneda Entity)
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
                        cmd.CommandText = "manto.SP_EditMoneda";
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@idmoneda", Entity.Idmoneda);
                        cmd.Parameters.AddWithValue("@codigo", Entity.Nom_moneda);
                        cmd.Parameters.AddWithValue("@nom_moneda", Entity.Abrev);
                        cmd.Parameters.AddWithValue("@simbolo", Entity.Simbolo);
                        cmd.Parameters.AddWithValue("@descripcion", Entity.Descripcion);


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

        public List<DMoneda> Getdata(DMoneda Entity)
        {
            using (SqlConnection connect = Dconexion.Getconectar())
            {
                connect.Open();
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = connect;
                    cmd.CommandText = "manto.SP_ShowMon";
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader dtr = cmd.ExecuteReader();
                    using (DataTable dt = new DataTable())
                    {
                        dt.Load(dtr);
                        dtr.Dispose();

                        listmoneda = new List<DMoneda>();
                        foreach (DataRow item in dt.Rows)
                        {
                            listmoneda.Add(new DMoneda()
                            {
                                Idmoneda = Convert.ToInt32(item[0]),
                                Codigo = item[1].ToString(),
                                Nom_moneda = item[2].ToString(),
                                Abrev = item[3].ToString(),
                                Simbolo = item[4].ToString(),
                                Descripcion = item[5].ToString()

                            });
                        }
                    }
                }
            }
            return listmoneda;
        }

        public IEnumerable<DMoneda> Search(string filter)
        {
            return listmoneda.FindAll(e => e.Nom_moneda.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0 || e.Abrev.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0);
        }
    }
}
