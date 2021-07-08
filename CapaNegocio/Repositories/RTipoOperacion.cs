using CapaDatos.Contracts;
using CapaDatos.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CapaNegocio.Repositories
{
    public class RTipoOperacion:ITipoOperacion
    {
        private SqlCommand cmd;
        private string result = "";
        private List<DTipoOperacion> listTipoOper;
        public string Add(DTipoOperacion Entity)
        {
            using (SqlConnection connect = Dconexion.Getconectar())
            {
                connect.Open();
                try
                {
                    using (cmd = new SqlCommand())
                    {
                        cmd.Connection = connect;
                        cmd.CommandText = "manto.SP_AddTipoOper";
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

        public string Delete(DTipoOperacion Entity)
        {
            using (SqlConnection conn = Dconexion.Getconectar())
            {
                conn.Open();
                cmd = null;
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "manto.SP_DeleteTipoOpera";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idtipOper", Entity.IdTipo_Oper);


                    result = cmd.ExecuteNonQuery() == 1 ? "Se Elimino Correctamente!" : "Error al Eliminar";

                    cmd.Parameters.Clear();

                }
            }
            return result;
        }

        public string Edit(DTipoOperacion Entity)
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
                        cmd.CommandText = "manto.SP_EditTipoOper";
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@idtipOper", Entity.IdTipo_Oper);
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

        public List<DTipoOperacion> Getdata(DTipoOperacion Entity)
        {
            using (SqlConnection connect = Dconexion.Getconectar())
            {
                connect.Open();
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = connect;
                    cmd.CommandText = "manto.SP_ShowTipoOper";
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader dtr = cmd.ExecuteReader();
                    using (DataTable dt = new DataTable())
                    {
                        dt.Load(dtr);
                        dtr.Dispose();

                        listTipoOper = new List<DTipoOperacion>();
                        foreach (DataRow item in dt.Rows)
                        {
                            listTipoOper.Add(new DTipoOperacion()
                            {
                                IdTipo_Oper = Convert.ToInt32(item[0]),
                                Codigo = item[1].ToString(),
                                Descripcion = item[2].ToString()
                            });
                        }
                    }
                }


            }

            return listTipoOper;
        }

        #region : METODO IMPORTAR EXCEL
        public List<DTipoOperacion> ImportarAchivoExcel(string url)
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
                        string sql = "select CODIGO, DESCRIPCION from [TIPO_DE_OPERACION$]";
                        cmd.Connection = conector;
                        cmd.CommandText = sql;

                        OleDbDataAdapter da = new OleDbDataAdapter();
                        da.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            da.Dispose();

                            listTipoOper = new List<DTipoOperacion>();
                            foreach (DataRow item in dt.Rows)
                            {
                                listTipoOper.Add(new DTipoOperacion()
                                {
                                    Codigo=item["CODIGO"].ToString(),
                                    Descripcion=item["DESCRIPCION"].ToString()

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
            return listTipoOper;
        }
        #endregion : FIN IMPORTAR EXCEL

        public IEnumerable<DTipoOperacion> Search(string filter)
        {
            return listTipoOper.FindAll(e => e.Codigo.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0);
        }
    }
}
