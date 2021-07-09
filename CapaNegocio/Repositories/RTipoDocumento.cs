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
    public class RTipoDocumento : ITipoDoc
    {
        private SqlCommand cmd;
        private string result = "";
        private List<DTipoDocumento> listTipoDoc;
        public string Add(DTipoDocumento Entity)
        {
            using (SqlConnection connect = Dconexion.Getconectar())
            {
                connect.Open();
                try
                {
                    using (cmd = new SqlCommand())
                    {
                        cmd.Connection = connect;
                        cmd.CommandText = "manto.SP_AddDocumento";
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

        public string Delete(DTipoDocumento Entity)
        {
            throw new NotImplementedException();
        }

        public string Edit(DTipoDocumento Entity)
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
                        cmd.CommandText = "manto.SP_EditDocumento";
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@iddoc", Entity.Iddocumento);
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

        public List<DTipoDocumento> Getdata(DTipoDocumento Entity)
        {
            using (SqlConnection connect = Dconexion.Getconectar())
            {
                connect.Open();
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = connect;
                    cmd.CommandText = "manto.SP_ShowDoc";
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader dtr = cmd.ExecuteReader();
                    using (DataTable dt = new DataTable())
                    {
                        dt.Load(dtr);
                        dtr.Dispose();

                        listTipoDoc = new List<DTipoDocumento>();
                        foreach (DataRow item in dt.Rows)
                        {
                            listTipoDoc.Add(new DTipoDocumento()
                            {
                                Iddocumento = Convert.ToInt32(item[0]),
                                Codigo = item[1].ToString(),
                                Descripcion = item[2].ToString()
                            });
                        }
                    }
                }
            }
            return listTipoDoc;
        }

        #region : METODO IMPORTAR EXCEL
        public List<DTipoDocumento> ImportarAchivoExcel(string url)
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
                        string sql = "select CODIGO, DESCRIPCION from [TIPO_DOCUMENTO$]";
                        cmd.Connection = conector;
                        cmd.CommandText = sql;

                        OleDbDataAdapter da = new OleDbDataAdapter();
                        da.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            da.Dispose();

                            listTipoDoc = new List<DTipoDocumento>();
                            foreach (DataRow item in dt.Rows)
                            {
                                listTipoDoc.Add(new DTipoDocumento()
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
            return listTipoDoc;
        }
        #endregion : FIN IMPORTAR EXCEL
        public IEnumerable<DTipoDocumento> Search(string filter)
        {
            return listTipoDoc.FindAll(e => e.Codigo.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0);
        }
    }
}
