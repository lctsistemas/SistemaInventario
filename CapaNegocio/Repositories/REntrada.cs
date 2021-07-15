using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos.Entities;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace CapaNegocio.Repositories
{
    public class REntrada : IDisposable
    {

       public List<DEntrada> list_entrada;


        #region : METODO IMPORTAR EXCEL
        public List<DEntrada> ImportarAchivoExcel(string url)
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
                        string sql = "select cod_catalogo, tipo_existencia, cod_existencia, fecha_emision, tipo_documento, serie, num_documento, tipo_operacion," +
                                     "existencia, unida_medida, entradas, salidas from [Inv_uni_fisica$]";
                        cmd.Connection = conector;                      
                        cmd.CommandText = sql;

                        OleDbDataAdapter da = new OleDbDataAdapter();
                        da.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            da.Dispose();

                            list_entrada = new List<DEntrada>();
                            foreach (DataRow item in dt.Rows)
                            {
                                list_entrada.Add(new DEntrada()
                                {
                                    //periodo = item[0].ToString(),
                                    //COU = item[1].ToString(),
                                    //numero_asiento = item[2].ToString(),
                                    //cod_anexo = item[3].ToString(),
                                    cod_catalogo = item["cod_catalogo"].ToString(),
                                    tipo_existencia = item["tipo_existencia"].ToString(),
                                    cod_existencia = item["cod_existencia"].ToString(),
                                    //cod_ctl = item[7].ToString(),
                                    //cod_ext_ctl = item[8].ToString(),
                                    fecha_emision = Convert.ToDateTime(item["fecha_emision"]),
                                    tipo_documento = item["tipo_documento"].ToString(),
                                    serie = item["serie"].ToString(),
                                    num_documento = item["num_documento"].ToString(),
                                    tipo_operacion = item["tipo_operacion"].ToString(),
                                    existencia = item["existencia"].ToString(),
                                    unida_medida = item["unida_medida"].ToString(),
                                    entradas = Convert.ToDouble(item["entradas"]),
                                    salidas = Convert.ToDouble(item["salidas"].ToString().Replace("-", "+"))

                                });
                               // sumaEntradas += (double)item["entradas"];
                               // sumaSalidas += Convert.ToDouble(item["salidas"].ToString().Replace("-", "+"));
                            }

                           /*list_entrada.Add(new DEntrada()
                            {
                                cod_catalogo = "TOTAL",
                                /*tipo_existencia = "-",
                                cod_existencia = "-",
                                /*fecha_emision = "",
                                tipo_documento = "-",
                                serie = "-",
                                num_documento = "-",
                                tipo_operacion = "-",
                                existencia = "-",
                                unida_medida = "-",*/
                                //entradas =Convert.ToDouble(sumaEntradas.ToString("N2")),
                                //salidas = Convert.ToDouble(sumaSalidas.ToString("N2")),
                            //});
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Detalle de Error : " + ex.ToString(),"Error al Importar Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conector.Close();
                }
            }
            return list_entrada;
        }
        #endregion : FIN IMPORTAR EXCEL

        #region : METODO INSERTAR INVENTARIO
        public void Add(List<DEntrada> lst)
        {
            //Definir Tabla
            using (DataTable dt = new DataTable())
            {
                dt.Columns.Add("id");
                dt.Columns.Add("cod_catalogo");
                dt.Columns.Add("tipo_existencia");
                dt.Columns.Add("cod_existencia");
                dt.Columns.Add("fecha_emision");
                dt.Columns.Add("tipo_documento");
                dt.Columns.Add("serie");
                dt.Columns.Add("num_documento");
                dt.Columns.Add("tipo_operacion");
                dt.Columns.Add("existencia");
                dt.Columns.Add("unida_medida");
                dt.Columns.Add("entradas");
                dt.Columns.Add("salidas");
                dt.Columns.Add("id_empresa");
                dt.Columns.Add("idperiodo");
                dt.Columns.Add("idmes");

                int i = 1;
                foreach (var item in lst)
                {
                    dt.Rows.Add(i, item.cod_catalogo, item.tipo_existencia, item.cod_existencia, item.fecha_emision, item.tipo_documento,
                        item.serie, item.num_documento, item.tipo_operacion, item.existencia, item.unida_medida, item.entradas, item.salidas, 
                        item.Id_empresa, item.Id_periodo, item.Id_mes);
                    i++;
                }

                using (SqlConnection connect = Dconexion.Getconectar())
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        SqlParameter parameList = new SqlParameter("@ListInventario", SqlDbType.Structured);
                        parameList.TypeName = "invent.Detail";
                        parameList.Value = dt;

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "invent.SP_GUARDAR_INV";
                        cmd.Connection = connect;
                        
                        cmd.Parameters.Add(parameList);

                        cmd.ExecuteNonQuery();

                    }
                }
            }
        }
        #endregion


        public string Add_Multiple(IEnumerable<DEntrada> lst)
        {
            string result;
            using (SqlConnection connect = Dconexion.Getconectar())
            {
                connect.Open();
                using (SqlTransaction sqltra = connect.BeginTransaction())
                {
                    using (SqlCommand cmd =new SqlCommand())
                    {
                        cmd.Connection = connect;
                        cmd.Transaction = sqltra;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "invent.SP_RegistrarInv";

                        cmd.Parameters.Add("@cod_catalogo", SqlDbType.VarChar, 2);
                        cmd.Parameters.Add("@tipo_existencia", SqlDbType.VarChar, 4);
                        cmd.Parameters.Add("@cod_existencia", SqlDbType.VarChar, 30);
                        cmd.Parameters.Add("@fecha_emision", SqlDbType.Date);
                        cmd.Parameters.Add("@tipo_documento", SqlDbType.Char, 2);
                        cmd.Parameters.Add("@serie", SqlDbType.VarChar, 30);
                        cmd.Parameters.Add("@num_documento", SqlDbType.VarChar, 30);
                        cmd.Parameters.Add("@tipo_operacion", SqlDbType.Char, 2);
                        cmd.Parameters.Add("@existencia", SqlDbType.VarChar, 100);
                        cmd.Parameters.Add("@unida_medida", SqlDbType.VarChar, 4);
                        cmd.Parameters.Add("@entradas", SqlDbType.Decimal);
                        cmd.Parameters.Add("@salidas", SqlDbType.Decimal);
                        cmd.Parameters.Add("@id_empresa", SqlDbType.Int);
                        cmd.Parameters.Add("@idperiodo", SqlDbType.SmallInt);
                        cmd.Parameters.Add("@idmes", SqlDbType.TinyInt);

                        try
                        {
                            foreach (var item in lst)
                            {
                                cmd.Parameters["@cod_catalogo"].Value = item.cod_catalogo;
                                cmd.Parameters["@tipo_existencia"].Value = item.tipo_existencia;
                                cmd.Parameters["@cod_existencia"].Value = item.cod_existencia;
                                cmd.Parameters["@fecha_emision"].Value = item.fecha_emision;
                                cmd.Parameters["@tipo_documento"].Value = item.tipo_documento;
                                cmd.Parameters["@serie"].Value = item.serie;
                                cmd.Parameters["@num_documento"].Value = item.num_documento;
                                cmd.Parameters["@tipo_operacion"].Value = item.tipo_operacion;
                                cmd.Parameters["@existencia"].Value = item.existencia;
                                cmd.Parameters["@unida_medida"].Value = item.unida_medida;
                                cmd.Parameters["@entradas"].Value = item.entradas;
                                cmd.Parameters["@salidas"].Value = item.salidas;
                                cmd.Parameters["@id_empresa"].Value = item.Id_empresa;
                                cmd.Parameters["@idperiodo"].Value = item.Id_periodo;
                                cmd.Parameters["@idmes"].Value = item.Id_mes;
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
                            //throw;
                        }
                    }
                }
            }
            return result;
        }


        public bool ValidarInventario(DEntrada den)
        {
            bool boleano;
            using (SqlConnection connect = Dconexion.Getconectar())
            {
                connect.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connect;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "invent.SP_ValidarInventario";

                    cmd.Parameters.AddWithValue("@idempresa", den.Id_empresa);
                    cmd.Parameters.AddWithValue("@idmes", den.Id_mes);
                    cmd.Parameters.AddWithValue("@idperiodo", den.Id_periodo);
                    cmd.Parameters.Add("@output", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.ExecuteScalar();
                    boleano = Convert.ToBoolean(cmd.Parameters["@output"].Value);
                }
            }
            return boleano;
        }

        public DataTable Get_mes()
        {
            DataTable dt = null;
            using (SqlConnection connect = Dconexion.Getconectar())
            {
                connect.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connect;
                    cmd.CommandText = "manto.sp_showMes";
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader dtr = cmd.ExecuteReader();
                    using (dt = new DataTable())
                    {
                        dt.Load(dtr);
                        dtr.Dispose(); 
                    }
                } 
            }
            return dt;
        }

        public void Dispose()
        {
            //llamar metodo liberador
        }


    }
}
