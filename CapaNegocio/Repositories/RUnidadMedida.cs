using CapaDatos.Contracts;
using CapaDatos.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio.Repositories
{
    public class RUnidadMedida : IUnidMedida
    {
        private SqlCommand cmd;
        private string result = "";
        private List<DUnidadMedida> listUnidMed;

        public string Add_Multiple(IEnumerable<DUnidadMedida> lst)
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
                        cmd.CommandText = "manto.sp_AddUnidadMedida";

                        cmd.Parameters.Add("@abrev", SqlDbType.VarChar,5);
                        cmd.Parameters.Add("@descripcion", SqlDbType.VarChar,60);


                        try
                        {
                            foreach (var item in lst)
                            {
                                cmd.Parameters["@abrev"].Value = item.Abrev;
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


        public string Add(DUnidadMedida Entity)
        {
            using (SqlConnection connect = Dconexion.Getconectar())
            {
                connect.Open();
                try
                {
                    using (cmd = new SqlCommand())
                    {
                        cmd.Connection = connect;
                        cmd.CommandText = "manto.sp_AddUnidadMedida";
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@abrev", Entity.Abrev);
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

        public string Delete(DUnidadMedida Entity)
        {
            using (SqlConnection conn = Dconexion.Getconectar())
            {
                conn.Open();
                cmd = null;
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "manto.SP_DeleteUnidMed";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idUnidadMedida", Entity.IdUnidadMedida);


                    result = cmd.ExecuteNonQuery() == 1 ? "Se Elimino Correctamente!" : "Error al Eliminar";

                    cmd.Parameters.Clear();

                }
            }
            return result;
        }

        public string Edit(DUnidadMedida Entity)
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
                        cmd.CommandText = "manto.SP_EditUnidMedida";
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@idtipOper", Entity.IdUnidadMedida);
                        cmd.Parameters.AddWithValue("@abrev", Entity.Abrev);
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
        public List<DUnidadMedida> ImportarAchivoExcel(string url)
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
                        string sql = "select ABREVIATURA, DESCRIPCION from [UNIDAD_MEDIDA$]";
                        cmd.Connection = conector;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql;

                        OleDbDataAdapter da = new OleDbDataAdapter();
                        da.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            da.Dispose();

                            listUnidMed = new List<DUnidadMedida>();
                            foreach (DataRow item in dt.Rows)
                            {
                                listUnidMed.Add(new DUnidadMedida()
                                {
                                    Abrev = item["ABREVIATURA"].ToString(),
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
            return listUnidMed;
        }
        #endregion : FIN IMPORTAR EXCEL
        public List<DUnidadMedida> Getdata(DUnidadMedida Entity)
        {
            using (SqlConnection connect = Dconexion.Getconectar())
            {
                connect.Open();
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = connect;
                    cmd.CommandText = "manto.SP_ShowUnidadMed";
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader dtr = cmd.ExecuteReader();
                    using (DataTable dt = new DataTable())
                    {
                        dt.Load(dtr);
                        dtr.Dispose();

                        listUnidMed = new List<DUnidadMedida>();
                        foreach (DataRow item in dt.Rows)
                        {
                            listUnidMed.Add(new DUnidadMedida()
                            {
                                IdUnidadMedida = Convert.ToInt32(item[0]),
                                Abrev = item[1].ToString(),
                                Descripcion = item[2].ToString()
                            });
                        }
                    }
                }


            }

            return listUnidMed;
        }

        public IEnumerable<DUnidadMedida> Search(string filter)
        {
            return listUnidMed.FindAll(e => e.Descripcion.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0);
        }
    }
}
