using CapaDatos.Contracts;
using CapaDatos.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio.Repositories
{
    public class RTipoExistencia : ITipoExistencia
    {
        private SqlCommand cmd;
        private string result = "";
        private List<DTipoExistencia> listTipoExist;

        public string Add(DTipoExistencia Entity)
        {
            using (SqlConnection connect = Dconexion.Getconectar())
            {
                connect.Open();
                try
                {
                    using (cmd = new SqlCommand())
                    {
                        cmd.Connection = connect;
                        cmd.CommandText = "manto.SP_AddTipoExist";
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@codigo", Entity.Codigo);
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

        public string Delete(DTipoExistencia Entity)
        {
            using (SqlConnection conn = Dconexion.Getconectar())
            {
                conn.Open();
                cmd = null;
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "manto.SP_DeleteTipoExist";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idtip_exist", Entity.IdTipoExist);


                    result = cmd.ExecuteNonQuery() == 1 ? "Se Elimino Correctamente!" : "Error al Eliminar";

                    cmd.Parameters.Clear();

                }
            }
            return result;
        }

        public string Edit(DTipoExistencia Entity)
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
                        cmd.CommandText = "manto.SP_AddTipoExist";
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@idtip_exist", Entity.IdTipoExist);
                        cmd.Parameters.AddWithValue("@codigo", Entity.Codigo);
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

        #region : METODO IMPORTAR EXCEL
        public List<DTipoExistencia> ImportarAchivoExcel(string url)
        {
            //double sumaEntradas = 0;
            //double sumaSalidas = 0;
            using (OleDbConnection conector = DconexionOffice.GetConectarOffice(url))
            {
                try
                {
                    conector.Open();
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        string sql = "select CODIGO, DESCRIPCION from [TIPO_EXISTENCIA$]";
                        cmd.Connection = conector;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql;

                        OleDbDataAdapter da = new OleDbDataAdapter();
                        da.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            da.Dispose();

                            listTipoExist = new List<DTipoExistencia>();
                            foreach (DataRow item in dt.Rows)
                            {
                                listTipoExist.Add(new DTipoExistencia()
                                {
                                    Codigo = item["CODIGO"].ToString(),
                                    Descripcion = item["DESCRIPCION"].ToString()

                                });

                            }


                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Detalle de Error : " + ex.ToString(), "Error al Importar Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conector.Close();
                }
            }
            return listTipoExist;
        }
        #endregion : FIN IMPORTAR EXCEL

        public List<DTipoExistencia> Getdata(DTipoExistencia Entity)
        {
            using (SqlConnection connect = Dconexion.Getconectar())
            {
                connect.Open();
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = connect;
                    cmd.CommandText = "manto.SP_ShowTipoExist";
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader dtr = cmd.ExecuteReader();
                    using (DataTable dt = new DataTable())
                    {
                        dt.Load(dtr);
                        dtr.Dispose();

                        listTipoExist = new List<DTipoExistencia>();
                        foreach (DataRow item in dt.Rows)
                        {
                            listTipoExist.Add(new DTipoExistencia()
                            {
                                IdTipoExist = Convert.ToInt32(item[0]),
                                Codigo = item[1].ToString(),
                                Descripcion = item[2].ToString()
                            });
                        }
                    }
                }


            }

            return listTipoExist;
        }

        public string Add_Multiple(IEnumerable<DTipoExistencia> lst)
        {
            string result;
            using (SqlConnection connect = Dconexion.Getconectar())
            {
                connect.Open();
                using (SqlTransaction sqltra = connect.BeginTransaction())
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = connect;
                        cmd.Transaction = sqltra;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "manto.SP_AddTipoExist";

                        cmd.Parameters.Add("@codigo", SqlDbType.VarChar, 2);
                        cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 100);


                        try
                        {
                            foreach (var item in lst)
                            {
                                cmd.Parameters["@codigo"].Value = item.Codigo;
                                cmd.Parameters["@descripcion"].Value = item.Descripcion;

                                cmd.ExecuteNonQuery();
                            }
                            sqltra.Commit();
                            result = "El Registro fue Insetados Correctamente";

                        }
                        catch (Exception ex)
                        {
                            sqltra.Rollback();
                            connect.Close();
                            result = ex.ToString();
                        }
                    }
                }
            }
            return result;
        }
    }
}
